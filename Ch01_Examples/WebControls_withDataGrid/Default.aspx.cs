// WebControls 

using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Data.OleDb;

namespace WebControls
{
	public partial class WebForm1 : System.Web.UI.Page
	{
        protected DataSet memberDS;
        protected DateTime meetingDate;
     
		protected void Page_Load(object sender, System.EventArgs e)
		{

            try
            {
                
                Calendar1.SelectedDate = DateTime.Today;
 
               
            }
            catch (System.Exception exc)
            {
                this.lblMsg.Text = exc.Message;
            }
		}

        protected void btnShowCalendar_Click(object sender, System.EventArgs e)
        {
            Calendar1.SelectedDates.Clear(); 
            meetingDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8,0,0);
            // Meeting is schedule for one week from today!
            meetingDate = meetingDate.AddDays(7);
            // Unless, of course it's Sunday - if so
            // meet on Monday.
            if (meetingDate.DayOfWeek.ToString() == "Sunday")
            {
                meetingDate = meetingDate.AddDays(1);
            }
            
            Calendar1.SelectedDate = meetingDate;
            
            this.lblMsg.Text = ("Meeting next week: " + meetingDate.DayOfWeek + ", " + meetingDate.Month + "/" + meetingDate.Day +  " at " + meetingDate.Hour + " P.M.");
        }

        
        protected void btnShowMembers_Click(object sender, System.EventArgs e)
        {
            lblMembers.Visible = true;
            try
            {
                string  sConnection = 
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=|DataDirectory|member.accdb";
                OleDbConnection  dbConn = new OleDbConnection(sConnection);

                string sql = "Select FirstName, LastName From memberTable Order " +
                    "By LastName Asc, FirstName Asc;";
                OleDbCommand  dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;

                OleDbDataAdapter memberDataAdap = new OleDbDataAdapter();
                memberDataAdap.SelectCommand = dbCmd;
                 memberDS = new DataSet(); //DataSet declared as protected class member
                memberDataAdap.Fill(memberDS, "memberTable");
                // Binding is only change needed that differs from the Windows app 
                this.dataGrid1.DataBind();
            }
            catch (System.Exception exc)
            {
                this.lblMsg.Text = exc.Message;
            }
        }

        
        protected void btnSubmit_Click(object sender, System.EventArgs e)
        {  
            this.lblSubmit.Text = "Thanks " + this.txtBxFname.Text +
                       "!    You will be contacted... ";
            if (lstBxInterests.SelectedIndex > -1)
            {
                this.lblSubmit.Text +=  " to discuss joining" +
                    " the \"" +  this.lstBxInterests.SelectedItem.Text + 
                    "\" team.";
            }
        }

        protected void radioButton_CheckedChanged(object sender, System.EventArgs e)
        {

            if (this.radBtnFresSop.Checked)
            {
                this.lblClassif.Text = "Freshmen & Sophomores ";
            }
            else if (this.radBtnJrSr.Checked)
            {
                this.lblClassif.Text = "Junior & Seniors ";
            }
            else if (this.radBtnOther.Checked)
            {
                this.lblClassif.Text = "Special Students ";
            }
               
            this.lblClassif.Text += " Always Welcome!";
        }
	}
}