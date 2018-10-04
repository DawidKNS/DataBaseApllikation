using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using DatabasesPeopleWork.Application;

namespace DatabasesPeopleWork.DataBases
{
    public partial class User_Window : Form
    {
        public readonly string connstring = Properties.Settings.Default.DataS + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.DBName + ".s3db";

        LogIn LoginWindow;
        public User_Window(LogIn loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
            Hallo_txt.Text = "Welcome " + LoginWindow.User.ToString() + " !";
            string userR = LoginWindow.User.ToString();

            if (userR == "Admin")
            {
                BT_AddUser.Visible = true;
            }
            else
            {
                BT_AddUser.Visible = false;
            }
        }

        private void DataBaseExplorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginWindow.Visible = true;
        }

        private void User_Window_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 100); // 1 msecs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        //Zegarek
        private void timer_Tick(object sender, EventArgs e)
        {
            Data_txt.Text = "Data: " + DateTime.Now.ToString("yyyy-MM-dd") + " Godzina: " + DateTime.Now.ToString("HH:mm: ss");
        }
        
        private void BT_GoToDB_Click(object sender, EventArgs e)
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

                //select
                string query = "SELECT * FROM employeeData";
                SQLiteDataAdapter connect4 = new SQLiteDataAdapter(query, con);
                DataSet ds4 = new DataSet();
                connect4.Fill(ds4);
                dataGridViewDBP.DataSource = ds4.Tables[0];

                text_whatViev.Text = "Baza Danych";

            }
        }

        private void BT_AddUser_Click(object sender, EventArgs e)
        {

        }
    }
}
