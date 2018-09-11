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
using DatabasesPeopleWork;


namespace DatabasesPeopleWork.DataBases
{
    public class DataBaseConnectiong
    {
        public bool checkUserPassword(string user, string password)
        {
            using (var con = new SQLiteConnection())
            {
                con.ConnectionString = (@"Data Source=C:\Pozostałe\ProgramyMoje\DEV\DatabasesPeopleWork\DatabasesPeopleWork\DataBases\DBapp.s3db");
                con.Open();
                string txtUser = user;
                string txtPasswd = password;
                string query = "SELECT * FROM Logowanie WHERE UsersName=@user AND UsersPasswd=@passwd";
                var cmd = new SQLiteCommand(query,con);

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