using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969PA_KyleDiablo
{
    public partial class AddCustomer : Form
    {
        private string _username;
        DBConnect dbConn;
        public AddCustomer(string username)
        {
            InitializeComponent();
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAddr.DropDownStyle = ComboBoxStyle.DropDownList;
            _username = username;
            dbConn = new DBConnect();
            cboCountry.ValueMember = "countryId";
            cboCountry.DisplayMember = "country";
            List<Country> c = dbConn.GetAllCountries();
            //Adds fake entry to prompt user
            c.Insert(0, new Country(-1, "---Select---"));
            cboCountry.DataSource = c;
            
        }
        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cboCountry.SelectedValue.ToString();
            if (country != "---Select---")
            {
                //int countryId = 0;
                //int.TryParse(country, out countryId);
                dbConn = new DBConnect();
                cboCities.ValueMember = "cityId";
                cboCities.DisplayMember = "city";
                List<City> c = dbConn.GetCitiesByCountry(dbConn.GetCountryIdFromName(country));
                //Adds fake entry to prompt user
                c.Insert(0, new City(-1, "---Select---", -1));
                cboCities.DataSource = c;
            }
        }

        private void cboCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cboCities.SelectedValue.ToString();
            if (city != "---Select---")
            {
                //int countryId = 0;
                //int.TryParse(country, out countryId);
                dbConn = new DBConnect();
                cboAddr.ValueMember = "addressId";
                cboAddr.DisplayMember = "address";
                List<Address> a = dbConn.GetAddressesByCity(dbConn.GetCityIdFromName(city));
                //Adds fake entry to prompt user
                a.Insert(0, new Address(-1, "---Select---", "", -1, "", ""));
                cboAddr.DataSource = a;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int country = dbConn.GetCountryIdFromName(cboCountry.SelectedValue.ToString());
            int city = dbConn.GetCityIdFromName(cboCities.SelectedValue.ToString());
            int addr = dbConn.GetAddressIdFromName(cboAddr.SelectedValue.ToString());

            if (IsAuthenticated(name, country, city, addr))
            {
                dbConn.AddCustomer(name, addr, 1, _username);
                MessageBox.Show($"{name} added!");
                Logger.Log($"{_username} added {name}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not add customer");
                Logger.Log($"{_username} Could not add customer");
            }
        }

        private bool IsAuthenticated(string name, int country, int city, int addr)
        {
            

           if (String.IsNullOrWhiteSpace(name) || country < 1 || city < 1 || addr < 1)
            {
                MessageBox.Show("Please correct your entries.");
                Logger.Log($"{_username} Could not add customer");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
