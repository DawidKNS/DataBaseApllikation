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

namespace DatabasesPeopleWork
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DataBaseConnectiong dataBaseConnectiong = new DataBaseConnectiong();
            string user = this.textBox_User.Text;
            string password = this.textBox_password.Text;

            if (dataBaseConnectiong.checkUserPassword(user,password))
            {
                DataBaseExplorer AppStartDB = new DataBaseExplorer(this);
                this.Visible = false;
                AppStartDB.ShowDialog();
            }
            else
            {
                MessageBox.Show("Błędny Login lub Hasło");
            }
        }
    }
}
