using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPractice.Views.GLS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //  HttpCookie LoginInfoCookie = new HttpCookie("LoginInfo");
            //  LoginInfoCookie["UserName"] = tbUserName.Text;
            //  LoginInfoCookie["UserEmail"] = tbEmailAddress.Text;
            ////  LoginInfoCookie.Expires = DateTime.Now.AddDays(1);
            //  Response.Cookies.Add(LoginInfoCookie);
            //  Response.Redirect("~/Default.aspx");

            Session["UserName"] = tbUserName.Text;
            Session["UserEmail"] = tbEmailAddress.Text;
            Response.Redirect("~/Default.aspx");
        }
    }
}