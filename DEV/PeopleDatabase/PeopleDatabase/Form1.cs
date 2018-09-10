using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=C:\Pozostałe\DataBaseApllikation\DataBaseApllikation\DEV\PeopleDatabase\BazaDanych\DBapp");
            con.Open();

            string txtUser = user;
            string txtPasswd = password;
            string query = "SELECT * FROM Logowanie WHERE UsersName=@user AND UsersPasswd=@passwd";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", txtUser);
            cmd.Parameters.AddWithValue("@passwd", txtPasswd);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                MessageBox.Show("Zalogowano poprawnie");
                return true;
            }

            else
            {
                MessageBox.Show("Błąd logowania");
                return false;
            }
        }
    }
}
