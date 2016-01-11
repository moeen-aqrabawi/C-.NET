// GardeningForm.cs         Author: Doyle
// Menu, ListBox, ComboBox, Label, and TextBox
// objects are included in the design. KeyPress( ),
// Click( ), and SelectedIndexChanged( ) events
// are programmed. Font and Color dialog boxes
// are added. using System.Collections.Generic;

using System.Windows.Forms;

namespace GardeningForm
{
    public partial class GardeningForm : Form
    {
        public GardeningForm()
        {
            InitializeComponent();
        }

        private void cmboFlowers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.txtBxResultFlowers.Text = this.cmboFlowers.Text;
        }

        private void cmboFlowers_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtBxResultFlowers.Text = cmboFlowers.Text;
        }

        private void lstBxTrees_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.txtBxResultTrees.Text = " ";
            foreach (int i in lstBxTrees.SelectedIndices)
            {
                this.txtBxResultTrees.Text += this.lstBxTrees.Items[i] + "   ";
            }
        }

        private void menuExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Gardening Guide Application\n\n\nVersion 1.0",
                                        "About Gardening");
        }

        private void menuFont_Click(object sender, System.EventArgs e)
        {
            fontDialog1.Font = lblOutput.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.Font = fontDialog1.Font;
            }
        }

        private void menuColor_Click(object sender, System.EventArgs e)
        {
            colorDialog1.Color = lblOutput.ForeColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.ForeColor = colorDialog1.Color;
            }
        }
 
    }
}
