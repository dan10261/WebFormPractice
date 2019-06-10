using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Net
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClickMeCountTextBox.Text = "0";
                LoadCityDropDownList();
                LoadCountryDropDownList();
                LoadEducationCheckBoxList();
            }
            ApplicationCount.Text = Application["ApplicationCount"].ToString();
            OnLineUserCount.Text = Application["OnLineUsersCount"].ToString();
        }
        protected void LoadCityDropDownList()
        {
            ListItem CityItem1 = new ListItem("Loudoun");

            ListItem CityItem2 = new ListItem("Fairfax");

            ListItem CityItem3 = new ListItem("Vienna");

            CityDropDownList.Items.Add(CityItem1);
            CityDropDownList.Items.Add(CityItem2);
            CityDropDownList.Items.Add(CityItem3);
        }
        protected void SelectAllBtn_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in cblEducation.Items)
            {
                li.Selected = true;
                lbEducation.Items.Add(li.Text);
            }
        }
        protected void DeSelectAllbtn_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in cblEducation.Items)
            {
                li.Selected = false;
            }
            lbEducation.Items.Clear();
        }
        protected void loadEducationCheckBoxList_OnSeletedListCheckBox(object sender, EventArgs e)
        {
            lbEducation.Items.Clear();
            foreach(ListItem item in cblEducation.Items)
            {
                if(item.Selected)
                {
                    lbEducation.Items.Add(item.Text);
                }
            }
        }
        protected void LoadCountryDropDownList()
        {
            DataSet data = new DataSet();
            CountryDropDownList.DataTextField = "CountryName";
            CountryDropDownList.DataValueField = "CountryID";
            data.ReadXml(Server.MapPath("~/Resources/XML/Countries.xml"), XmlReadMode.Auto);
            CountryDropDownList.DataSource = data;
            CountryDropDownList.DataBind();
            ListItem firstItem = new ListItem("Not Selected", "-1");
            CountryDropDownList.Items.Insert(0, firstItem);
        }
        protected void LoadEducationCheckBoxList()
        {
            ListItem ListBoxItemEduCertificate = new ListItem("Certificate", "0");
            ListItem ListBoxItemEduGrad = new ListItem("Graduate", "1");
            ListItem ListBoxItemEduBachelor = new ListItem("Bachelor", "2");
            ListItem ListBoxItemEduDoctor = new ListItem("Doctor", "3");
            cblEducation.Items.Add(ListBoxItemEduCertificate);
            cblEducation.Items.Add(ListBoxItemEduGrad);
            cblEducation.Items.Add(ListBoxItemEduBachelor);
            cblEducation.Items.Add(ListBoxItemEduDoctor);
        }
        protected void ClickMeButton_Click(object sender, EventArgs e)
        {
            ClickMeCountTextBox.Text = (Convert.ToInt32(ClickMeCountTextBox.Text) + 1).ToString();
            DisplaySelectedDropDownItem();
            DisplaySelectedCheckBoxListItem();
        }
        private void DisplaySelectedDropDownItem()
        {
            if (CountryDropDownList.SelectedIndex == -1)
            {
                Response.Write("Please select an item from the dropdown");
            }
            else
            {
                Response.Write("The selected item is " + CountryDropDownList.SelectedItem.Text);
                Response.Write("<br/> ");
            }
        }
        private void DisplaySelectedCheckBoxListItem()
        {
            foreach (ListItem item in cblEducation.Items)
            {
                if (item.Selected)
                {
                    Response.Write("The selected name is " + item.Text);
                    Response.Write("The selected value is " + item.Value.ToString());
                    Response.Write("The selected index is " + item.Value.ToString());
                    Response.Write("<br/> ");
                }
            }
        }

        protected void ClickMeCountTextBox_TextChanged(object sender, EventArgs e)
        {
            Response.Write("text changed");
        }

        protected void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var sender1 = sender.ToString();
            var event1 = e.ToString();
            Response.Write("Last name is changed");
        }
        protected void GenderRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (FemaleRadioBtn.Checked)
                Response.Write("You choose " + FemaleRadioBtn.Text.ToString());
            else if (MaleRadioBtn.Checked)
                Response.Write("You choose " + MaleRadioBtn.Text.ToString());
            else if (UnknownRadioBtn.Checked)
                Response.Write("You choose " + UnknownRadioBtn.Text.ToString());
        }

        protected void CommandMe_Commands(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                Response.Write("Command " + e.CommandName.ToString() + " is clicked.");
            }
            else if (e.CommandName == "Print")
            {
                Response.Write("Command " + e.CommandName.ToString() + " is clicked.");
            }
            else if (e.CommandName == "PrintTop")
            {
                if (e.CommandArgument.ToString() == "Top10")
                    Response.Write("Command " + e.CommandName.ToString() + " " + e.CommandArgument.ToString() + " is clicked.");
                else if (e.CommandArgument.ToString() == "Top20")
                    Response.Write("Command " + e.CommandName.ToString() + " " + e.CommandArgument.ToString() + " is clicked.");
            }
            else if (e.CommandName == "Email")
            {
                Response.Write("Command " + e.CommandName.ToString() + " is clicked.");
            }
        }

        
    }
}