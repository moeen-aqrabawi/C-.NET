/* RegForm.cs
 * This application enables users to register for water activites.
 * GroupBox, RadioButtons, CheckBoxes, TextBoxes, and Labels are added.
 * Several CheckedChanged( ) and Click( ) events are wired to a single method.
 */
using System;
using System.Windows.Forms;

namespace RegistrationApp
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Handles CheckChanged( ) events for CheckBox objects
        // and Click( ) events for RadioButton objects
        private void ComputeCost_CheckedChanged(object sender, EventArgs e)
        {
            decimal cost = 0;
            this.lblMsg.Text = "  ";
            if (this.ckBxSwim.Checked)
            {
                cost += 50;
            }
            if (this.ckBxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.ckBxDive.Checked)
            {
                cost += 100;
            }
            if (this.radBeginner.Checked)
            {
                cost += 10;
                this.lblMsg.Text = "Beginner -- Extra $10 charge";
            }
            else
                if (this.radAdvanc.Checked)
                {
                    cost -= 15;
                    this.lblMsg.Text = "Advanced -- Discount $15";
                }
                else
                {
                    this.lblMsg.Text = "  ";
                }
            this.txtBxResult.Text = cost.ToString("C");
        }

    }
}
