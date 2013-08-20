namespace PDCX.CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSecureDevice = new System.Windows.Forms.Label();
            this.cmbSecureDevices = new System.Windows.Forms.ComboBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.cmbPadTypes = new System.Windows.Forms.ComboBox();
            this.lblPadType = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.nudComPort = new System.Windows.Forms.NumericUpDown();
            this.nudConnectTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblConnectTimeout = new System.Windows.Forms.Label();
            this.nudRepsonseTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblResponseTimeout = new System.Windows.Forms.Label();
            this.chkShowDialogs = new System.Windows.Forms.CheckBox();
            this.lblNETePayHostList = new System.Windows.Forms.Label();
            this.txtNETePayHostList = new System.Windows.Forms.TextBox();
            this.txtGIFTePayHostList = new System.Windows.Forms.TextBox();
            this.lblGIFTePayHostList = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMerchantIDs = new System.Windows.Forms.ComboBox();
            this.chkTargetGift = new System.Windows.Forms.CheckBox();
            this.chkKeyedTransaction = new System.Windows.Forms.CheckBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblTotalTransactionTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMessaging = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudComPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConnectTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepsonseTimeout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSecureDevice
            // 
            this.lblSecureDevice.AutoSize = true;
            this.lblSecureDevice.Location = new System.Drawing.Point(6, 94);
            this.lblSecureDevice.Name = "lblSecureDevice";
            this.lblSecureDevice.Size = new System.Drawing.Size(78, 13);
            this.lblSecureDevice.TabIndex = 0;
            this.lblSecureDevice.Text = "Secure Device";
            // 
            // cmbSecureDevices
            // 
            this.cmbSecureDevices.DropDownWidth = 150;
            this.cmbSecureDevices.FormattingEnabled = true;
            this.cmbSecureDevices.Location = new System.Drawing.Point(6, 110);
            this.cmbSecureDevices.Name = "cmbSecureDevices";
            this.cmbSecureDevices.Size = new System.Drawing.Size(200, 21);
            this.cmbSecureDevices.TabIndex = 1;
            this.cmbSecureDevices.SelectedIndexChanged += new System.EventHandler(this.cmbSecureDevices_SelectedIndexChanged);
            this.cmbSecureDevices.TextUpdate += new System.EventHandler(this.cmbSecureDevices_TextUpdate);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(625, 108);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(94, 23);
            this.btnInitialize.TabIndex = 2;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // cmbPadTypes
            // 
            this.cmbPadTypes.DropDownWidth = 150;
            this.cmbPadTypes.FormattingEnabled = true;
            this.cmbPadTypes.Location = new System.Drawing.Point(212, 110);
            this.cmbPadTypes.Name = "cmbPadTypes";
            this.cmbPadTypes.Size = new System.Drawing.Size(200, 21);
            this.cmbPadTypes.TabIndex = 4;
            // 
            // lblPadType
            // 
            this.lblPadType.AutoSize = true;
            this.lblPadType.Location = new System.Drawing.Point(212, 94);
            this.lblPadType.Name = "lblPadType";
            this.lblPadType.Size = new System.Drawing.Size(53, 13);
            this.lblPadType.TabIndex = 3;
            this.lblPadType.Text = "Pad Type";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(418, 94);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(50, 13);
            this.lblComPort.TabIndex = 5;
            this.lblComPort.Text = "Com Port";
            // 
            // nudComPort
            // 
            this.nudComPort.Location = new System.Drawing.Point(418, 110);
            this.nudComPort.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudComPort.Name = "nudComPort";
            this.nudComPort.Size = new System.Drawing.Size(200, 20);
            this.nudComPort.TabIndex = 6;
            this.nudComPort.ValueChanged += new System.EventHandler(this.nudComPort_ValueChanged);
            // 
            // nudConnectTimeout
            // 
            this.nudConnectTimeout.Location = new System.Drawing.Point(6, 71);
            this.nudConnectTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudConnectTimeout.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudConnectTimeout.Name = "nudConnectTimeout";
            this.nudConnectTimeout.Size = new System.Drawing.Size(200, 20);
            this.nudConnectTimeout.TabIndex = 11;
            this.nudConnectTimeout.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblConnectTimeout
            // 
            this.lblConnectTimeout.AutoSize = true;
            this.lblConnectTimeout.Location = new System.Drawing.Point(6, 55);
            this.lblConnectTimeout.Name = "lblConnectTimeout";
            this.lblConnectTimeout.Size = new System.Drawing.Size(88, 13);
            this.lblConnectTimeout.TabIndex = 10;
            this.lblConnectTimeout.Text = "Connect Timeout";
            // 
            // nudRepsonseTimeout
            // 
            this.nudRepsonseTimeout.Location = new System.Drawing.Point(212, 71);
            this.nudRepsonseTimeout.Maximum = new decimal(new int[] {
            3900,
            0,
            0,
            0});
            this.nudRepsonseTimeout.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRepsonseTimeout.Name = "nudRepsonseTimeout";
            this.nudRepsonseTimeout.Size = new System.Drawing.Size(200, 20);
            this.nudRepsonseTimeout.TabIndex = 13;
            this.nudRepsonseTimeout.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblResponseTimeout
            // 
            this.lblResponseTimeout.AutoSize = true;
            this.lblResponseTimeout.Location = new System.Drawing.Point(212, 55);
            this.lblResponseTimeout.Name = "lblResponseTimeout";
            this.lblResponseTimeout.Size = new System.Drawing.Size(96, 13);
            this.lblResponseTimeout.TabIndex = 12;
            this.lblResponseTimeout.Text = "Response Timeout";
            // 
            // chkShowDialogs
            // 
            this.chkShowDialogs.AutoSize = true;
            this.chkShowDialogs.Location = new System.Drawing.Point(505, 35);
            this.chkShowDialogs.Name = "chkShowDialogs";
            this.chkShowDialogs.Size = new System.Drawing.Size(91, 17);
            this.chkShowDialogs.TabIndex = 14;
            this.chkShowDialogs.Text = "Show Dialogs";
            this.chkShowDialogs.UseVisualStyleBackColor = true;
            // 
            // lblNETePayHostList
            // 
            this.lblNETePayHostList.AutoSize = true;
            this.lblNETePayHostList.Location = new System.Drawing.Point(6, 16);
            this.lblNETePayHostList.Name = "lblNETePayHostList";
            this.lblNETePayHostList.Size = new System.Drawing.Size(97, 13);
            this.lblNETePayHostList.TabIndex = 16;
            this.lblNETePayHostList.Text = "NETePay Host List";
            // 
            // txtNETePayHostList
            // 
            this.txtNETePayHostList.Location = new System.Drawing.Point(6, 32);
            this.txtNETePayHostList.Name = "txtNETePayHostList";
            this.txtNETePayHostList.Size = new System.Drawing.Size(200, 20);
            this.txtNETePayHostList.TabIndex = 17;
            // 
            // txtGIFTePayHostList
            // 
            this.txtGIFTePayHostList.Location = new System.Drawing.Point(212, 32);
            this.txtGIFTePayHostList.Name = "txtGIFTePayHostList";
            this.txtGIFTePayHostList.Size = new System.Drawing.Size(200, 20);
            this.txtGIFTePayHostList.TabIndex = 18;
            // 
            // lblGIFTePayHostList
            // 
            this.lblGIFTePayHostList.AutoSize = true;
            this.lblGIFTePayHostList.Location = new System.Drawing.Point(213, 16);
            this.lblGIFTePayHostList.Name = "lblGIFTePayHostList";
            this.lblGIFTePayHostList.Size = new System.Drawing.Size(99, 13);
            this.lblGIFTePayHostList.TabIndex = 19;
            this.lblGIFTePayHostList.Text = "GIFTePay Host List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbMerchantIDs);
            this.groupBox2.Controls.Add(this.btnInitialize);
            this.groupBox2.Controls.Add(this.lblSecureDevice);
            this.groupBox2.Controls.Add(this.chkTargetGift);
            this.groupBox2.Controls.Add(this.cmbSecureDevices);
            this.groupBox2.Controls.Add(this.chkKeyedTransaction);
            this.groupBox2.Controls.Add(this.chkShowDialogs);
            this.groupBox2.Controls.Add(this.lblPadType);
            this.groupBox2.Controls.Add(this.nudRepsonseTimeout);
            this.groupBox2.Controls.Add(this.cmbPadTypes);
            this.groupBox2.Controls.Add(this.lblResponseTimeout);
            this.groupBox2.Controls.Add(this.lblComPort);
            this.groupBox2.Controls.Add(this.txtNETePayHostList);
            this.groupBox2.Controls.Add(this.nudComPort);
            this.groupBox2.Controls.Add(this.lblGIFTePayHostList);
            this.groupBox2.Controls.Add(this.nudConnectTimeout);
            this.groupBox2.Controls.Add(this.lblNETePayHostList);
            this.groupBox2.Controls.Add(this.txtGIFTePayHostList);
            this.groupBox2.Controls.Add(this.lblConnectTimeout);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 143);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Merchant  ID";
            // 
            // cmbMerchantIDs
            // 
            this.cmbMerchantIDs.DropDownWidth = 150;
            this.cmbMerchantIDs.FormattingEnabled = true;
            this.cmbMerchantIDs.Location = new System.Drawing.Point(418, 70);
            this.cmbMerchantIDs.Name = "cmbMerchantIDs";
            this.cmbMerchantIDs.Size = new System.Drawing.Size(200, 21);
            this.cmbMerchantIDs.TabIndex = 25;
            this.cmbMerchantIDs.SelectedIndexChanged += new System.EventHandler(this.cmbMerchantIDs_SelectedIndexChanged);
            this.cmbMerchantIDs.TextUpdate += new System.EventHandler(this.cmbMerchantIDs_TextUpdate);
            // 
            // chkTargetGift
            // 
            this.chkTargetGift.AutoSize = true;
            this.chkTargetGift.Location = new System.Drawing.Point(423, 34);
            this.chkTargetGift.Name = "chkTargetGift";
            this.chkTargetGift.Size = new System.Drawing.Size(76, 17);
            this.chkTargetGift.TabIndex = 21;
            this.chkTargetGift.Text = "Target Gift";
            this.chkTargetGift.UseVisualStyleBackColor = true;
            this.chkTargetGift.CheckedChanged += new System.EventHandler(this.chkTargetGift_CheckedChanged);
            // 
            // chkKeyedTransaction
            // 
            this.chkKeyedTransaction.AutoSize = true;
            this.chkKeyedTransaction.Location = new System.Drawing.Point(602, 35);
            this.chkKeyedTransaction.Name = "chkKeyedTransaction";
            this.chkKeyedTransaction.Size = new System.Drawing.Size(115, 17);
            this.chkKeyedTransaction.TabIndex = 23;
            this.chkKeyedTransaction.Text = "Keyed Transaction";
            this.chkKeyedTransaction.UseVisualStyleBackColor = true;
            this.chkKeyedTransaction.CheckedChanged += new System.EventHandler(this.chkKeyedTransaction_CheckedChanged);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.Location = new System.Drawing.Point(585, 529);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(153, 42);
            this.btnSubmitRequest.TabIndex = 16;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(134, 558);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(82, 13);
            this.lblClock.TabIndex = 24;
            this.lblClock.Text = "00:00:00.000";
            // 
            // lblTotalTransactionTime
            // 
            this.lblTotalTransactionTime.AutoSize = true;
            this.lblTotalTransactionTime.Location = new System.Drawing.Point(9, 558);
            this.lblTotalTransactionTime.Name = "lblTotalTransactionTime";
            this.lblTotalTransactionTime.Size = new System.Drawing.Size(119, 13);
            this.lblTotalTransactionTime.TabIndex = 25;
            this.lblTotalTransactionTime.Text = "Total Transaction Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 347);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbResponse);
            this.splitContainer1.Size = new System.Drawing.Size(719, 328);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtbRequest
            // 
            this.rtbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRequest.Location = new System.Drawing.Point(0, 0);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(353, 328);
            this.rtbRequest.TabIndex = 0;
            this.rtbRequest.Text = "";
            this.rtbRequest.WordWrap = false;
            // 
            // rtbResponse
            // 
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.Location = new System.Drawing.Point(0, 0);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(362, 328);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            this.rtbResponse.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMessaging
            // 
            this.lblMessaging.AutoSize = true;
            this.lblMessaging.Location = new System.Drawing.Point(12, 548);
            this.lblMessaging.Name = "lblMessaging";
            this.lblMessaging.Size = new System.Drawing.Size(0, 13);
            this.lblMessaging.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 576);
            this.Controls.Add(this.lblMessaging);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalTransactionTime);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDCX Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudComPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConnectTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepsonseTimeout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecureDevice;
        private System.Windows.Forms.ComboBox cmbSecureDevices;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.ComboBox cmbPadTypes;
        private System.Windows.Forms.Label lblPadType;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.NumericUpDown nudComPort;
        private System.Windows.Forms.NumericUpDown nudConnectTimeout;
        private System.Windows.Forms.Label lblConnectTimeout;
        private System.Windows.Forms.NumericUpDown nudRepsonseTimeout;
        private System.Windows.Forms.Label lblResponseTimeout;
        private System.Windows.Forms.CheckBox chkShowDialogs;
        private System.Windows.Forms.Label lblNETePayHostList;
        private System.Windows.Forms.TextBox txtNETePayHostList;
        private System.Windows.Forms.TextBox txtGIFTePayHostList;
        private System.Windows.Forms.Label lblGIFTePayHostList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTargetGift;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.CheckBox chkKeyedTransaction;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblTotalTransactionTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtbRequest;
        private System.Windows.Forms.Label lblMessaging;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMerchantIDs;
    }
}

