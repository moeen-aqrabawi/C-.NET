// FileAccessAppDialogs.cs
// Illustrates using file dialogs for 
// retrieving and saving files.
using System;
using System.Windows.Forms;
using System.IO;    // Added for file access

namespace FileAccessAppDialogs
{
    public partial class FrmFileDialogs : Form
    {
        StreamReader inFile;
        StreamWriter outFile;

        public FrmFileDialogs()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click
                            (object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inFile = new 
                    StreamReader(openFileDialog1.FileName);
                lblMessage.Text = "File " + 
                    openFileDialog1.FileName;
                inFile.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void saveAsToolStripMenuItem_Click
                            (object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                string testValue = 
                    "This is an example using Dialog boxes";
                outFile = new 
                    StreamWriter(saveFileDialog1.FileName);
                outFile.WriteLine(testValue);
                outFile.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void exitToolStripMenuItem_Click
                            (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
