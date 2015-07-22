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
            this.fetchDataButton = new System.Windows.Forms.Button();
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
            this.deviationTab = new System.Windows.Forms.TabPage();
            this.deviationListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timeWindowLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stationSearchButton = new System.Windows.Forms.Button();
            this.stationSeachTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stationSeachResultListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.busTab.SuspendLayout();
            this.trainTab.SuspendLayout();
            this.tramTab.SuspendLayout();
            this.shipTab.SuspendLayout();
            this.deviationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fetchDataButton
            // 
            this.fetchDataButton.Location = new System.Drawing.Point(6, 28);
            this.fetchDataButton.Name = "fetchDataButton";
            this.fetchDataButton.Size = new System.Drawing.Size(86, 38);
            this.fetchDataButton.TabIndex = 0;
            this.fetchDataButton.Text = "Fetch data";
            this.fetchDataButton.UseVisualStyleBackColor = true;
            this.fetchDataButton.Click += new System.EventHandler(this.fetchDataButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
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
            this.metroListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroListBox.FormattingEnabled = true;
            this.metroListBox.Location = new System.Drawing.Point(3, 3);
            this.metroListBox.Name = "metroListBox";
            this.metroListBox.Size = new System.Drawing.Size(619, 319);
            this.metroListBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metroTab);
            this.tabControl1.Controls.Add(this.busTab);
            this.tabControl1.Controls.Add(this.trainTab);
            this.tabControl1.Controls.Add(this.tramTab);
            this.tabControl1.Controls.Add(this.shipTab);
            this.tabControl1.Controls.Add(this.deviationTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 351);
            this.tabControl1.TabIndex = 3;
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.metroListBox);
            this.metroTab.Location = new System.Drawing.Point(4, 22);
            this.metroTab.Name = "metroTab";
            this.metroTab.Padding = new System.Windows.Forms.Padding(3);
            this.metroTab.Size = new System.Drawing.Size(625, 325);
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
            this.busTab.Size = new System.Drawing.Size(625, 325);
            this.busTab.TabIndex = 1;
            this.busTab.Text = "buses";
            this.busTab.UseVisualStyleBackColor = true;
            // 
            // busListBox
            // 
            this.busListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.busListBox.FormattingEnabled = true;
            this.busListBox.Location = new System.Drawing.Point(3, 3);
            this.busListBox.Name = "busListBox";
            this.busListBox.Size = new System.Drawing.Size(619, 319);
            this.busListBox.TabIndex = 0;
            // 
            // trainTab
            // 
            this.trainTab.Controls.Add(this.trainListBox);
            this.trainTab.Location = new System.Drawing.Point(4, 22);
            this.trainTab.Name = "trainTab";
            this.trainTab.Padding = new System.Windows.Forms.Padding(3);
            this.trainTab.Size = new System.Drawing.Size(625, 325);
            this.trainTab.TabIndex = 2;
            this.trainTab.Text = "Trains";
            this.trainTab.UseVisualStyleBackColor = true;
            // 
            // trainListBox
            // 
            this.trainListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainListBox.FormattingEnabled = true;
            this.trainListBox.Location = new System.Drawing.Point(3, 3);
            this.trainListBox.Name = "trainListBox";
            this.trainListBox.Size = new System.Drawing.Size(619, 319);
            this.trainListBox.TabIndex = 0;
            // 
            // tramTab
            // 
            this.tramTab.Controls.Add(this.tramListBox);
            this.tramTab.Location = new System.Drawing.Point(4, 22);
            this.tramTab.Name = "tramTab";
            this.tramTab.Padding = new System.Windows.Forms.Padding(3);
            this.tramTab.Size = new System.Drawing.Size(625, 325);
            this.tramTab.TabIndex = 3;
            this.tramTab.Text = "Trams";
            this.tramTab.UseVisualStyleBackColor = true;
            // 
            // tramListBox
            // 
            this.tramListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tramListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tramListBox.FormattingEnabled = true;
            this.tramListBox.Location = new System.Drawing.Point(3, 3);
            this.tramListBox.Name = "tramListBox";
            this.tramListBox.Size = new System.Drawing.Size(619, 319);
            this.tramListBox.TabIndex = 0;
            // 
            // shipTab
            // 
            this.shipTab.Controls.Add(this.shipListBox);
            this.shipTab.Location = new System.Drawing.Point(4, 22);
            this.shipTab.Name = "shipTab";
            this.shipTab.Padding = new System.Windows.Forms.Padding(3);
            this.shipTab.Size = new System.Drawing.Size(625, 325);
            this.shipTab.TabIndex = 4;
            this.shipTab.Text = "Ships";
            this.shipTab.UseVisualStyleBackColor = true;
            // 
            // shipListBox
            // 
            this.shipListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shipListBox.FormattingEnabled = true;
            this.shipListBox.Location = new System.Drawing.Point(3, 3);
            this.shipListBox.Name = "shipListBox";
            this.shipListBox.Size = new System.Drawing.Size(619, 319);
            this.shipListBox.TabIndex = 0;
            // 
            // deviationTab
            // 
            this.deviationTab.Controls.Add(this.deviationListBox);
            this.deviationTab.Location = new System.Drawing.Point(4, 22);
            this.deviationTab.Name = "deviationTab";
            this.deviationTab.Padding = new System.Windows.Forms.Padding(3);
            this.deviationTab.Size = new System.Drawing.Size(625, 325);
            this.deviationTab.TabIndex = 5;
            this.deviationTab.Text = "deviationTab";
            this.deviationTab.UseVisualStyleBackColor = true;
            // 
            // deviationListBox
            // 
            this.deviationListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviationListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviationListBox.FormattingEnabled = true;
            this.deviationListBox.Location = new System.Drawing.Point(3, 3);
            this.deviationListBox.Name = "deviationListBox";
            this.deviationListBox.Size = new System.Drawing.Size(619, 319);
            this.deviationListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TimeWindow in minutes: ";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar1.Location = new System.Drawing.Point(101, 54);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 60;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // timeWindowLabel
            // 
            this.timeWindowLabel.AutoSize = true;
            this.timeWindowLabel.Location = new System.Drawing.Point(229, 31);
            this.timeWindowLabel.Name = "timeWindowLabel";
            this.timeWindowLabel.Size = new System.Drawing.Size(19, 13);
            this.timeWindowLabel.TabIndex = 9;
            this.timeWindowLabel.Text = "60";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(86, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // stationSearchButton
            // 
            this.stationSearchButton.Location = new System.Drawing.Point(6, 72);
            this.stationSearchButton.Name = "stationSearchButton";
            this.stationSearchButton.Size = new System.Drawing.Size(70, 23);
            this.stationSearchButton.TabIndex = 12;
            this.stationSearchButton.Text = "Seach Station";
            this.stationSearchButton.UseVisualStyleBackColor = true;
            this.stationSearchButton.Click += new System.EventHandler(this.stationSearchButton_Click);
            // 
            // stationSeachTextBox
            // 
            this.stationSeachTextBox.Location = new System.Drawing.Point(6, 46);
            this.stationSeachTextBox.Name = "stationSeachTextBox";
            this.stationSeachTextBox.Size = new System.Drawing.Size(70, 20);
            this.stationSeachTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stationSeachResultListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stationSearchButton);
            this.groupBox1.Controls.Add(this.stationSeachTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1: Search and Select station";
            // 
            // stationSeachResultListBox
            // 
            this.stationSeachResultListBox.FormattingEnabled = true;
            this.stationSeachResultListBox.Location = new System.Drawing.Point(106, 19);
            this.stationSeachResultListBox.Name = "stationSeachResultListBox";
            this.stationSeachResultListBox.Size = new System.Drawing.Size(254, 121);
            this.stationSeachResultListBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search term:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fetchDataButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.timeWindowLabel);
            this.groupBox2.Location = new System.Drawing.Point(379, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 152);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2: Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
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
            this.deviationTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button fetchDataButton;
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
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label timeWindowLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button stationSearchButton;
        private System.Windows.Forms.TextBox stationSeachTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox stationSeachResultListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage deviationTab;
        private System.Windows.Forms.ListBox deviationListBox;
    }
}

