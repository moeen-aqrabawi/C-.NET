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

        // Form load event handler used to construct
        // object of the StreamReader class, sending the
        // new file name as an argument. Enclosed in
        // try...catch block.
        private void FrmFileGUI_Load(object sender, EventArgs e)
        {
            string inValue;
             
            if (File.Exists("name.txt"))
            {
                try
                {  
                    inFile = new StreamReader("name.txt");

                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.lstBxNames.Items.Add(inValue);
                    }
                }      
              
                catch (System.IO.IOException exc)
                {
                    lblMessage.Text = exc.Message;
                }
            }

            else
            {
                lblMessage.Text = "File unavailable";
            }
        }

        // When the close X is clicked, as the form is
        // closing, close the file associated with the
        // StreamReader object
        private void FrmFileGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }
            catch
            {
            }
        }
    }
}