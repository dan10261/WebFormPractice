using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Form_Net.Controlls;

namespace Web_Form_Net.Controls
{
    public partial class AddressDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection previousForm = Request.Form;

            Address prevAddressPage = (Address)Page.PreviousPage;
            if (PreviousPage == null)
                Response.Redirect("~/Controls/Address.aspx");
            ContentPlaceHolder PlaceHolder = (ContentPlaceHolder)PreviousPage.Master.FindControl("MainContent");

            ddlCountryLiteral.Text =((DropDownList)PlaceHolder.FindControl("ddlCountry")).SelectedItem.Text;

            ddlCityLiteral.Text = ((DropDownList)PlaceHolder.FindControl("ddlCity")).SelectedItem.Text;
            ddlContinentLiteral.Text = ((DropDownList)PlaceHolder.FindControl("ddlContinent")).SelectedItem.Text;
        }
    }
}