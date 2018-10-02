using System;
using System.Data.SQLite;


namespace DatabasesPeopleWork.DataBases
{
    public class DataBaseConnectiong
    {
        //Settings connection string generator
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
                string query = "SELECT * FROM users WHERE UsersName=@user AND UsersPassword=@passwd";

                //send select to databases
                var cmd = new SQLiteCommand(query, con);

                //check user and password
                cmd.Parameters.AddWithValue("@user", txtUser);
                cmd.Parameters.AddWithValue("@passwd", txtPasswd);
                var dr = cmd.ExecuteReader();
                var t = dr.HasRows;
                var z = dr.Read();

                string AccoutTypeRead = string.Format("{0}", dr["AccountType"].ToString());

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