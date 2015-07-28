namespace SLApp
{
    partial class APIKeyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.realTimeKeyTextBox = new System.Windows.Forms.TextBox();
            this.stationKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StationKey";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectFileButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.realTimeKeyTextBox);
            this.groupBox1.Controls.Add(this.stationKeyTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parsed Keys";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(178, 192);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // realTimeKeyTextBox
            // 
            this.realTimeKeyTextBox.Location = new System.Drawing.Point(6, 122);
            this.realTimeKeyTextBox.Name = "realTimeKeyTextBox";
            this.realTimeKeyTextBox.Size = new System.Drawing.Size(242, 20);
            this.realTimeKeyTextBox.TabIndex = 3;
            // 
            // stationKeyTextBox
            // 
            this.stationKeyTextBox.Location = new System.Drawing.Point(6, 51);
            this.stationKeyTextBox.Name = "stationKeyTextBox";
            this.stationKeyTextBox.Size = new System.Drawing.Size(242, 20);
            this.stationKeyTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RealtimeKey";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(6, 192);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 5;
            this.selectFileButton.Text = "Select File...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // APIKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "APIKeyForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APIKeyForm";
            this.Shown += new System.EventHandler(this.APIKeyForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox realTimeKeyTextBox;
        private System.Windows.Forms.TextBox stationKeyTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}