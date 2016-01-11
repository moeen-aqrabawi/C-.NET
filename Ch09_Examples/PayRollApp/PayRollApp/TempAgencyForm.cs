/* TempAgencyForm.cs
 * This partial class contains program
 * statements written to handle the two
 * button click events.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollApp
{
    public partial class TempAgencyForm : Form
    {
        public TempAgencyForm()
        {
            InitializeComponent();
        }

        // Button click event handler for the Calculate  button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int dep;
            double hours;
            string [ ] name = new string[2];
	
            while (double.TryParse(txtBxHours.Text, out hours) == false)
            {
		        MessageBox.Show("Numeric value should be entered for Hours");
                txtBxHours.Text = "0";
	            txtBxHours.Focus( );
            }

            if (int.TryParse(txtBxDep.Text, out dep) == false)
            {
                MessageBox.Show("Dependent default value of 0 used for calculations.");
                txtBxDep.Text = "0";
	            txtBxDep.Focus( );
            }

	        name = txtBxName.Text.Split(' ');
            if (hours > 0)
            {
                Employee anEmployee =
                     new Employee(name[0], name[1], dep, hours);
                txtBxGross.Text = anEmployee.DetermineGross().ToString("C");
                txtBxSoc.Text = anEmployee.DetermineSocialSecurity().ToString("C");
                txtBxFed.Text = anEmployee.DetermineFederalTax().ToString("C");
                txtBxAgency.Text = anEmployee.DetermineAgencyFee().ToString("C");
                txtBxNet.Text = anEmployee.DetermineNet().ToString("C");
                txtBxName.Enabled = false;
                txtBxHours.Visible = false;
                txtBxDep.Visible = false;
                lblHours.Visible = false;
                lblDep.Visible = false;
                setVisibility(true);
            }
        }

        // Used by both the btnCalculate and btnReset to
        // change the visibility on the objects below the buttons
        private void setVisibility(bool visibilityValue)
        {
            lblGross.Visible = visibilityValue;
            lblSoc.Visible = visibilityValue;
            lblFed.Visible = visibilityValue;
            lblAgency.Visible = visibilityValue;
            lblNet.Visible = visibilityValue;
            txtBxGross.Visible = visibilityValue;
            txtBxSoc.Visible = visibilityValue;
            txtBxFed.Visible = visibilityValue;
            txtBxAgency.Visible = visibilityValue;
            txtBxNet.Visible = visibilityValue;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxName.Clear();
            txtBxHours.Text = "0";
            txtBxDep.Text = "0";
            txtBxName.Enabled = true;
            txtBxHours.Visible = true;
            txtBxDep.Visible = true;
            lblHours.Visible = true;
            lblDep.Visible = true;
            setVisibility(false);
        }
    }
}
