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
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alsMailVersendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlZeit = new System.Windows.Forms.Panel();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.rbTimeEnd = new System.Windows.Forms.RadioButton();
            this.rbTimeStart = new System.Windows.Forms.RadioButton();
            this.rbTimeOFF = new System.Windows.Forms.RadioButton();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.btnSuche = new System.Windows.Forms.Button();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.tabVerbindung = new System.Windows.Forms.TabPage();
            this.lbVerbindungStart = new System.Windows.Forms.ListBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMapStart = new System.Windows.Forms.Button();
            this.lbBoardStart = new System.Windows.Forms.ListBox();
            this.tabZiel = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMapZiel = new System.Windows.Forms.Button();
            this.lbBoardZiel = new System.Windows.Forms.ListBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbZiel = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.pnlZeit.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.pageControl.SuspendLayout();
            this.tabVerbindung.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabZiel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(673, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrasToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alsMailVersendenToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // alsMailVersendenToolStripMenuItem
            // 
            this.alsMailVersendenToolStripMenuItem.Name = "alsMailVersendenToolStripMenuItem";
            this.alsMailVersendenToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.alsMailVersendenToolStripMenuItem.Text = "als Mail Versenden";
            this.alsMailVersendenToolStripMenuItem.Click += new System.EventHandler(this.alsMailVersendenToolStripMenuItem_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ziel";
            // 
            // pnlZeit
            // 
            this.pnlZeit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZeit.Controls.Add(this.gbTime);
            this.pnlZeit.Controls.Add(this.dtpArrivalTime);
            this.pnlZeit.Controls.Add(this.dtpArrivalDate);
            this.pnlZeit.Location = new System.Drawing.Point(232, 27);
            this.pnlZeit.Name = "pnlZeit";
            this.pnlZeit.Size = new System.Drawing.Size(210, 83);
            this.pnlZeit.TabIndex = 3;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.rbTimeEnd);
            this.gbTime.Controls.Add(this.rbTimeStart);
            this.gbTime.Controls.Add(this.rbTimeOFF);
            this.gbTime.Location = new System.Drawing.Point(3, 3);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(197, 45);
            this.gbTime.TabIndex = 4;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Datum / Zeit";
            // 
            // rbTimeEnd
            // 
            this.rbTimeEnd.AutoSize = true;
            this.rbTimeEnd.Location = new System.Drawing.Point(133, 20);
            this.rbTimeEnd.Name = "rbTimeEnd";
            this.rbTimeEnd.Size = new System.Drawing.Size(62, 17);
            this.rbTimeEnd.TabIndex = 7;
            this.rbTimeEnd.Text = "Ankunft";
            this.rbTimeEnd.UseVisualStyleBackColor = true;
            // 
            // rbTimeStart
            // 
            this.rbTimeStart.AutoSize = true;
            this.rbTimeStart.Location = new System.Drawing.Point(68, 20);
            this.rbTimeStart.Name = "rbTimeStart";
            this.rbTimeStart.Size = new System.Drawing.Size(59, 17);
            this.rbTimeStart.TabIndex = 6;
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
            this.rbTimeOFF.TabIndex = 5;
            this.rbTimeOFF.TabStop = true;
            this.rbTimeOFF.Text = "Aus";
            this.rbTimeOFF.UseVisualStyleBackColor = true;
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(114, 54);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.ShowUpDown = true;
            this.dtpArrivalTime.Size = new System.Drawing.Size(56, 20);
            this.dtpArrivalTime.TabIndex = 9;
            // 
            // dtpArrivalDate
            // 
            this.dtpArrivalDate.CustomFormat = "dd:MM:yyyy";
            this.dtpArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalDate.Location = new System.Drawing.Point(10, 54);
            this.dtpArrivalDate.Name = "dtpArrivalDate";
            this.dtpArrivalDate.Size = new System.Drawing.Size(92, 20);
            this.dtpArrivalDate.TabIndex = 8;
            // 
            // btnSuche
            // 
            this.btnSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuche.Location = new System.Drawing.Point(23, 449);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(75, 23);
            this.btnSuche.TabIndex = 10;
            this.btnSuche.Text = "Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // pageControl
            // 
            this.pageControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl.Controls.Add(this.tabVerbindung);
            this.pageControl.Controls.Add(this.tabStart);
            this.pageControl.Controls.Add(this.tabZiel);
            this.pageControl.Location = new System.Drawing.Point(16, 116);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(738, 322);
            this.pageControl.TabIndex = 11;
            // 
            // tabVerbindung
            // 
            this.tabVerbindung.Controls.Add(this.lbVerbindungStart);
            this.tabVerbindung.Location = new System.Drawing.Point(4, 22);
            this.tabVerbindung.Name = "tabVerbindung";
            this.tabVerbindung.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbindung.Size = new System.Drawing.Size(730, 296);
            this.tabVerbindung.TabIndex = 0;
            this.tabVerbindung.Text = "Verbindung";
            this.tabVerbindung.UseVisualStyleBackColor = true;
            // 
            // lbVerbindungStart
            // 
            this.lbVerbindungStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbVerbindungStart.FormattingEnabled = true;
            this.lbVerbindungStart.Location = new System.Drawing.Point(3, 3);
            this.lbVerbindungStart.Name = "lbVerbindungStart";
            this.lbVerbindungStart.Size = new System.Drawing.Size(724, 290);
            this.lbVerbindungStart.TabIndex = 0;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.panel2);
            this.tabStart.Controls.Add(this.lbBoardStart);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(730, 296);
            this.tabStart.TabIndex = 1;
            this.tabStart.Text = "Abfahrtstafel Start";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMapStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 30);
            this.panel2.TabIndex = 3;
            // 
            // btnMapStart
            // 
            this.btnMapStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMapStart.Location = new System.Drawing.Point(3, 4);
            this.btnMapStart.Name = "btnMapStart";
            this.btnMapStart.Size = new System.Drawing.Size(75, 23);
            this.btnMapStart.TabIndex = 11;
            this.btnMapStart.Text = "Map";
            this.btnMapStart.UseVisualStyleBackColor = true;
            this.btnMapStart.Click += new System.EventHandler(this.btnMapStart_Click);
            // 
            // lbBoardStart
            // 
            this.lbBoardStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoardStart.FormattingEnabled = true;
            this.lbBoardStart.Location = new System.Drawing.Point(3, 3);
            this.lbBoardStart.Name = "lbBoardStart";
            this.lbBoardStart.Size = new System.Drawing.Size(724, 251);
            this.lbBoardStart.TabIndex = 1;
            // 
            // tabZiel
            // 
            this.tabZiel.Controls.Add(this.panel1);
            this.tabZiel.Controls.Add(this.lbBoardZiel);
            this.tabZiel.Location = new System.Drawing.Point(4, 22);
            this.tabZiel.Name = "tabZiel";
            this.tabZiel.Padding = new System.Windows.Forms.Padding(3);
            this.tabZiel.Size = new System.Drawing.Size(730, 296);
            this.tabZiel.TabIndex = 2;
            this.tabZiel.Text = "Abfahrtstafel Ziel";
            this.tabZiel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMapZiel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 30);
            this.panel1.TabIndex = 2;
            // 
            // btnMapZiel
            // 
            this.btnMapZiel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMapZiel.Location = new System.Drawing.Point(3, 4);
            this.btnMapZiel.Name = "btnMapZiel";
            this.btnMapZiel.Size = new System.Drawing.Size(75, 23);
            this.btnMapZiel.TabIndex = 11;
            this.btnMapZiel.Text = "Map";
            this.btnMapZiel.UseVisualStyleBackColor = true;
            this.btnMapZiel.Click += new System.EventHandler(this.btnMapZiel_Click);
            // 
            // lbBoardZiel
            // 
            this.lbBoardZiel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBoardZiel.FormattingEnabled = true;
            this.lbBoardZiel.Location = new System.Drawing.Point(3, 3);
            this.lbBoardZiel.Name = "lbBoardZiel";
            this.lbBoardZiel.Size = new System.Drawing.Size(724, 251);
            this.lbBoardZiel.TabIndex = 1;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(43, 42);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(173, 21);
            this.cbStart.TabIndex = 1;
            this.cbStart.TextChanged += new System.EventHandler(this.cbStart_TextChanged);
            // 
            // cbZiel
            // 
            this.cbZiel.FormattingEnabled = true;
            this.cbZiel.Location = new System.Drawing.Point(43, 76);
            this.cbZiel.Name = "cbZiel";
            this.cbZiel.Size = new System.Drawing.Size(173, 21);
            this.cbZiel.TabIndex = 2;
            this.cbZiel.TextChanged += new System.EventHandler(this.cbStart_TextChanged);
            // 
            // formMain
            // 
            this.AcceptButton = this.btnSuche;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 484);
            this.Controls.Add(this.cbZiel);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.pageControl);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.pnlZeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "SBB Station Finder";
            this.Activated += new System.EventHandler(this.formMain_Activated);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlZeit.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.pageControl.ResumeLayout(false);
            this.tabVerbindung.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabZiel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlZeit;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalDate;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.RadioButton rbTimeEnd;
        private System.Windows.Forms.RadioButton rbTimeStart;
        private System.Windows.Forms.RadioButton rbTimeOFF;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.TabControl pageControl;
        private System.Windows.Forms.TabPage tabVerbindung;
        private System.Windows.Forms.ListBox lbVerbindungStart;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbZiel;
        private System.Windows.Forms.TabPage tabZiel;
        private System.Windows.Forms.ListBox lbBoardStart;
        private System.Windows.Forms.ListBox lbBoardZiel;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alsMailVersendenToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMapStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMapZiel;
    }
}

