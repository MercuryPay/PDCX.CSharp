using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PDCX.CSharp
{
    public partial class Form1 : Form
    {
        private DSIPDCXLib.DsiPDCX _pdcx; 

        public Form1()
        {
            InitializeComponent();                     
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetupForm();
            this.TargetEPayServer();
            this.InstantiatePDCX();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadXMLRequest();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTargetGift_CheckedChanged(object sender, EventArgs e)
        {
            this.TargetEPayServer();
        }

        private void chkKeyedTransaction_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void cmbMerchantIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void cmbMerchantIDs_TextUpdate(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void cmbSecureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void cmbSecureDevices_TextUpdate(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void nudComPort_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateRequest();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            this.CreateRequest(this.BuildSetupRequest());
            this.SubmitRequest();
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            SubmitRequest();
        }

        #endregion Events

        #region Methods

        private void InstantiatePDCX()
        {
            try
            {
                _pdcx = new DSIPDCXLib.DsiPDCX();
            }
            catch (Exception ex)
            {
                string message = "Failed to instantiate PDCX control with Message: " + ex.Message;            

                MessageBox.Show(message,
                                   "Failed to instantiate PDCX control",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                this.rtbResponse.ForeColor = Color.Red;
                this.rtbResponse.Text = message;
            }
        }

        private void SetupForm()
        {
            this.txtNETePayHostList.Text = Config.NETePayHostList;
            this.txtGIFTePayHostList.Text = Config.GIFTePayHostList;
            this.chkTargetGift.Checked = false;
            this.chkShowDialogs.Checked = false;
            this.chkKeyedTransaction.Checked = false;
            this.nudConnectTimeout.Value = 5;
            this.nudRepsonseTimeout.Value = 60;
            this.cmbMerchantIDs.DataSource = Config.MerchantIDList;
            this.cmbSecureDevices.DataSource = Config.SecureDeviceList;
            this.cmbPadTypes.DataSource = Config.PadTypeList;            
            this.nudComPort.Value = 0;           
        }

        private void TargetEPayServer()
        {
            this.txtNETePayHostList.Enabled = !this.chkTargetGift.Checked;
            this.txtGIFTePayHostList.Enabled = this.chkTargetGift.Checked;
        }

        private void LoadXMLRequest()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*.xml)|*.xml";
            ofd.FilterIndex = 0;
            ofd.DefaultExt = "xml";
            ofd.InitialDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), "Samples");

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!String.Equals(Path.GetExtension(ofd.FileName),
                      ".xml",
                      StringComparison.OrdinalIgnoreCase))
                {
                    // Invalid file type selected
                    MessageBox.Show("The type of the selected file is not supported by this application. You must select an XML file.",
                                    "Invalid File Type",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        XDocument xdoc = XDocument.Load(ofd.FileName);
                        this.CreateRequest(xdoc.ToString());
                        this.UpdateRequest();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load XML file with Message: " + ex.Message,
                                    "Exception Loading XML File",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);                    
                    }
                }
            }
        }

        private void CreateRequest(string request)
        {
            this.lblClock.Text = "00:00:00.000";
            this.rtbRequest.Clear();
            this.rtbResponse.Clear();
            this.rtbRequest.Text = request;
        }

        private void UpdateRequest()
        {
            this.lblMessaging.Text = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(this.rtbRequest.Text))
                {
                    XDocument xdoc = XDocument.Parse(this.rtbRequest.Text);

                    var MerchantID = xdoc.Descendants("MerchantID").FirstOrDefault();
                    var SecureDevice = xdoc.Descendants("SecureDevice").FirstOrDefault();
                    var ComPort = xdoc.Descendants("ComPort").FirstOrDefault();
                    var AcctNo = xdoc.Descendants("AcctNo").FirstOrDefault();                    

                    var merchantIDFromComboBox = this.cmbMerchantIDs.Text;
                    if (merchantIDFromComboBox.Contains(" "))
                    {
                        merchantIDFromComboBox = merchantIDFromComboBox.Substring(0, merchantIDFromComboBox.IndexOf(" "));
                    }

                    if (MerchantID != null) MerchantID.Value = merchantIDFromComboBox;
                    if (SecureDevice != null) SecureDevice.Value = this.cmbSecureDevices.Text;
                    if (ComPort != null) ComPort.Value = ((short)(this.nudComPort.Value)).ToString();
                    if (AcctNo != null) AcctNo.Value = this.chkKeyedTransaction.Checked ? "Prompt" : "SecureDevice";                    

                    this.rtbRequest.Clear();
                    this.rtbRequest.Text = xdoc.ToString();
                }               
            }
            catch (Exception ex)
            {
                this.lblMessaging.Text = string.Format("Unable to update request xml with Message: {0}", ex.Message);
            }
        }

        private void SubmitRequest()
        {
            this.rtbResponse.Clear();
            this.rtbResponse.ForeColor = Color.Red;

            Cursor.Current = Cursors.WaitCursor;
            this.btnInitialize.Enabled = false;
            this.btnSubmitRequest.Enabled = false;
            
            try
            {
                string response = this.ProcessTransaction(this.rtbRequest.Text);
                Dictionary<string, string> responseDictionary = XMLHelper.ParseXMLResponse(response);

                if (responseDictionary.ContainsKey("CmdStatus")
                    && (responseDictionary["CmdStatus"] == "Success" || responseDictionary["CmdStatus"] == "Approved"))
                {
                    this.rtbResponse.ForeColor = Color.DarkGreen;
                }

                this.rtbResponse.Text = response;
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Exception thrown submitting request!");
                sb.AppendLine("");
                sb.AppendLine(ex.ToString());
                this.rtbResponse.Text = ex.ToString();
            }
            finally                
            {
                this.btnInitialize.Enabled = true;
                this.btnSubmitRequest.Enabled = true;
                Cursor.Current = Cursors.Default;
            }
        }

        private string ProcessTransaction(string request)
        {
            short processControl = (short)(this.chkShowDialogs.Checked ? 0 : 1);

            DateTime startTime = DateTime.Now;

            string hostList = this.chkTargetGift.Checked ? this.txtGIFTePayHostList.Text : this.txtNETePayHostList.Text;
            _pdcx.ServerIPConfig(hostList, processControl);
            _pdcx.SetConnectTimeout((short)this.nudConnectTimeout.Value);
            _pdcx.SetResponseTimeout((short)this.nudRepsonseTimeout.Value);
            string response = _pdcx.ProcessTransaction(request, processControl, string.Empty, string.Empty);

            TimeSpan ts = DateTime.Now.Subtract(startTime);
            this.lblClock.Text = string.Format("{0}:{1}:{2}.{3}", ts.Hours.ToString("0#"), ts.Minutes.ToString("0#"), ts.Seconds.ToString("0#"), ts.Milliseconds.ToString("#"));

            return response;
        }

        private string BuildSetupRequest()
        {
            Dictionary<string, object> requestDictionary = new Dictionary<string, object>();

            requestDictionary.Add("TranType", "Setup");
            requestDictionary.Add("TranCode", "SecureDeviceInit");
            requestDictionary.Add("PadType", this.cmbPadTypes.Text);
            requestDictionary.Add("SecureDevice", this.cmbSecureDevices.Text);
            requestDictionary.Add("ComPort", this.nudComPort.Value.ToString());

            return XMLHelper.BuildXMLRequest(requestDictionary, "Admin").ToString();
        }

        #endregion Methods

        
    }
}
