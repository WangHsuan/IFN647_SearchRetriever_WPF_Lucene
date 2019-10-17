using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GUIForm : Form
    {
        Poem p;
        LuceneInteractive index;
        public GUIForm()
        {
            InitializeComponent();
            p = new Poem();
            index = new LuceneInteractive();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string text = p.getNextLine();
           // this.NextLabel.Text =text;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            //string path = BrowseLabel.Text;
            //TextShowEnter.Text = index.collectString(path);
        }

        private void TextEnter_TextChanged(object sender, EventArgs e)
        {
           // TextShowChange.Text = TextEnter.Text;
        }

        private void TextShow_Click(object sender, EventArgs e)
        {

        }

        private void ClickLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You Clicked One!");
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            index.CollectionPath = openFileDialog1.FileName;
            BrowseLabel.Text = openFileDialog1.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            mySaveFileDialog.ShowDialog();
            SaveLabel.Text = mySaveFileDialog.FileName;
        }

        private void ClickLabel2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You Clicked Two!");

        }

        private void ClickLabel3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("You Clicked Three!");

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextLabel_Click(object sender, EventArgs e)
        {

        }

        private void Index_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            string query = textBoxEnter.Text;
            string indexPath = IndexPathlb.Text;

            index.CreateSearcher(indexPath);
            
            for (int i = 0; i < index.SearchAndDisplayResults(query).Count(); i++)
            {
                list.Items.Add(index.SearchAndDisplayResults(query)[i]);
            }
          
            index.CleanUpSearcher();


        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] analyzers = { "Simple", "Standard", "Snaowball" };
            
            comboBox1.Items.AddRange(analyzers);
            
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string defaultIndexPath = @"../Dataset";
            using (var dlg = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dlg.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    defaultIndexPath = dlg.SelectedPath;
                    index.activateIndex(defaultIndexPath);
                    StopWatch.Text = index.IndexingTime;
                }
                //string path = BrowseLabel.Text;
                // var resultList = index.activateIndex(query, path);
            }
            IndexPathlb.Text = defaultIndexPath;
        }

        private void StopWatch_Click(object sender, EventArgs e)
        {

        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
