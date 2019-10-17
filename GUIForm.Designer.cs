namespace WindowsFormsApplication1
{
    partial class GUIForm
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
            this.NextLabel = new System.Windows.Forms.Label();
            this.ClickLabel1 = new System.Windows.Forms.Label();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.myFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BrowseLabel = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.myOpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchAndDisplay = new System.Windows.Forms.Button();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StopWatch = new System.Windows.Forms.Label();
            this.IndexPathlb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextLabel
            // 
            this.NextLabel.AutoSize = true;
            this.NextLabel.Location = new System.Drawing.Point(44, 30);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(0, 13);
            this.NextLabel.TabIndex = 4;
            this.NextLabel.Click += new System.EventHandler(this.NextLabel_Click);
            // 
            // ClickLabel1
            // 
            this.ClickLabel1.AutoSize = true;
            this.ClickLabel1.Location = new System.Drawing.Point(44, 184);
            this.ClickLabel1.Name = "ClickLabel1";
            this.ClickLabel1.Size = new System.Drawing.Size(0, 13);
            this.ClickLabel1.TabIndex = 7;
            this.ClickLabel1.Click += new System.EventHandler(this.ClickLabel_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(439, 38);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(79, 19);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(439, 90);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(79, 19);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.Location = new System.Drawing.Point(437, 60);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(87, 13);
            this.BrowseLabel.TabIndex = 10;
            this.BrowseLabel.Text = "Browse Directory";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(443, 112);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(77, 13);
            this.SaveLabel.TabIndex = 11;
            this.SaveLabel.Text = "Save Directory";
            // 
            // myOpenFileDialog1
            // 
            this.myOpenFileDialog1.FileName = "myOpenFileDialog1";
            // 
            // SearchAndDisplay
            // 
            this.SearchAndDisplay.Location = new System.Drawing.Point(247, 38);
            this.SearchAndDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchAndDisplay.Name = "SearchAndDisplay";
            this.SearchAndDisplay.Size = new System.Drawing.Size(79, 19);
            this.SearchAndDisplay.TabIndex = 15;
            this.SearchAndDisplay.Text = "Search";
            this.SearchAndDisplay.UseVisualStyleBackColor = true;
            this.SearchAndDisplay.Click += new System.EventHandler(this.Index_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(8, 38);
            this.textBoxEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(227, 20);
            this.textBoxEnter.TabIndex = 16;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 19);
            this.button1.TabIndex = 20;
            this.button1.Text = "Index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(8, 149);
            this.list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(785, 225);
            this.list.TabIndex = 22;
            this.list.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 391);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.Location = new System.Drawing.Point(8, 135);
            this.StopWatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(30, 13);
            this.StopWatch.TabIndex = 24;
            this.StopWatch.Text = "Time";
            this.StopWatch.Click += new System.EventHandler(this.StopWatch_Click);
            // 
            // IndexPathlb
            // 
            this.IndexPathlb.AutoSize = true;
            this.IndexPathlb.Location = new System.Drawing.Point(356, 60);
            this.IndexPathlb.Name = "IndexPathlb";
            this.IndexPathlb.Size = new System.Drawing.Size(55, 13);
            this.IndexPathlb.TabIndex = 25;
            this.IndexPathlb.Text = "IndexPath";
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.Controls.Add(this.IndexPathlb);
            this.Controls.Add(this.StopWatch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.SearchAndDisplay);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.BrowseLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ClickLabel1);
            this.Controls.Add(this.NextLabel);
            this.Name = "GUIForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NextLabel;
        private System.Windows.Forms.Label ClickLabel1;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog myFolderBrowserDialog;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label BrowseLabel;
        private System.Windows.Forms.Label SaveLabel;

        private System.Windows.Forms.Label[] LabelArray;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog1;
        private System.Windows.Forms.Button SearchAndDisplay;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StopWatch;
        private System.Windows.Forms.Label IndexPathlb;
    }
}

