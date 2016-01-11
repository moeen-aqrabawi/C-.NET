/*  WebControls    Default.aspx
 * This application illustrates adding a number
 * of controls, including a calendar control,
 * to a web page. It also connects to an
 * Access database.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false) // Could also write if(!IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Today;
            }
        }
        catch (System.Exception exc)
        {
            lblMsg.Text = exc.Message;
        }
    }

    protected void btnShowNextMeeting_Click(object sender, EventArgs e)
    {
        Calendar1.SelectedDates.Clear();
        DateTime meetingDate = new DateTime(DateTime.Today.Year,
            DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
        // Meeting is schedule for one week from today!
        meetingDate = meetingDate.AddDays(7);
        // Unless, of course it's Sunday - if so
        // meet on Monday.
        if (meetingDate.DayOfWeek.ToString() == "Sunday")
        {
            meetingDate = meetingDate.AddDays(1);
        }

        Calendar1.TodaysDate = meetingDate;
        Calendar1.SelectedDate = Calendar1.TodaysDate;

        lblMsg.Text = ("Meeting next week: " + meetingDate.DayOfWeek +
            ", " + meetingDate.Month + "/" + meetingDate.Day + " at " +
            meetingDate.Hour + " P.M.");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblSubmit.Text = "Thanks " + txtBxFname.Text +
                       "!    You will be contacted... ";
        if (lstBxInterests.SelectedIndex > -1)
        {
            lblSubmit.Text += " to discuss joining" +
                " the \"" + lstBxInterests.SelectedItem.Text +
                "\" team.";
        }
    }

    protected void radButtons_CheckedChanged(object sender, EventArgs e)
    {
        if (radBtnFresSop.Checked)
        {
            lblClassif.Text = "Freshmen & Sophomores ";
        }
        else if (radBtnJrSr.Checked)
        {
            lblClassif.Text = "Junior & Seniors ";
        }
        else if (radBtnOther.Checked)
        {
            lblClassif.Text = "Special Students ";
        }

        lblClassif.Text += " Always Welcome!";
    }

    protected void btnShowMembers_Click(object sender, EventArgs e)
    {
        lblMembers.Visible = true;
        grdViewMembers.Visible = true;
    }
}