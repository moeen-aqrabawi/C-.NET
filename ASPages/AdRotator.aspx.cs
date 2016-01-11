using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASPages_AdRotator : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AdRotator1.KeywordFilter = "Trios";
        Label1.Text = System.DateTime.Now.ToString();

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {

        Label1.Text = System.DateTime.Now.ToString();

    }

}