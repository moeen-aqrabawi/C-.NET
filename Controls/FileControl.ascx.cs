using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_FileControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        if (FileUpload1.PostedFile != null && FileUpload1.HasFile)
        {
            try
            {
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //Save files to images folder
                FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileName));
                this.imgDemo.ImageUrl = "~/UPloads/" + FileName;

                sb.AppendFormat(" Uploading file: {0}", FileUpload1.FileName);

                //Showing the file information
                sb.AppendFormat("<br/> File name: {0}", FileUpload1.PostedFile.FileName);
                sb.AppendFormat("<br/> File type: {0}", FileUpload1.PostedFile.ContentType);
                sb.AppendFormat("<br/> File length: {0}", FileUpload1.PostedFile.ContentLength);
                lblmessage.Text = sb.ToString();

            }
            catch (Exception ex)
            {
                sb.Append("<br/> Error <br/>");
                sb.AppendFormat("Unable to get the file <br/> {0}", ex.Message);
            }
        }
   }
 }