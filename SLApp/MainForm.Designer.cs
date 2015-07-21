namespace SLApp
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.metroTab = new System.Windows.Forms.TabPage();
            this.busTab = new System.Windows.Forms.TabPage();
            this.busListBox = new System.Windows.Forms.ListBox();
            this.trainTab = new System.Windows.Forms.TabPage();
            this.trainListBox = new System.Windows.Forms.ListBox();
            this.tramTab = new System.Windows.Forms.TabPage();
            this.tramListBox = new System.Windows.Forms.ListBox();
            this.shipTab = new System.Windows.Forms.TabPage();
            this.shipListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stationIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timeWindowLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.busTab.SuspendLayout();
            this.trainTab.SuspendLayout();
            this.tramTab.SuspendLayout();
            this.shipTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fetch data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIKeysToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.settingsToolStripMenuItem.Text = "File";
            // 
            // aPIKeysToolStripMenuItem
            // 
            this.aPIKeysToolStripMenuItem.Name = "aPIKeysToolStripMenuItem";
            this.aPIKeysToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aPIKeysToolStripMenuItem.Text = "API-Keys";
            this.aPIKeysToolStripMenuItem.Click += new System.EventHandler(this.aPIKeysToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metroListBox
            // 
            this.metroListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListBox.FormattingEnabled = true;
            this.metroListBox.Location = new System.Drawing.Point(3, 3);
            this.metroListBox.Name = "metroListBox";
            this.metroListBox.Size = new System.Drawing.Size(704, 319);
            this.metroListBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metroTab);
            this.tabControl1.Controls.Add(this.busTab);
            this.tabControl1.Controls.Add(this.trainTab);
            this.tabControl1.Controls.Add(this.tramTab);
            this.tabControl1.Controls.Add(this.shipTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 351);
            this.tabControl1.TabIndex = 3;
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.metroListBox);
            this.metroTab.Location = new System.Drawing.Point(4, 22);
            this.metroTab.Name = "metroTab";
            this.metroTab.Padding = new System.Windows.Forms.Padding(3);
            this.metroTab.Size = new System.Drawing.Size(710, 325);
            this.metroTab.TabIndex = 0;
            this.metroTab.Text = "metro";
            this.metroTab.UseVisualStyleBackColor = true;
            // 
            // busTab
            // 
            this.busTab.Controls.Add(this.busListBox);
            this.busTab.Location = new System.Drawing.Point(4, 22);
            this.busTab.Name = "busTab";
            this.busTab.Padding = new System.Windows.Forms.Padding(3);
            this.busTab.Size = new System.Drawing.Size(710, 325);
            this.busTab.TabIndex = 1;
            this.busTab.Text = "buses";
            this.busTab.UseVisualStyleBackColor = true;
            // 
            // busListBox
            // 
            this.busListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busListBox.FormattingEnabled = true;
            this.busListBox.Location = new System.Drawing.Point(3, 3);
            this.busListBox.Name = "busListBox";
            this.busListBox.Size = new System.Drawing.Size(704, 319);
            this.busListBox.TabIndex = 0;
            // 
            // trainTab
            // 
            this.trainTab.Controls.Add(this.trainListBox);
            this.trainTab.Location = new System.Drawing.Point(4, 22);
            this.trainTab.Name = "trainTab";
            this.trainTab.Padding = new System.Windows.Forms.Padding(3);
            this.trainTab.Size = new System.Drawing.Size(710, 325);
            this.trainTab.TabIndex = 2;
            this.trainTab.Text = "Trains";
            this.trainTab.UseVisualStyleBackColor = true;
            // 
            // trainListBox
            // 
            this.trainListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainListBox.FormattingEnabled = true;
            this.trainListBox.Location = new System.Drawing.Point(3, 3);
            this.trainListBox.Name = "trainListBox";
            this.trainListBox.Size = new System.Drawing.Size(704, 319);
            this.trainListBox.TabIndex = 0;
            // 
            // tramTab
            // 
            this.tramTab.Controls.Add(this.tramListBox);
            this.tramTab.Location = new System.Drawing.Point(4, 22);
            this.tramTab.Name = "tramTab";
            this.tramTab.Padding = new System.Windows.Forms.Padding(3);
            this.tramTab.Size = new System.Drawing.Size(710, 325);
            this.tramTab.TabIndex = 3;
            this.tramTab.Text = "Trams";
            this.tramTab.UseVisualStyleBackColor = true;
            // 
            // tramListBox
            // 
            this.tramListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tramListBox.FormattingEnabled = true;
            this.tramListBox.Location = new System.Drawing.Point(3, 3);
            this.tramListBox.Name = "tramListBox";
            this.tramListBox.Size = new System.Drawing.Size(704, 319);
            this.tramListBox.TabIndex = 0;
            // 
            // shipTab
            // 
            this.shipTab.Controls.Add(this.shipListBox);
            this.shipTab.Location = new System.Drawing.Point(4, 22);
            this.shipTab.Name = "shipTab";
            this.shipTab.Padding = new System.Windows.Forms.Padding(3);
            this.shipTab.Size = new System.Drawing.Size(710, 325);
            this.shipTab.TabIndex = 4;
            this.shipTab.Text = "Ships";
            this.shipTab.UseVisualStyleBackColor = true;
            // 
            // shipListBox
            // 
            this.shipListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipListBox.FormattingEnabled = true;
            this.shipListBox.Location = new System.Drawing.Point(3, 3);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(704, 319);
            this.shipListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TimeWindow in minutes: ";
            // 
            // stationIdTextBox
            // 
            this.stationIdTextBox.Location = new System.Drawing.Point(12, 409);
            this.stationIdTextBox.Name = "stationIdTextBox";
            this.stationIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.stationIdTextBox.TabIndex = 6;
            this.stationIdTextBox.Text = "9001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "StationID:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(266, 416);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 60;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // timeWindowLabel
            // 
            this.timeWindowLabel.AutoSize = true;
            this.timeWindowLabel.Location = new System.Drawing.Point(381, 393);
            this.timeWindowLabel.Name = "timeWindowLabel";
            this.timeWindowLabel.Size = new System.Drawing.Size(19, 13);
            this.timeWindowLabel.TabIndex = 9;
            this.timeWindowLabel.Text = "60";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(139, 442);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(86, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 477);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.timeWindowLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stationIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.metroTab.ResumeLayout(false);
            this.busTab.ResumeLayout(false);
            this.trainTab.ResumeLayout(false);
            this.tramTab.ResumeLayout(false);
            this.shipTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox metroListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage metroTab;
        private System.Windows.Forms.TabPage busTab;
        private System.Windows.Forms.TabPage trainTab;
        private System.Windows.Forms.TabPage tramTab;
        private System.Windows.Forms.TabPage shipTab;
        private System.Windows.Forms.ListBox busListBox;
        private System.Windows.Forms.ListBox trainListBox;
        private System.Windows.Forms.ListBox tramListBox;
        private System.Windows.Forms.ListBox shipListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stationIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label timeWindowLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

