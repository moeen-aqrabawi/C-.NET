/*  ClubForm.cs 
    This application illustrates adding
    Button, Label, Textbox and 
    ListBox objects. SelectedIndexChanged 
    and Click events are fired. 
*/
using System;
using System.Windows.Forms;

namespace ListBoxExample
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBxEvents_SelectedIndexChanged
                    (object sender, EventArgs e)
        {            
            string result = " ";
            foreach (string activity in 
                        lstBxEvents.SelectedItems)
                result += activity + "    ";
            this.txtBxResult.Text = result;
        }

        private void btnNew_Click(object sender, 
                                    EventArgs e)
        {
            lstBxEvents.Items.Add(txtBxAddNew.Text);
            txtBxAddNew.Clear();
        }
    }
}
