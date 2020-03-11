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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pageControl1 = new System.Windows.Forms.TabControl();
            this.tabVerbindung = new System.Windows.Forms.TabPage();
            this.lbVerbindungStart = new System.Windows.Forms.ListBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.tabZiel = new System.Windows.Forms.TabPage();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbZiel = new System.Windows.Forms.ComboBox();
            this.timerCombo = new System.Windows.Forms.Timer(this.components);
            this.lbBoardStart = new System.Windows.Forms.ListBox();
            this.lbBoardZiel = new System.Windows.Forms.ListBox();
            this.formMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnlZeit.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.pageControl1.SuspendLayout();
            this.tabVerbindung.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.tabZiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(673, 449);
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
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
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
            this.pnlZeit.TabIndex = 8;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.rbTimeEnd);
            this.gbTime.Controls.Add(this.rbTimeStart);
            this.gbTime.Controls.Add(this.rbTimeOFF);
            this.gbTime.Location = new System.Drawing.Point(3, 3);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(197, 45);
            this.gbTime.TabIndex = 10;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Datum / Zeit";
            // 
            // rbTimeEnd
            // 
            this.rbTimeEnd.AutoSize = true;
            this.rbTimeEnd.Location = new System.Drawing.Point(133, 20);
            this.rbTimeEnd.Name = "rbTimeEnd";
            this.rbTimeEnd.Size = new System.Drawing.Size(62, 17);
            this.rbTimeEnd.TabIndex = 2;
            this.rbTimeEnd.Text = "Ankunft";
            this.rbTimeEnd.UseVisualStyleBackColor = true;
            // 
            // rbTimeStart
            // 
            this.rbTimeStart.AutoSize = true;
            this.rbTimeStart.Location = new System.Drawing.Point(68, 20);
            this.rbTimeStart.Name = "rbTimeStart";
            this.rbTimeStart.Size = new System.Drawing.Size(59, 17);
            this.rbTimeStart.TabIndex = 1;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(23, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pageControl1
            // 
            this.pageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageControl1.Controls.Add(this.tabVerbindung);
            this.pageControl1.Controls.Add(this.tabStart);
            this.pageControl1.Controls.Add(this.tabZiel);
            this.pageControl1.Location = new System.Drawing.Point(16, 116);
            this.pageControl1.Name = "pageControl1";
            this.pageControl1.SelectedIndex = 0;
            this.pageControl1.Size = new System.Drawing.Size(738, 322);
            this.pageControl1.TabIndex = 10;
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
            this.tabStart.Controls.Add(this.lbBoardStart);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(730, 296);
            this.tabStart.TabIndex = 1;
            this.tabStart.Text = "Abfahrtstafel Start";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // tabZiel
            // 
            this.tabZiel.Controls.Add(this.lbBoardZiel);
            this.tabZiel.Location = new System.Drawing.Point(4, 22);
            this.tabZiel.Name = "tabZiel";
            this.tabZiel.Padding = new System.Windows.Forms.Padding(3);
            this.tabZiel.Size = new System.Drawing.Size(730, 296);
            this.tabZiel.TabIndex = 2;
            this.tabZiel.Text = "Abfahrtstafel Ziel";
            this.tabZiel.UseVisualStyleBackColor = true;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Location = new System.Drawing.Point(43, 42);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(173, 21);
            this.cbStart.TabIndex = 11;
            this.cbStart.TextChanged += new System.EventHandler(this.cbStart_TextChanged);
            // 
            // cbZiel
            // 
            this.cbZiel.FormattingEnabled = true;
            this.cbZiel.Location = new System.Drawing.Point(43, 76);
            this.cbZiel.Name = "cbZiel";
            this.cbZiel.Size = new System.Drawing.Size(173, 21);
            this.cbZiel.TabIndex = 12;
            this.cbZiel.TextChanged += new System.EventHandler(this.cbStart_TextChanged);
            // 
            // timerCombo
            // 
            this.timerCombo.Interval = 1000;
            this.timerCombo.Tick += new System.EventHandler(this.timerCombo_Tick);
            // 
            // lbBoardStart
            // 
            this.lbBoardStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBoardStart.FormattingEnabled = true;
            this.lbBoardStart.Location = new System.Drawing.Point(3, 3);
            this.lbBoardStart.Name = "lbBoardStart";
            this.lbBoardStart.Size = new System.Drawing.Size(724, 290);
            this.lbBoardStart.TabIndex = 1;
            // 
            // lbBoardZiel
            // 
            this.lbBoardZiel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBoardZiel.FormattingEnabled = true;
            this.lbBoardZiel.Location = new System.Drawing.Point(3, 3);
            this.lbBoardZiel.Name = "lbBoardZiel";
            this.lbBoardZiel.Size = new System.Drawing.Size(724, 290);
            this.lbBoardZiel.TabIndex = 1;
            // 
            // formMainBindingSource
            // 
            this.formMainBindingSource.DataSource = typeof(SBBStationFinder.formMain);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 484);
            this.Controls.Add(this.cbZiel);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.pageControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlZeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "SBB Station Finder";
            this.Activated += new System.EventHandler(this.formMain_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlZeit.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.pageControl1.ResumeLayout(false);
            this.tabVerbindung.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabZiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formMainBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl pageControl1;
        private System.Windows.Forms.TabPage tabVerbindung;
        private System.Windows.Forms.ListBox lbVerbindungStart;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbZiel;
        private System.Windows.Forms.Timer timerCombo;
        private System.Windows.Forms.TabPage tabZiel;
        private System.Windows.Forms.BindingSource formMainBindingSource;
        private System.Windows.Forms.ListBox lbBoardStart;
        private System.Windows.Forms.ListBox lbBoardZiel;
    }
}

