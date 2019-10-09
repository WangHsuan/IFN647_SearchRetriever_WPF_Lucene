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
            this.Index = new System.Windows.Forms.Button();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextEnter = new System.Windows.Forms.TextBox();
            this.TextButton = new System.Windows.Forms.Button();
            this.TextShowEnter = new System.Windows.Forms.Label();
            this.TextShowChange = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.BrowseButton.Location = new System.Drawing.Point(659, 55);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(116, 33);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(659, 109);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 35);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BrowseLabel
            // 
            this.BrowseLabel.AutoSize = true;
            this.BrowseLabel.Location = new System.Drawing.Point(799, 58);
            this.BrowseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrowseLabel.Name = "BrowseLabel";
            this.BrowseLabel.Size = new System.Drawing.Size(129, 20);
            this.BrowseLabel.TabIndex = 10;
            this.BrowseLabel.Text = "Browse Directory";
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(799, 116);
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
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(370, 54);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(119, 34);
            this.Index.TabIndex = 15;
            this.Index.Text = "Search";
            this.Index.UseVisualStyleBackColor = true;
            this.Index.Click += new System.EventHandler(this.Index_Click);
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(12, 58);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(338, 26);
            this.textBoxEnter.TabIndex = 16;
            this.textBoxEnter.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Result List";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Index";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TextEnter
            // 
            this.TextEnter.Location = new System.Drawing.Point(13, 628);
            this.TextEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextEnter.Name = "TextEnter";
            this.TextEnter.Size = new System.Drawing.Size(412, 26);
            this.TextEnter.TabIndex = 1;
            this.TextEnter.TextChanged += new System.EventHandler(this.TextEnter_TextChanged);
            // 
            // TextButton
            // 
            this.TextButton.Location = new System.Drawing.Point(12, 535);
            this.TextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(108, 34);
            this.TextButton.TabIndex = 5;
            this.TextButton.Text = "Enter";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // TextShowEnter
            // 
            this.TextShowEnter.AutoSize = true;
            this.TextShowEnter.Location = new System.Drawing.Point(16, 574);
            this.TextShowEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextShowEnter.Name = "TextShowEnter";
            this.TextShowEnter.Size = new System.Drawing.Size(142, 20);
            this.TextShowEnter.TabIndex = 6;
            this.TextShowEnter.Text = "Show text on enter";
            this.TextShowEnter.Click += new System.EventHandler(this.TextShow_Click);
            // 
            // TextShowChange
            // 
            this.TextShowChange.AutoSize = true;
            this.TextShowChange.Location = new System.Drawing.Point(8, 603);
            this.TextShowChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextShowChange.Name = "TextShowChange";
            this.TextShowChange.Size = new System.Drawing.Size(158, 20);
            this.TextShowChange.TabIndex = 12;
            this.TextShowChange.Text = "Show text on change";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1176, 324);
            this.listBox1.TabIndex = 22;
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 668);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnter);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.TextShowChange);
            this.Controls.Add(this.SaveLabel);
            this.Controls.Add(this.BrowseLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ClickLabel1);
            this.Controls.Add(this.TextShowEnter);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.NextLabel);
            this.Controls.Add(this.TextEnter);
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
        private System.Windows.Forms.Button Index;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextEnter;
        private System.Windows.Forms.Button TextButton;
        private System.Windows.Forms.Label TextShowEnter;
        private System.Windows.Forms.Label TextShowChange;
        private System.Windows.Forms.ListBox listBox1;
    }
}

