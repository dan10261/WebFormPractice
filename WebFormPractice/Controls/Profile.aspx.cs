using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Net.Controlls
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                MultiViewProfile.SetActiveView(ViewPersonalDetail);
        }

        protected void btnStep2_Click(object sender, EventArgs e)
        {
            MultiViewProfile.SetActiveView(ViewContactDetail);
        }

        protected void btnStep2To1_Click(object sender, EventArgs e)
        {
            MultiViewProfile.SetActiveView(ViewPersonalDetail);
        }

        protected void btnStep2To3_Click(object sender, EventArgs e)
        {
            MultiViewProfile.SetActiveView(ViewSummary);
            lblFirstName.Text = tbFirstName.Text;
            lblLastName.Text = tbLastName.Text;
            lblGender.Text = ddlGender.SelectedItem.Text;
            lblPhone.Text = tbPhone.Text;
            lblEmail.Text = tbEmail.Text;
        }

        protected void btnStep3To2_Click(object sender, EventArgs e)
        {
            MultiViewProfile.SetActiveView(ViewContactDetail);
        }

        protected void btnSummary_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Controlls/Confirm");
        }
    }
}