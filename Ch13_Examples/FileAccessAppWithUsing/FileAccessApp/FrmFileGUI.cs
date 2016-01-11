// FileAccessApp.cs
// Windows application that retrieves
// and stores values from a text file
// to a listbox. 
using System;
using System.Windows.Forms;
using System.IO;    //Added for file access

namespace FileAccessApp
{
    public partial class FrmFileGUI : Form
    {
        private StreamReader inFile; // Declares a file stream object

        public FrmFileGUI()
        {
            InitializeComponent();
        }

        private void FrmFileGUI_Load(object sender, EventArgs e)
        {
            string inValue;
            try
            {
                using (StreamReader inFile = new StreamReader("name.txt"))
                {
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.lstBxNames.Items.Add(inValue);
                    }
                }
            }

            catch (FileNotFoundException exc)
            {
                lblMessage.Text = "File Not Found!\n" + exc.Message;
            }

            catch (Exception exc)
            {
                lblMessage.Text = exc.Message;
            }
        }
    }
}