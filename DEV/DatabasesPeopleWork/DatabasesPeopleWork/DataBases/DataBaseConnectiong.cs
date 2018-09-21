using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace DatabasesPeopleWork.DataBases
{
    public class DataBaseConnectiong
    {
        public readonly string connstring = Properties.Settings.Default.DataS+ Properties.Settings.Default.ConnectionString + Properties.Settings.Default.DBName + ".s3db";

        //check password
        public bool CheckUserPassword(string user, string password)
        {
            using (var con = new SQLiteConnection(connstring))
            {
                //open comunication from databases
                try
                {
                    con.Open();
                }
                catch (Exception OpenConnectionDB)
                {
                    Console.WriteLine("{0} Exception caught.", OpenConnectionDB);
                }

                string txtUser = user;
                string txtPasswd = password;

                //select
                string query = "SELECT * FROM users WHERE UsersName=@userl AND UsersPassword=@passwdl";

                //send select to databases
                var cmd = new SQLiteCommand(query, con);
                //check user and password
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