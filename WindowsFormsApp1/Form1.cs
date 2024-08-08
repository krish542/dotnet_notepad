using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void new_menu_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!=null)
            {
                DialogResult dr =  MessageBox.Show("Do you want to save ?", "New text", MessageBoxButtons.YesNo);
                switch(dr)
                {
                    case DialogResult.Yes:
                        {
                            //MessageBox.Show("Save");
                            SaveFileDialog saveFile = new SaveFileDialog();
                            saveFile.DefaultExt = "*.txt";
                            saveFile.Filter = "TEXT Files | *.txt";

                            if(saveFile.ShowDialog()== DialogResult.OK)
                            {
                                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                                    sw.WriteLine(richTextBox1.Text);
                            }
                            richTextBox1.Clear();
                            break;
                        }
                    case DialogResult.No:
                        //MessageBox.Show("Do Not Save!");
                        richTextBox1.Clear();
                        break;

                }
            }
        }

        private void open_menu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"E:\";
            ofd.Filter = "txt files|*.txt|all files|*.*";
            ofd.FilterIndex = 1; //2 based index//default 1

            if(ofd.ShowDialog() == DialogResult.OK )
            {
                /*try
                {
                    //for rtf file
                    richTextBox1.Rtf = File.ReadAllText(ofd.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }*/
                richTextBox1.LoadFile(ofd.FileName ,RichTextBoxStreamType.PlainText);
            }
        }

        private void save_menu_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            sfd.DefaultExt = "*.txt";
            sfd.Filter = "TEXT Files|*.txt";            
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                        sw.WriteLine(richTextBox1.Text);
                }            
        }

        private void exit_menu_Click(object sender, EventArgs e)
        {           
            if(MessageBox.Show("Are you sure you want to exit program ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK )
            {
                Application.Exit();
            }
        }

        private void undo_menu_Click(object sender, EventArgs e)
        {
            if(richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void cut_menu_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copy_menu_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        private void paste_menu_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                richTextBox1.Paste();
        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.SelectedText = "";
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ( DateTime.Now.ToString()) ;
        }

        private void wordwrap_menu_Click(object sender, EventArgs e)
        {
            if(wordwrap_menu.Checked)
            {
                richTextBox1.WordWrap = true;
            }
            else
            {
                richTextBox1.WordWrap = false;
            }
        }

        private void font_menu_Click(object sender, EventArgs e)
        {
            fontDialog1.AllowScriptChange = false; //western,hebrew....
            fontDialog1.AllowSimulations = false; //bold,italic...
            fontDialog1.MinSize = 12;
            fontDialog1.MaxSize = 24;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }
        
        private void zoomin_menu_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = richTextBox1.ZoomFactor + 1f;                       
        }

        private void zoomout_menu_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = richTextBox1.ZoomFactor - 1f;            
        }

        private void defzoom_menu_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;            
        }

        private void statbar_menu_Click(object sender, EventArgs e)
        {
            if(statbar_menu.Checked )
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }
    }
}
