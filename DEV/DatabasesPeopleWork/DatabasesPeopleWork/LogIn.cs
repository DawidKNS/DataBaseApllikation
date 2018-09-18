using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabasesPeopleWork.DataBases;
using DatabasesPeopleWork.Settings;

namespace DatabasesPeopleWork
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public void Button_login_Click(object sender, EventArgs e)
        {
            DataBaseConnectiong dataBaseConnectiong = new DataBaseConnectiong();
            string user = this.textBox_User.Text;
            string password = this.textBox_password.Text;

            if (dataBaseConnectiong.CheckUserPassword(user,password))
            {
                User_Window AppStartDB = new User_Window(this);
                this.Visible = false;
                AppStartDB.ShowDialog();
                textBox_User.Text = "";
                textBox_password.Text = "";
            }
            else
            {
                MessageBox.Show("Błędny Login lub Hasło");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Name settings = new Settings_Name(this);
            this.Visible = false;
            settings.ShowDialog();
            textBox_User.Text = "";
            textBox_password.Text = "";
        }
    }
}
