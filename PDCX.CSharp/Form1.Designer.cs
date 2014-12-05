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
            this.lblGIFTePayHostList = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbGIFTePayHostList = new System.Windows.Forms.ComboBox();
            this.cmbNETePayHostList = new System.Windows.Forms.ComboBox();
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
            this.lblSecureDevice.Location = new System.Drawing.Point(9, 97);
            this.lblSecureDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecureDevice.Name = "lblSecureDevice";
            this.lblSecureDevice.Size = new System.Drawing.Size(112, 20);
            this.lblSecureDevice.TabIndex = 0;
            this.lblSecureDevice.Text = "Secure Device";
            // 
            // cmbSecureDevices
            // 
            this.cmbSecureDevices.DropDownWidth = 150;
            this.cmbSecureDevices.FormattingEnabled = true;
            this.cmbSecureDevices.Location = new System.Drawing.Point(8, 122);
            this.cmbSecureDevices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSecureDevices.Name = "cmbSecureDevices";
            this.cmbSecureDevices.Size = new System.Drawing.Size(298, 28);
            this.cmbSecureDevices.TabIndex = 1;
            this.cmbSecureDevices.SelectedIndexChanged += new System.EventHandler(this.cmbSecureDevices_SelectedIndexChanged);
            this.cmbSecureDevices.TextUpdate += new System.EventHandler(this.cmbSecureDevices_TextUpdate);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(946, 118);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(141, 35);
            this.btnInitialize.TabIndex = 2;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // cmbPadTypes
            // 
            this.cmbPadTypes.DropDownWidth = 150;
            this.cmbPadTypes.FormattingEnabled = true;
            this.cmbPadTypes.Location = new System.Drawing.Point(318, 123);
            this.cmbPadTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPadTypes.Name = "cmbPadTypes";
            this.cmbPadTypes.Size = new System.Drawing.Size(298, 28);
            this.cmbPadTypes.TabIndex = 4;
            this.cmbPadTypes.SelectedIndexChanged += new System.EventHandler(this.cmbPadTypes_SelectedIndexChanged);
            // 
            // lblPadType
            // 
            this.lblPadType.AutoSize = true;
            this.lblPadType.Location = new System.Drawing.Point(320, 98);
            this.lblPadType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPadType.Name = "lblPadType";
            this.lblPadType.Size = new System.Drawing.Size(75, 20);
            this.lblPadType.TabIndex = 3;
            this.lblPadType.Text = "Pad Type";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(627, 97);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(75, 20);
            this.lblComPort.TabIndex = 5;
            this.lblComPort.Text = "Com Port";
            // 
            // nudComPort
            // 
            this.nudComPort.Location = new System.Drawing.Point(624, 125);
            this.nudComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudComPort.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudComPort.Name = "nudComPort";
            this.nudComPort.Size = new System.Drawing.Size(300, 26);
            this.nudComPort.TabIndex = 6;
            this.nudComPort.ValueChanged += new System.EventHandler(this.nudComPort_ValueChanged);
            // 
            // nudConnectTimeout
            // 
            this.nudConnectTimeout.Location = new System.Drawing.Point(226, 184);
            this.nudConnectTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nudConnectTimeout.Size = new System.Drawing.Size(169, 26);
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
            this.lblConnectTimeout.Location = new System.Drawing.Point(231, 159);
            this.lblConnectTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectTimeout.Name = "lblConnectTimeout";
            this.lblConnectTimeout.Size = new System.Drawing.Size(130, 20);
            this.lblConnectTimeout.TabIndex = 10;
            this.lblConnectTimeout.Text = "Connect Timeout";
            // 
            // nudRepsonseTimeout
            // 
            this.nudRepsonseTimeout.Location = new System.Drawing.Point(6, 184);
            this.nudRepsonseTimeout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nudRepsonseTimeout.Size = new System.Drawing.Size(180, 26);
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
            this.lblResponseTimeout.Location = new System.Drawing.Point(9, 159);
            this.lblResponseTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponseTimeout.Name = "lblResponseTimeout";
            this.lblResponseTimeout.Size = new System.Drawing.Size(143, 20);
            this.lblResponseTimeout.TabIndex = 12;
            this.lblResponseTimeout.Text = "Response Timeout";
            // 
            // chkShowDialogs
            // 
            this.chkShowDialogs.AutoSize = true;
            this.chkShowDialogs.Location = new System.Drawing.Point(442, 185);
            this.chkShowDialogs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkShowDialogs.Name = "chkShowDialogs";
            this.chkShowDialogs.Size = new System.Drawing.Size(132, 24);
            this.chkShowDialogs.TabIndex = 14;
            this.chkShowDialogs.Text = "Show Dialogs";
            this.chkShowDialogs.UseVisualStyleBackColor = true;
            // 
            // lblNETePayHostList
            // 
            this.lblNETePayHostList.AutoSize = true;
            this.lblNETePayHostList.Location = new System.Drawing.Point(9, 25);
            this.lblNETePayHostList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNETePayHostList.Name = "lblNETePayHostList";
            this.lblNETePayHostList.Size = new System.Drawing.Size(142, 20);
            this.lblNETePayHostList.TabIndex = 16;
            this.lblNETePayHostList.Text = "NETePay Host List";
            // 
            // lblGIFTePayHostList
            // 
            this.lblGIFTePayHostList.AutoSize = true;
            this.lblGIFTePayHostList.Location = new System.Drawing.Point(370, 25);
            this.lblGIFTePayHostList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGIFTePayHostList.Name = "lblGIFTePayHostList";
            this.lblGIFTePayHostList.Size = new System.Drawing.Size(148, 20);
            this.lblGIFTePayHostList.TabIndex = 19;
            this.lblGIFTePayHostList.Text = "GIFTePay Host List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbGIFTePayHostList);
            this.groupBox2.Controls.Add(this.cmbNETePayHostList);
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
            this.groupBox2.Controls.Add(this.nudComPort);
            this.groupBox2.Controls.Add(this.lblGIFTePayHostList);
            this.groupBox2.Controls.Add(this.nudConnectTimeout);
            this.groupBox2.Controls.Add(this.lblNETePayHostList);
            this.groupBox2.Controls.Add(this.lblConnectTimeout);
            this.groupBox2.Location = new System.Drawing.Point(18, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1144, 246);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // cmbGIFTePayHostList
            // 
            this.cmbGIFTePayHostList.FormattingEnabled = true;
            this.cmbGIFTePayHostList.Location = new System.Drawing.Point(358, 48);
            this.cmbGIFTePayHostList.Name = "cmbGIFTePayHostList";
            this.cmbGIFTePayHostList.Size = new System.Drawing.Size(344, 28);
            this.cmbGIFTePayHostList.TabIndex = 27;
            // 
            // cmbNETePayHostList
            // 
            this.cmbNETePayHostList.FormattingEnabled = true;
            this.cmbNETePayHostList.Location = new System.Drawing.Point(8, 47);
            this.cmbNETePayHostList.Name = "cmbNETePayHostList";
            this.cmbNETePayHostList.Size = new System.Drawing.Size(339, 28);
            this.cmbNETePayHostList.TabIndex = 26;
            this.cmbNETePayHostList.SelectedIndexChanged += new System.EventHandler(this.cmbNETePayHostList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Merchant  ID";
            // 
            // cmbMerchantIDs
            // 
            this.cmbMerchantIDs.DropDownWidth = 150;
            this.cmbMerchantIDs.FormattingEnabled = true;
            this.cmbMerchantIDs.Location = new System.Drawing.Point(724, 49);
            this.cmbMerchantIDs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMerchantIDs.Name = "cmbMerchantIDs";
            this.cmbMerchantIDs.Size = new System.Drawing.Size(326, 28);
            this.cmbMerchantIDs.TabIndex = 25;
            this.cmbMerchantIDs.SelectedIndexChanged += new System.EventHandler(this.cmbMerchantIDs_SelectedIndexChanged);
            this.cmbMerchantIDs.TextUpdate += new System.EventHandler(this.cmbMerchantIDs_TextUpdate);
            // 
            // chkTargetGift
            // 
            this.chkTargetGift.AutoSize = true;
            this.chkTargetGift.Location = new System.Drawing.Point(796, 186);
            this.chkTargetGift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTargetGift.Name = "chkTargetGift";
            this.chkTargetGift.Size = new System.Drawing.Size(111, 24);
            this.chkTargetGift.TabIndex = 21;
            this.chkTargetGift.Text = "Target Gift";
            this.chkTargetGift.UseVisualStyleBackColor = true;
            this.chkTargetGift.CheckedChanged += new System.EventHandler(this.chkTargetGift_CheckedChanged);
            // 
            // chkKeyedTransaction
            // 
            this.chkKeyedTransaction.AutoSize = true;
            this.chkKeyedTransaction.Location = new System.Drawing.Point(612, 185);
            this.chkKeyedTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKeyedTransaction.Name = "chkKeyedTransaction";
            this.chkKeyedTransaction.Size = new System.Drawing.Size(166, 24);
            this.chkKeyedTransaction.TabIndex = 23;
            this.chkKeyedTransaction.Text = "Keyed Transaction";
            this.chkKeyedTransaction.UseVisualStyleBackColor = true;
            this.chkKeyedTransaction.CheckedChanged += new System.EventHandler(this.chkKeyedTransaction_CheckedChanged);
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.Location = new System.Drawing.Point(875, 934);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(230, 65);
            this.btnSubmitRequest.TabIndex = 16;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(249, 934);
            this.lblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(116, 20);
            this.lblClock.TabIndex = 24;
            this.lblClock.Text = "00:00:00.000";
            // 
            // lblTotalTransactionTime
            // 
            this.lblTotalTransactionTime.AutoSize = true;
            this.lblTotalTransactionTime.Location = new System.Drawing.Point(42, 934);
            this.lblTotalTransactionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTransactionTime.Name = "lblTotalTransactionTime";
            this.lblTotalTransactionTime.Size = new System.Drawing.Size(173, 20);
            this.lblTotalTransactionTime.TabIndex = 25;
            this.lblTotalTransactionTime.Text = "Total Transaction Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(13, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1149, 621);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbRequest);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbResponse);
            this.splitContainer1.Size = new System.Drawing.Size(1141, 592);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // rtbRequest
            // 
            this.rtbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRequest.Location = new System.Drawing.Point(0, 0);
            this.rtbRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(560, 592);
            this.rtbRequest.TabIndex = 0;
            this.rtbRequest.Text = "";
            this.rtbRequest.WordWrap = false;
            // 
            // rtbResponse
            // 
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.Location = new System.Drawing.Point(0, 0);
            this.rtbResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(575, 592);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1191, 35);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblMessaging
            // 
            this.lblMessaging.AutoSize = true;
            this.lblMessaging.Location = new System.Drawing.Point(18, 843);
            this.lblMessaging.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessaging.Name = "lblMessaging";
            this.lblMessaging.Size = new System.Drawing.Size(0, 20);
            this.lblMessaging.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1191, 1020);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.ComboBox cmbNETePayHostList;
        private System.Windows.Forms.ComboBox cmbGIFTePayHostList;
    }
}

