using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Form_Net.Controlls
{
    public partial class Address : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // ddlContinent.DataSource = getData("Continents.xml");
                ddlContinent.DataSource = getDataByforeignKeyId("Continents.xml", "Continent", null, null, null, null);
                ddlContinent.DataBind();
                ListItem firstItem = new ListItem("Select a continent", "-1");
                ddlContinent.Items.Insert(0, firstItem);
                ListItem firstItem1 = new ListItem("Select a city", "-1");
                ddlCity.Items.Insert(0, firstItem1);
                ListItem firstItem2 = new ListItem("Select a country", "-1");
                ddlCountry.Items.Insert(0, firstItem2);

                ddlCountry.Enabled = false;
                ddlCity.Enabled = false;
            }
        }
        private DataSet getDataByforeignKeyId(string FileName, string TableName, string foreignKeyId, string foreignKeyName, string ColumnName1, string ColumnName2)
        {
            DataSet DS = new DataSet();
            DS.ReadXml(Server.MapPath("~/Resources/XML/" + FileName));
            if (foreignKeyId == null) return DS;
            else
            {
                DataSet DSToReturn = DS.Clone();
                DataTable table = DS.Tables[TableName];
                DataTable DsTempTable = DSToReturn.Tables[TableName];
                foreach (DataRow row in table.Rows)
                {
                    if (row[foreignKeyName].ToString() == foreignKeyId)
                    {
                        DataRow workRow = DsTempTable.NewRow();
                        workRow[ColumnName1] = row[ColumnName1];
                        workRow[ColumnName2] = row[ColumnName2];
                        DsTempTable.Rows.Add(workRow);
                    }
                }
                return DSToReturn;
            }
        }
        private DataSet getData(string FileName)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/Resources/XML/" + FileName));
            return ds;
        }

        private DataSet getCountriesByContinentId(string ContinentId)
        {

            DataSet AllCountries = getData("Countries.xml");
            DataSet CountriesByContinentIdDS = AllCountries.Clone();
            DataTable CountriesByContinentIdTable = CountriesByContinentIdDS.Tables["Country"];
            DataTable table = AllCountries.Tables["Country"];
            foreach (DataRow row in table.Rows)
            {
                if (row["ContinentId"].ToString() == ContinentId)
                {
                    DataRow workRow = CountriesByContinentIdTable.NewRow();
                    workRow["CountryName"] = row["CountryName"];
                    workRow["CountryId"] = row["CountryId"];
                    CountriesByContinentIdTable.Rows.Add(workRow);
                }
            }
            return CountriesByContinentIdDS;
        }
        private DataSet getCitiesByCountryId(string CountryId)
        {
            DataSet AllCities = getData("Cities.xml");
            DataSet CitiesByContinentIdDS = AllCities.Clone();
            CitiesByContinentIdDS.Clear();
            DataTable CitiesByContinentIdTable = CitiesByContinentIdDS.Tables["City"];
            DataTable table = AllCities.Tables["City"];
            foreach (DataRow row in table.Rows)
            {
                if (row["CountryId"].ToString() == CountryId)
                {
                    DataRow workRow = CitiesByContinentIdTable.NewRow();
                    workRow["CityName"] = row["CityName"];
                    workRow["CityId"] = row["CityId"];
                    CitiesByContinentIdTable.Rows.Add(workRow);
                }
            }
            return CitiesByContinentIdDS;
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountry.SelectedIndex == 0)
            {
                ddlCity.Enabled = false;
                ddlCity.SelectedIndex = 0;
            }
            else
            {
                ddlCity.Enabled = true;
                // ddlCity.DataSource = getCitiesByCountryId(ddlCountry.SelectedValue);
                ddlCity.DataSource = getDataByforeignKeyId("Cities.xml", "City", ddlCountry.SelectedValue, "CountryId", "CityId", "CityName");
                ddlCity.DataBind();
                ListItem firstItem = new ListItem("Select a city", "-1");
                ddlCity.Items.Insert(0, firstItem);
            }
        }

        protected void ddlContinent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContinent.SelectedIndex == 0)
            {
                ddlCountry.Enabled = false;
                ddlCountry.SelectedIndex = 0;
                ddlCity.Enabled = false;
                ddlCity.SelectedIndex = 0;
            }
            else
            {
                ddlCountry.Enabled = true;
                ddlCity.Enabled = false;
                // ddlCountry.DataSource = getCountriesByContinentId(ddlContinent.SelectedValue);
                ddlCountry.DataSource = getDataByforeignKeyId("Countries.xml", "Country", ddlContinent.SelectedValue, "ContinentId", "CountryName", "CountryId");
                ddlCountry.DataBind();
                ListItem firstItem = new ListItem("Select a country", "-1");
                ddlCountry.Items.Insert(0, firstItem);
            }
        }

        public void ServerExecuteBtn_Click(object sender, EventArgs e)
        {
            Server.Execute("~/Controls/AddressDetail.aspx");
        }

        protected void ServerTransferBtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Controls/AddressDetail.aspx");
        }
    }
}