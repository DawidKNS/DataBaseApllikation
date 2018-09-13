﻿using System;
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

        private void Button_login_Click(object sender, EventArgs e)
        {
            DataBaseConnectiong dataBaseConnectiong = new DataBaseConnectiong();
            string user = this.textBox_User.Text;
            string password = this.textBox_password.Text;

            if (dataBaseConnectiong.CheckUserPassword(user,password))
            {
                User_Window AppStartDB = new User_Window(this);
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
