// FrmSayingGUI.cs
// Windows application that retrieves
// and stores values from a textbox
// in a text file. 

using System;
using System.Windows.Forms;
using System.IO;             //Added for File Access

namespace SayingsApp
{
    public partial class FrmSayingsGUI : Form
    {
        private StreamWriter fil;  // Declares a file stream object

        public FrmSayingsGUI()
        {
            InitializeComponent();
        }

        // Form load event handler used to construct
        // object of the StreamWriter class, sending the
        // new file name as an argument. Enclosed in 
        // try…catch block.
        private void FrmSayingsGUI_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("saying.txt");
                //fil = new StreamWriter(@"C:\Bob\saying.txt"); // invalid path
            }

            catch (DirectoryNotFoundException exc)
            {
                lblMessage.Text = "Invalid directory:\n" + exc.Message;
            }

            catch (System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        // When the button is clicked, write the characters
        // to the text file.  
        private void btnStoreSaying_Click(object sender, EventArgs e)
        {
            try
            {
                fil.WriteLine(txtBxSaying.Text);
                txtBxSaying.Text = "";
                txtBxSaying.Focus();
            }

            catch (System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        // When the close X is clicked, as the form is
        // closing, close the file associated with the
        // StreamWriter object
        private void FrmSayingsGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch
            {
                lblMessage.Text = "File did not close properly: ";

            }

        }
    }
}
