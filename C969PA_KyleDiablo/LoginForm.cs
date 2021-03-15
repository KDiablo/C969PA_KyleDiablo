using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C969PA_KyleDiablo
{
    public partial class LoginForm : Form
    {
        CultureInfo userCulture;
        Dictionary<string, string> languageList = new Dictionary<string, string>();
        
        public LoginForm()
        {
            InitializeComponent();
            userCulture = CultureInfo.CurrentCulture;
            lblTimeZone.Text = TimeZone.CurrentTimeZone.StandardName + ", UTC offset: " + TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
            InitLanguageList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect dbconn = new DBConnect();
            if(dbconn.DoLogin(txtUsername.Text, txtPassword.Text))
            {
                Logger.Log($"Successful login by {txtUsername.Text}.");
                Main mainForm = new Main(txtUsername.Text);
                this.Hide();// find something better
                mainForm.Show();
            }
            else
            {
                Logger.Log($"Failed login. Unsername tried: {txtUsername.Text}.");
                KeyValuePair<string, string> selectedEntry = (KeyValuePair<string, string>)cmboLang.SelectedItem;
                string key = selectedEntry.Key;
                string value = selectedEntry.Value;
                
                switch (key)
                {
                    case "English":
                        MessageBox.Show(value + "\n" + languageList["Español"]);
                        break;
                    case "Español":
                        MessageBox.Show(value + "\n" + languageList["English"]);
                        break;
                    case "Français":
                        MessageBox.Show(value + "\n" + languageList["English"]);
                        break;
                    case "हिंदी":
                        MessageBox.Show(value + "\n" + languageList["English"]);
                        break;
                    case "普通话":
                        MessageBox.Show(value + "\n" + languageList["English"]);
                        break;
                }
            }
        }
        private void InitLanguageList()
        {
            languageList.Add("English", "The username and password did not match.");
            languageList.Add("Español", "El nombre de usuario y la contraseña no coincidieron.");
            languageList.Add("Français", "Le nom d'utilisateur et le mot de passe ne correspondaient pas.");
            languageList.Add("हिंदी", "उपयोगकर्ता नाम और पासवर्ड मेल नहीं खाता।");
            languageList.Add("普通话", "用户名和密码不匹配");
            cmboLang.DataSource = new BindingSource(languageList, null);
            cmboLang.DisplayMember = "Key";
            cmboLang.ValueMember = "Value";
        }
    }
}
