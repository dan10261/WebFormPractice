using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPractice.Views.GLS
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie cookie = Request.Cookies["LoginInfo"];
            //if(cookie != null)
            //{
            //    cookie.Expires = DateTime.UtcNow;
            //}
            //Response.Redirect("~/Default.aspx");
            if (Session["UserName"] != null && Session["UserEmail"] != null)
            {
                Session.Remove("UserName");
                Session.Remove("UserEmail");
            }
            Response.Redirect("~/Default.aspx");
        }
    }
}