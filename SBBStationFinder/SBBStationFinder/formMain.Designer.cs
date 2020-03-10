namespace SBBStationFinder
{
    partial class formMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.edtStationStart = new System.Windows.Forms.TextBox();
            this.edtStationZiel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.rbTimeEnd = new System.Windows.Forms.RadioButton();
            this.rbTimeStart = new System.Windows.Forms.RadioButton();
            this.rbTimeOFF = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(713, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start";
            // 
            // edtStationStart
            // 
            this.edtStationStart.Location = new System.Drawing.Point(43, 41);
            this.edtStationStart.Name = "edtStationStart";
            this.edtStationStart.Size = new System.Drawing.Size(173, 20);
            this.edtStationStart.TabIndex = 3;
            // 
            // edtStationZiel
            // 
            this.edtStationZiel.Location = new System.Drawing.Point(43, 76);
            this.edtStationZiel.Name = "edtStationZiel";
            this.edtStationZiel.Size = new System.Drawing.Size(173, 20);
            this.edtStationZiel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ziel";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbTime);
            this.panel1.Controls.Add(this.dtpArrivalTime);
            this.panel1.Controls.Add(this.dtpArrivalDate);
            this.panel1.Location = new System.Drawing.Point(16, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 105);
            this.panel1.TabIndex = 8;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(218, 9);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(56, 20);
            this.dtpArrivalTime.TabIndex = 9;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CustomFormat = "dd:MM:yyyy";
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(110, 9);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(92, 20);
            this.dtpArrivalDate.TabIndex = 8;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.rbTimeEnd);
            this.gbTime.Controls.Add(this.rbTimeStart);
            this.gbTime.Controls.Add(this.rbTimeOFF);
            this.gbTime.Location = new System.Drawing.Point(3, 3);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(101, 94);
            this.gbTime.TabIndex = 10;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Datum / Zeit";
            // 
            // rbTimeEnd
            // 
            this.rbTimeEnd.AutoSize = true;
            this.rbTimeEnd.Location = new System.Drawing.Point(6, 66);
            this.rbTimeEnd.Name = "rbTimeEnd";
            this.rbTimeEnd.Size = new System.Drawing.Size(62, 17);
            this.rbTimeEnd.TabIndex = 2;
            this.rbTimeEnd.TabStop = true;
            this.rbTimeEnd.Text = "Ankunft";
            this.rbTimeEnd.UseVisualStyleBackColor = true;
            // 
            // rbTimeStart
            // 
            this.rbTimeStart.AutoSize = true;
            this.rbTimeStart.Location = new System.Drawing.Point(7, 43);
            this.rbTimeStart.Name = "rbTimeStart";
            this.rbTimeStart.Size = new System.Drawing.Size(59, 17);
            this.rbTimeStart.TabIndex = 1;
            this.rbTimeStart.TabStop = true;
            this.rbTimeStart.Text = "Abfahrt";
            this.rbTimeStart.UseVisualStyleBackColor = true;
            // 
            // rbTimeOFF
            // 
            this.rbTimeOFF.AutoSize = true;
            this.rbTimeOFF.Checked = true;
            this.rbTimeOFF.Location = new System.Drawing.Point(7, 20);
            this.rbTimeOFF.Name = "rbTimeOFF";
            this.rbTimeOFF.Size = new System.Drawing.Size(43, 17);
            this.rbTimeOFF.TabIndex = 0;
            this.rbTimeOFF.TabStop = true;
            this.rbTimeOFF.Text = "Aus";
            this.rbTimeOFF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(16, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 279);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 219);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(739, 173);
            this.listBox1.TabIndex = 0;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edtStationZiel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtStationStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "SBB Station Finder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtStationStart;
        private System.Windows.Forms.TextBox edtStationZiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.RadioButton rbTimeEnd;
        private System.Windows.Forms.RadioButton rbTimeStart;
        private System.Windows.Forms.RadioButton rbTimeOFF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

