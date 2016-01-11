// PresentationGUI.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClubNamespace;           // Namespace for Club class
using IntramuralNamespace;     // Namespace for Intramural class
using FratSororityNamespace;   // Namespace for FratSorority class

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        // Object of Club class declared
        private Club aClub;                                   
        // Object of Intramural class declared
        private Intramural aTeam;                             
        // Object of FratSorority class declared
        private FratSorority aFratSorority;                   

        public PresentationGUI()
        {
            InitializeComponent();
        }

        // Objects are instantiated when the form is loaded.
        // Another GUI could be designed for entering data.
        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            aClub = new Club
                ("ACM", "Jones", "Davis 203",
                  "Tues", "12:30");
            aFratSorority = new FratSorority
                ("Delta PI", "Brenda Wynn",
                  true, "86 SmithField");
            aTeam = new Intramural
                ("Winners", "Joe Kitchen", "VolleyBall");
        }


        // Three CheckedChanged event handler methods included
        // Double clicking on the RadioButton adds the method
        // heading and registers the event.
        private void radBtnClub_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aClub.OrgName;
            aClub.SetFundingAmt();
            txtBxFund.Text = aClub.FundedAmt.ToString("C");
            ShowDetails();
        }

        private void radBtnFratSor_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aFratSorority.OrgName;
            aFratSorority.SetFundingAmt();
            txtBxFund.Text =
                aFratSorority.FundedAmt.ToString("C");
            ShowDetails();
        }

        private void radBtnIntr_CheckedChanged(object sender, EventArgs e)
        {
            txtBxName.Text = aTeam.OrgName;
            txtBxFund.Text = aTeam.FundedAmt.ToString("C");
            ShowDetails();
        }

        // Area at the bottom of the form initally set to
        // Visible = false using the Properties Window.
        // Since each of the RadioButton needed to reset
        // the objects to Visible = true, a method is used.
        public void ShowDetails()
        {
            txtBxName.Visible = true;
            lblName.Visible = true;
            txtBxFund.Visible = true;
            lblFundedAmt.Visible = true;
        }
    }
}
