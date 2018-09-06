using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = this.User.Text;
            string password = this.password.Text;

            if (chechUserPassword(user,password))
            {
                AppStart AppStartDB = new AppStart(this);
                this.Visible = false;
                AppStartDB.ShowDialog();
            }
            else
            {
                MessageBox.Show("Błędny Login lub Hasło");
            }

        }

        public bool chechUserPassword(string user, string password)
        {
            if (user == "Dawid" & password == "Dawid")
                return true;
            else
            {

            }
            return false;

        }
    }
}
