using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPractice
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie LoginInfoCookie = Request.Cookies.Get("LoginInfo");
            //if (LoginInfoCookie != null)
            //{
            //    lUserName.Text = LoginInfoCookie["UserName"];
            //    lUserEmail.Text = LoginInfoCookie["UserEmail"];
            //}
            if (Session["UserName"] != null && Session["UserName"].ToString().Length>0 && Session["UserEmail"] != null && Session["UserEmail"].ToString().Length > 0)
            {
                lUserName.Text = Session["UserName"].ToString();
                lUserEmail.Text = Session["UserEmail"].ToString();
            }
        }
    }
}