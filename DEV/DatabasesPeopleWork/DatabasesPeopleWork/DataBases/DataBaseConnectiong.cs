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


namespace DatabasesPeopleWork.DataBases
{
    public class DataBaseConnectiong
    {
        public bool CheckUserPassword(string user, string password)
        {
            using (var con = new SQLiteConnection())
            {
                con.ConnectionString = @"C:\Pozostałe\ProgramyMoje\DEV\DatabasesPeopleWork\DatabasesPeopleWork\DataBases\DBapp.s3db";
                con.Open();
                string txtUser = user;
                string txtPasswd = password;
                string query = "SELECT * FROM users WHERE UsersName=@userl AND UsersPassword=@passwdl";
                var cmd = new SQLiteCommand(query,con);

                cmd.Parameters.AddWithValue("@userl", txtUser);
                cmd.Parameters.AddWithValue("@passwdl", txtPasswd);

                var dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
    }
}