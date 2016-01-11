using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_FormControl : System.Web.UI.UserControl
{


    public SortedList CountryList()
    {
        SortedList slCountry = new SortedList();
        string Key = "";
        string Value = "";

        foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
        {
            RegionInfo info2 = new RegionInfo(info.LCID);
            if (!slCountry.Contains(info2.EnglishName))
            {
                Value = info2.TwoLetterISORegionName;
                Key = info2.EnglishName;
                slCountry.Add(Key, Value);
            }
        }
        return slCountry;
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        ddlLocation.DataSource = CountryList();
        ddlLocation.DataTextField = "Key";
        ddlLocation.DataValueField = "Value";
        ddlLocation.DataBind();
    }


    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (!string.IsNullOrEmpty(HomePhone.Text))
        {
            args.IsValid = true;

        }
        else
        {
            args.IsValid = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(5000);
        Label1.Text = "name: " + Name.Text + " <br/> Email Address :" +
            Email.Text + "<br/> Phone : " + HomePhone.Text +
            "<br/> Comments: " + comments.Text;

        Message.Visible = true;
        MessageSentPara.Visible = true;
        FormTable.Visible = false;
    }
}
