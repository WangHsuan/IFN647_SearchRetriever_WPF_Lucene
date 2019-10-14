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
            this.SuspendLayout();
            // 
            // NextLabel
            // 
            this.NextLabel.AutoSize = true;
            this.NextLabel.Location = new System.Drawing.Point(66, 46);
            this.NextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(0, 20);
            this.NextLabel.TabIndex = 4;
            this.NextLabel.Click += new System.EventHandler(this.NextLabel_Click);
            // 
            // ClickLabel1
            // 
            this.ClickLabel1.AutoSize = true;
            this.ClickLabel1.Location = new System.Drawing.Point(66, 283);
            this.ClickLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClickLabel1.Name = "ClickLabel1";
            this.ClickLabel1.Size = new System.Drawing.Size(0, 20);
            this.ClickLabel1.TabIndex = 7;
            this.ClickLabel1.Click += new System.EventHandler(this.ClickLabel_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(659, 58);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(119, 30);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(659, 138);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 30);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.Location = new System.Drawing.Point(655, 93);
            this.BrowseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(129, 20);
            this.BrowseLabel.TabIndex = 10;
            this.BrowseLabel.Text = "Browse Directory";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(665, 173);
            this.SaveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(112, 20);
            this.SaveLabel.TabIndex = 11;
            this.SaveLabel.Text = "Save Directory";
            // 
            // myOpenFileDialog1
            // 
            this.myOpenFileDialog1.FileName = "myOpenFileDialog1";
            // 
            // SearchAndDisplay
            // 
            this.SearchAndDisplay.Location = new System.Drawing.Point(370, 58);
            this.SearchAndDisplay.Name = "SearchAndDisplay";
            this.SearchAndDisplay.Size = new System.Drawing.Size(119, 30);
            this.SearchAndDisplay.TabIndex = 15;
            this.SearchAndDisplay.Text = "Search";
            this.SearchAndDisplay.UseVisualStyleBackColor = true;
            this.SearchAndDisplay.Click += new System.EventHandler(this.Index_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(12, 58);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(338, 26);
            this.textBoxEnter.TabIndex = 16;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(12, 230);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1176, 344);
            this.list.TabIndex = 22;
            this.list.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 602);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.Location = new System.Drawing.Point(12, 207);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(43, 20);
            this.StopWatch.TabIndex = 24;
            this.StopWatch.Text = "Time";
            this.StopWatch.Click += new System.EventHandler(this.StopWatch_Click);
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 668);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

