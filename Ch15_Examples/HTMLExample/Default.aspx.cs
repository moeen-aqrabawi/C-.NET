// HTMLExample            Default.aspx.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblOutput.Text = "Thanks!! " +
            txtFirst.Value + " " +
            txtLast.Value +
            " - Information will be forwarded to: " +
            txtEmail.Value;   
    }
}