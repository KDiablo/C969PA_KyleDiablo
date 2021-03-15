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
    public partial class Main : Form
    {
        private string _username;
        public Main(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //get appointments
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCust = new AddCustomer(_username);
            addCust.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void editDeleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCustomer modCust = new ModifyCustomer(_username);
            modCust.Show();
        }
    }
}
