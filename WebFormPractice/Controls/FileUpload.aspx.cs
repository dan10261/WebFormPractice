using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Net.Controlls
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFileBtn_Click(object sender, EventArgs e)
        {
            //File not uploaded, error message
            if(UploadFile.FileName.Length == 0)
            {
                UploadFileMsg.Text = "Choose a file to upload";
                UploadFileMsg.ForeColor = System.Drawing.Color.Red;
            }
            string fileExt = System.IO.Path.GetExtension(UploadFile.FileName);
            if (fileExt != ".doc" && fileExt != ".docx")
            {
                UploadFileMsg.Text = "File extension should be doc or docx";
                UploadFileMsg.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                int filesize = UploadFile.PostedFile.ContentLength;
                if (filesize > 80000)
                {
                    UploadFileMsg.Text = "File size cannot be more than 80000 bytes.";
                    UploadFileMsg.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    UploadFile.SaveAs(Server.MapPath("~/Resources/Uploads/" + UploadFile.FileName));
                    UploadFileMsg.Text = "File" + UploadFile.FileName + " is successfully uploaded.";
                    UploadFileMsg.ForeColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}