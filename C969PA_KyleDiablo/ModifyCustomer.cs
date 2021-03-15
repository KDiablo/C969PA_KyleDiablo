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
    public partial class ModifyCustomer : Form
    {
        private string _username;
        DBConnect dbConn;

        public ModifyCustomer(string username)
        {
            InitializeComponent();
            txtNewName.Enabled = false;
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAddr.DropDownStyle = ComboBoxStyle.DropDownList;
            _username = username;
            dbConn = new DBConnect();
            cboCustomer.ValueMember = "customerId";
            cboCustomer.DisplayMember = "customer";
            List<Customer> c = dbConn.GetAllCustomers();
            //Adds fake entry to prompt user
            c.Insert(0, new Customer(-1, "---Select---", -1, 0));
            cboCustomer.DataSource = c;

            cboCountry.ValueMember = "countryId";
            cboCountry.DisplayMember = "country";
            List<Country> count = dbConn.GetAllCountries();
            //Adds fake entry to prompt user
            count.Insert(0, new Country(-1, "---Select---"));
            cboCountry.DataSource = count;
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer cust = (Customer)cboCustomer.SelectedItem;
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
            string name = cboCustomer.SelectedValue.ToString();
            string newName = txtNewName.Text;
            int country = dbConn.GetCountryIdFromName(cboCountry.SelectedValue.ToString());
            int city = dbConn.GetCityIdFromName(cboCities.SelectedValue.ToString());
            int addr = dbConn.GetAddressIdFromName(cboAddr.SelectedValue.ToString());
            int active = 0;

            if (checkBox2.Checked)
            {
                active = 1;
            }

            if (IsAuthenticated(name, newName, country, city, addr))
            {
                if (!checkBox1.Checked)
                {
                    dbConn.ModifyCustomer(name, name, addr, active, _username);
                    MessageBox.Show($"{name} modified!");
                    Logger.Log($"{_username} modified {name}");
                    this.Close();
                }
                else
                {
                    dbConn.ModifyCustomer(newName,name, addr, active, _username);
                    MessageBox.Show($"{name} modified!");
                    Logger.Log($"{_username} modified {name}");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Could not modify customer");
                Logger.Log($"{_username} Could not modify customer");
            }
        }

        private bool IsAuthenticated(string name, string newName, int country, int city, int addr)
        {


            if ( String.IsNullOrWhiteSpace(name) || name == "---Select---" || country < 1 || city < 1 || addr < 1 || (checkBox1.Checked && String.IsNullOrWhiteSpace(newName) && checkBox1.Checked))
            {
                MessageBox.Show("Please correct your entries.");
                Logger.Log($"{_username} Could not modify customer");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = cboCustomer.SelectedValue.ToString();
            if (!String.IsNullOrWhiteSpace(name) || name != "---Select---")
            {
                dbConn.DeleteCustomer(name);
                MessageBox.Show(name + " deleted.");
                Logger.Log($"{_username} deleted customer {name}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please correct your entries.");
                Logger.Log($"{_username} Could not delete customer");
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtNewName.Enabled = true;
            }
            else
            {
                txtNewName.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // not implemented

        }
    }
}
