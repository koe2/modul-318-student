namespace SBBStationFinder
{
    partial class frmMail
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
            if(disposing && (components != null))
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.edtTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSubject = new System.Windows.Forms.TextBox();
            this.edtVon = new System.Windows.Forms.TextBox();
            this.pnlSmtp = new System.Windows.Forms.Panel();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtSmtpPw = new System.Windows.Forms.TextBox();
            this.edtSmtpUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtSmtpPort = new System.Windows.Forms.TextBox();
            this.edtSmtpServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMailContent = new System.Windows.Forms.TextBox();
            this.cbEdit = new System.Windows.Forms.CheckBox();
            this.pnlSmtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(362, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Senden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // edtTo
            // 
            this.edtTo.Location = new System.Drawing.Point(104, 9);
            this.edtTo.Name = "edtTo";
            this.edtTo.Size = new System.Drawing.Size(151, 20);
            this.edtTo.TabIndex = 1;
            this.edtTo.Text = "example@bluewin.ch";
            this.edtTo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtTo_MouseClick);
            this.edtTo.Enter += new System.EventHandler(this.edtTo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "An:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Von:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Betreff:";
            // 
            // edtSubject
            // 
            this.edtSubject.Location = new System.Drawing.Point(104, 60);
            this.edtSubject.Name = "edtSubject";
            this.edtSubject.Size = new System.Drawing.Size(151, 20);
            this.edtSubject.TabIndex = 3;
            this.edtSubject.Text = "SSB Station Finder";
            this.edtSubject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtTo_MouseClick);
            this.edtSubject.Enter += new System.EventHandler(this.edtTo_Enter);
            // 
            // edtVon
            // 
            this.edtVon.Location = new System.Drawing.Point(104, 35);
            this.edtVon.Name = "edtVon";
            this.edtVon.Size = new System.Drawing.Size(151, 20);
            this.edtVon.TabIndex = 2;
            this.edtVon.Text = "example@mail.ch";
            this.edtVon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtTo_MouseClick);
            this.edtVon.Enter += new System.EventHandler(this.edtTo_Enter);
            // 
            // pnlSmtp
            // 
            this.pnlSmtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSmtp.Controls.Add(this.cbSSL);
            this.pnlSmtp.Controls.Add(this.label6);
            this.pnlSmtp.Controls.Add(this.edtSmtpPw);
            this.pnlSmtp.Controls.Add(this.edtSmtpUser);
            this.pnlSmtp.Controls.Add(this.label7);
            this.pnlSmtp.Controls.Add(this.label5);
            this.pnlSmtp.Controls.Add(this.edtSmtpPort);
            this.pnlSmtp.Controls.Add(this.edtSmtpServer);
            this.pnlSmtp.Controls.Add(this.label4);
            this.pnlSmtp.Location = new System.Drawing.Point(12, 89);
            this.pnlSmtp.Name = "pnlSmtp";
            this.pnlSmtp.Size = new System.Drawing.Size(422, 92);
            this.pnlSmtp.TabIndex = 4;
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Checked = true;
            this.cbSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSSL.Location = new System.Drawing.Point(92, 7);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(46, 17);
            this.cbSSL.TabIndex = 5;
            this.cbSSL.Text = "SSL";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // edtSmtpPw
            // 
            this.edtSmtpPw.Location = new System.Drawing.Point(324, 58);
            this.edtSmtpPw.Name = "edtSmtpPw";
            this.edtSmtpPw.PasswordChar = '*';
            this.edtSmtpPw.Size = new System.Drawing.Size(93, 20);
            this.edtSmtpPw.TabIndex = 9;
            // 
            // edtSmtpUser
            // 
            this.edtSmtpUser.Location = new System.Drawing.Point(91, 58);
            this.edtSmtpUser.Name = "edtSmtpUser";
            this.edtSmtpUser.Size = new System.Drawing.Size(151, 20);
            this.edtSmtpUser.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Benutzername";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Port";
            // 
            // edtSmtpPort
            // 
            this.edtSmtpPort.Location = new System.Drawing.Point(324, 28);
            this.edtSmtpPort.Name = "edtSmtpPort";
            this.edtSmtpPort.Size = new System.Drawing.Size(45, 20);
            this.edtSmtpPort.TabIndex = 7;
            this.edtSmtpPort.Text = "587";
            this.edtSmtpPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtTo_MouseClick);
            this.edtSmtpPort.Enter += new System.EventHandler(this.edtTo_Enter);
            // 
            // edtSmtpServer
            // 
            this.edtSmtpServer.Location = new System.Drawing.Point(91, 28);
            this.edtSmtpServer.Name = "edtSmtpServer";
            this.edtSmtpServer.Size = new System.Drawing.Size(151, 20);
            this.edtSmtpServer.TabIndex = 6;
            this.edtSmtpServer.Text = "smtpauth.bluewin.ch";
            this.edtSmtpServer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtTo_MouseClick);
            this.edtSmtpServer.Enter += new System.EventHandler(this.edtTo_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Smtp Server:";
            // 
            // edtMailContent
            // 
            this.edtMailContent.Location = new System.Drawing.Point(12, 210);
            this.edtMailContent.Multiline = true;
            this.edtMailContent.Name = "edtMailContent";
            this.edtMailContent.ReadOnly = true;
            this.edtMailContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtMailContent.Size = new System.Drawing.Size(422, 182);
            this.edtMailContent.TabIndex = 11;
            // 
            // cbEdit
            // 
            this.cbEdit.AutoSize = true;
            this.cbEdit.Location = new System.Drawing.Point(12, 187);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(116, 17);
            this.cbEdit.TabIndex = 10;
            this.cbEdit.Text = "Mail inhalt editieren";
            this.cbEdit.UseVisualStyleBackColor = true;
            this.cbEdit.CheckedChanged += new System.EventHandler(this.cbEdit_CheckedChanged);
            // 
            // frmMail
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 433);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.edtMailContent);
            this.Controls.Add(this.pnlSmtp);
            this.Controls.Add(this.edtVon);
            this.Controls.Add(this.edtSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtTo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMail";
            this.Text = "Mail Send";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.pnlSmtp.ResumeLayout(false);
            this.pnlSmtp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox edtTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSubject;
        private System.Windows.Forms.TextBox edtVon;
        private System.Windows.Forms.Panel pnlSmtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtSmtpPw;
        private System.Windows.Forms.TextBox edtSmtpUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtSmtpPort;
        private System.Windows.Forms.TextBox edtSmtpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMailContent;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.CheckBox cbEdit;
    }
}