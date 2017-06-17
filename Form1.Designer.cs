namespace P24TestWindow
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
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTabControl = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMerchantId = new System.Windows.Forms.TextBox();
            this.textBoxPosId = new System.Windows.Forms.TextBox();
            this.textBoxCrc = new System.Windows.Forms.TextBox();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxUrlReturn = new System.Windows.Forms.TextBox();
            this.textBoxApiVersion = new System.Windows.Forms.TextBox();
            this.textBoxSign = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBoxSandBox = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.checkBoxSessionId = new System.Windows.Forms.CheckBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.resultTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultPanel);
            this.splitContainer1.Size = new System.Drawing.Size(943, 700);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataGroupBox);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(384, 700);
            this.dataPanel.TabIndex = 0;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.checkBoxSessionId);
            this.dataGroupBox.Controls.Add(this.btnTest);
            this.dataGroupBox.Controls.Add(this.checkBoxSandBox);
            this.dataGroupBox.Controls.Add(this.btnRegister);
            this.dataGroupBox.Controls.Add(this.btnUpdate);
            this.dataGroupBox.Controls.Add(this.textBoxSign);
            this.dataGroupBox.Controls.Add(this.textBoxApiVersion);
            this.dataGroupBox.Controls.Add(this.textBoxUrlReturn);
            this.dataGroupBox.Controls.Add(this.textBoxCountry);
            this.dataGroupBox.Controls.Add(this.textBoxEmail);
            this.dataGroupBox.Controls.Add(this.textBoxDescription);
            this.dataGroupBox.Controls.Add(this.textBoxCurrency);
            this.dataGroupBox.Controls.Add(this.textBoxAmount);
            this.dataGroupBox.Controls.Add(this.textBoxSessionId);
            this.dataGroupBox.Controls.Add(this.textBoxCrc);
            this.dataGroupBox.Controls.Add(this.textBoxPosId);
            this.dataGroupBox.Controls.Add(this.textBoxMerchantId);
            this.dataGroupBox.Controls.Add(this.label13);
            this.dataGroupBox.Controls.Add(this.label12);
            this.dataGroupBox.Controls.Add(this.label11);
            this.dataGroupBox.Controls.Add(this.label10);
            this.dataGroupBox.Controls.Add(this.label9);
            this.dataGroupBox.Controls.Add(this.label8);
            this.dataGroupBox.Controls.Add(this.label7);
            this.dataGroupBox.Controls.Add(this.label6);
            this.dataGroupBox.Controls.Add(this.label5);
            this.dataGroupBox.Controls.Add(this.label4);
            this.dataGroupBox.Controls.Add(this.label3);
            this.dataGroupBox.Controls.Add(this.label2);
            this.dataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(384, 700);
            this.dataGroupBox.TabIndex = 0;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.resultGroupBox);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(0, 0);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(555, 700);
            this.resultPanel.TabIndex = 0;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.resultTabControl);
            this.resultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGroupBox.Location = new System.Drawing.Point(0, 0);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(555, 700);
            this.resultGroupBox.TabIndex = 0;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBrowser);
            this.tabPage1.Controls.Add(this.textBoxResult);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxToken);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxToken
            // 
            this.textBoxToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxToken.Location = new System.Drawing.Point(68, 6);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(350, 20);
            this.textBoxToken.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOKEN : ";
            // 
            // resultTabControl
            // 
            this.resultTabControl.Controls.Add(this.tabPage1);
            this.resultTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTabControl.Location = new System.Drawing.Point(3, 16);
            this.resultTabControl.Name = "resultTabControl";
            this.resultTabControl.SelectedIndex = 0;
            this.resultTabControl.Size = new System.Drawing.Size(549, 681);
            this.resultTabControl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Merchant Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pos Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CRC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Session Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Currency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Url Return";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Api Version";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Sign";
            // 
            // textBoxMerchantId
            // 
            this.textBoxMerchantId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMerchantId.Location = new System.Drawing.Point(82, 12);
            this.textBoxMerchantId.Name = "textBoxMerchantId";
            this.textBoxMerchantId.Size = new System.Drawing.Size(296, 20);
            this.textBoxMerchantId.TabIndex = 12;
            // 
            // textBoxPosId
            // 
            this.textBoxPosId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPosId.Location = new System.Drawing.Point(82, 38);
            this.textBoxPosId.Name = "textBoxPosId";
            this.textBoxPosId.Size = new System.Drawing.Size(296, 20);
            this.textBoxPosId.TabIndex = 13;
            // 
            // textBoxCrc
            // 
            this.textBoxCrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCrc.Location = new System.Drawing.Point(82, 64);
            this.textBoxCrc.Name = "textBoxCrc";
            this.textBoxCrc.Size = new System.Drawing.Size(296, 20);
            this.textBoxCrc.TabIndex = 14;
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSessionId.Location = new System.Drawing.Point(82, 90);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(296, 20);
            this.textBoxSessionId.TabIndex = 15;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.Location = new System.Drawing.Point(82, 116);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(296, 20);
            this.textBoxAmount.TabIndex = 16;
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrency.Location = new System.Drawing.Point(82, 142);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(296, 20);
            this.textBoxCurrency.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(82, 168);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(296, 20);
            this.textBoxDescription.TabIndex = 18;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(82, 194);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(296, 20);
            this.textBoxEmail.TabIndex = 19;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCountry.Location = new System.Drawing.Point(82, 220);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(296, 20);
            this.textBoxCountry.TabIndex = 20;
            // 
            // textBoxUrlReturn
            // 
            this.textBoxUrlReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlReturn.Location = new System.Drawing.Point(82, 246);
            this.textBoxUrlReturn.Name = "textBoxUrlReturn";
            this.textBoxUrlReturn.Size = new System.Drawing.Size(296, 20);
            this.textBoxUrlReturn.TabIndex = 21;
            // 
            // textBoxApiVersion
            // 
            this.textBoxApiVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApiVersion.Location = new System.Drawing.Point(82, 272);
            this.textBoxApiVersion.Name = "textBoxApiVersion";
            this.textBoxApiVersion.ReadOnly = true;
            this.textBoxApiVersion.Size = new System.Drawing.Size(296, 20);
            this.textBoxApiVersion.TabIndex = 22;
            // 
            // textBoxSign
            // 
            this.textBoxSign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSign.Location = new System.Drawing.Point(82, 298);
            this.textBoxSign.Name = "textBoxSign";
            this.textBoxSign.ReadOnly = true;
            this.textBoxSign.Size = new System.Drawing.Size(296, 20);
            this.textBoxSign.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(168, 324);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 25;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBoxSandBox
            // 
            this.checkBoxSandBox.AutoSize = true;
            this.checkBoxSandBox.Location = new System.Drawing.Point(7, 353);
            this.checkBoxSandBox.Name = "checkBoxSandBox";
            this.checkBoxSandBox.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSandBox.TabIndex = 26;
            this.checkBoxSandBox.Text = "SandBox";
            this.checkBoxSandBox.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 324);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 27;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "RESULT :";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(68, 32);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(467, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // checkBoxSessionId
            // 
            this.checkBoxSessionId.AutoSize = true;
            this.checkBoxSessionId.Location = new System.Drawing.Point(6, 376);
            this.checkBoxSessionId.Name = "checkBoxSessionId";
            this.checkBoxSessionId.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSessionId.TabIndex = 28;
            this.checkBoxSessionId.Text = "UpdateSessionId";
            this.checkBoxSessionId.UseVisualStyleBackColor = true;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.Enabled = false;
            this.btnBrowser.Location = new System.Drawing.Point(424, 4);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(111, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "Run in browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultGroupBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.resultTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.TabControl resultTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSign;
        private System.Windows.Forms.TextBox textBoxApiVersion;
        private System.Windows.Forms.TextBox textBoxUrlReturn;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.TextBox textBoxCrc;
        private System.Windows.Forms.TextBox textBoxPosId;
        private System.Windows.Forms.TextBox textBoxMerchantId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox checkBoxSandBox;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxSessionId;
        private System.Windows.Forms.Button btnBrowser;
    }
}

