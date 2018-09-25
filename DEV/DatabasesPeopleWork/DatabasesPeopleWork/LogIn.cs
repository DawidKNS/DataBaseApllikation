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
using DatabasesPeopleWork.Settings;

namespace DatabasesPeopleWork
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            //getup user and password
        }

        #region button logIn
        public void Button_login_Click(object sender, EventArgs e)
        {
            //connecting to Databases
            DataBaseConnectiong dataBaseConnectiong = new DataBaseConnectiong();

          string user = this.textBox_User.Text;
          string password = this.textBox_password.Text;

            //check user and password
            if (dataBaseConnectiong.CheckUserPassword(user,password))
            {
                //go to window appstart
                User_Window AppStartDB = new User_Window(this);
                this.Visible = false;
                AppStartDB.Owner = this;
                AppStartDB.ShowDialog();

                //Clear textbox user and password, messagebox
                textBox_User.Text = "";
                textBox_password.Text = "";
                MessageTXTlogin.Text = "";
            }
            else
            {
                MessageTXTlogin.Text = "Uncorrect user or password";
            }
        }
        #endregion

        #region button Settings
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //go to window settings
            Settings_Name settings = new Settings_Name(this);
            this.Visible = false;
            settings.ShowDialog();

            //clear textbox user and password, messagebox
            textBox_User.Text = "";
            textBox_password.Text = "";
            MessageTXTlogin.Text = "";
        }
        #endregion
    }
}
