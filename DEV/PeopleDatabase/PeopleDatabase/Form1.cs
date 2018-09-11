﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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

            if (chechUserPassword(user, password))
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
            using (var con = new SQLiteConnection())
            {
                con.ConnectionString = (@"Data Source=C:\Users\d.kondracki\Downloads\DataBaseApllikation-master\DEV\PeopleDatabase\BazaDanych\DBapp.s3db");
                con.Open();

                string txtUser = user;
                string txtPasswd = password;
                string query = "SELECT * FROM Logowanie WHERE UsersName=@user AND UsersPasswd=@passwd";
                var cmd = new SQLiteCommand(query, con);

                cmd.Parameters.AddWithValue("@user", txtUser);
                cmd.Parameters.AddWithValue("@passwd", txtPasswd);

                var dr = cmd.ExecuteReader();
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
}