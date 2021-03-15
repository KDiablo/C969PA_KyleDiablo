using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace C969PA_KyleDiablo
{
    class DBConnect
    {
        private MySqlConnection _conn;
        private string _dbServer;
        private string _databaseName;
        private string _username;
        private string _password;
        private string _port;

        public DBConnect()
        {
            init();
        }

        private void init()
        {
            _dbServer = "wgudb.ucertify.com";
            _databaseName = "U06N0V";
            _username = "U06N0V";
            _password = "53688811572";
            _port = "3306";
            string connectionString;
            connectionString = $"SERVER={_dbServer};PORT={_port};DATABASE={_databaseName};UID={_username};PASSWORD={_password};";

            _conn = new MySqlConnection(connectionString);
        }
        public string TestConn()
        {
            _conn.Open();
            string ver = _conn.ServerVersion;
            _conn.Close();
            return ver;
        }
        public bool DoLogin(string username, string pw)
        {
            int rows = 0;
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT userName FROM user WHERE userName='{username}' AND password='{pw}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rows ++;
                }
                if( rows > 0)
                {
                    reader.Close();
                    _conn.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    _conn.Close();
                    return false;
                }
            } catch (Exception ex)
            {    
                try
                {
                    _conn.Close();
                } catch (Exception err)
                {
                    return false;
                }
                return false;
            } 
        }

        public bool NewAppointment(int customerId, int userId, string title, string description, string location, 
            string contact, string type, string url, DateTime start, DateTime end, string userName)
        {
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO appointment (customerId, userId, title, description, location, " +
                    $"contact, type, url, start, end, createDate, createdBy, lastUpdatedBy) VALUES ('{customerId}', '{userId}', '{title}', '{description}', " +
                    $"'{location}', '{contact}', '{type}', '{url}', '{start}', '{end}', 'CURRENT_TIME()', '{userName}', '{userName}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   //nothing
                }
                reader.Close();
                _conn.Close();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public void AddCustomer(string customerName, int addressId, int active, string username)
        {
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy) VALUES" +
                    $" ('{customerName}', {addressId}, {active}, Now(), '{username}', '{username}');", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //nothing
                }
                reader.Close();
                _conn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public void ModifyCustomer(string customerName, string oldName, int addressId, int active, string username)
        {
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"UPDATE customer SET customerName = '{customerName}', addressId = {addressId}, lastUpdateBy = '{username}', lastUpdate = Now(), active = {active}  WHERE customerName = '{oldName}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //nothing
                }
                reader.Close();
                _conn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteCustomer(string customerName)
        {
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"DELETE FROM customer WHERE customerName = '{customerName}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //nothing
                }
                reader.Close();
                _conn.Close();

            }
            catch (Exception ex)
            {

            }
        }

        public List<Address> GetAddressesByCity(int cityId)
        {
            List<Address> addresses = new List<Address>();
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT addressId, address, address2, postalCode, phone FROM address WHERE cityId = {cityId};", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Address addr = new Address(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), cityId, reader.GetString(3), reader.GetString(4));
                    addresses.Add(addr);
                }
                reader.Close();
                _conn.Close();
                return addresses;
            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return null;
                }
                return null;
            }
        }

        public int GetCountryIdFromName(string name)
        {
            //SELECT countryId from country where country = 'name';
            
            int id = 0;
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT countryId from country where country = '{name}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                _conn.Close();
                return id;
            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return 0;
                }
                return 0;
            }
        }
        public List<City> GetCitiesByCountry(int countryId) // Alter to get cities by country name.
        {
            List<City> cities = new List<City>();
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT cityId, city FROM city WHERE countryId= {countryId};", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    City city = new City(reader.GetInt32(0), reader.GetString(1), countryId);
                    cities.Add(city);
                }
                reader.Close();
                _conn.Close();
                return cities;

            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return null;
                }
                return null;
            }
        }
        public int GetCityIdFromName(string name)
        {
            //SELECT countryId from country where country = 'name';

            int id = 0;
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT cityId from city where city = '{name}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                _conn.Close();
                return id;
            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return 0;
                }
                return 0;
            }
        }

        public int GetAddressIdFromName(string name)
        {
            //SELECT countryId from country where country = 'name';

            int id = 0;
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT addressId from address where address = '{name}';", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                _conn.Close();
                return id;
            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return 0;
                }
                return 0;
            }
        }

        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM country", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Country country = new Country(reader.GetInt32(0), reader.GetString(1));
                    countries.Add(country);
                }
                reader.Close();
                _conn.Close();
                return countries;

            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return null;
                }
                return null;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                _conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM customer", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt16(3));
                    customers.Add(customer);
                }
                reader.Close();
                _conn.Close();
                return customers;

            }
            catch (Exception ex)
            {
                try
                {
                    _conn.Close();
                }
                catch (Exception err)
                {
                    return null;
                }
                return null;
            }
        }
    }            
}
