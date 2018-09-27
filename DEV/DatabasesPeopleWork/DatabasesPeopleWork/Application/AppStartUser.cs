using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using DatabasesPeopleWork;

namespace DatabasesPeopleWork.DataBases
{
    public partial class User_Window : Form
    {
        //Settings connection string generator
        public readonly string connstring = Properties.Settings.Default.DataS + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.DBName + ".s3db";

        LogIn LoginWindow;
        #region for windows back
        public User_Window(LogIn loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
            Hallo_txt.Text = "Welcome " + LoginWindow.User.ToString() + " !";

            if (LoginWindow.User.ToString() == "Admin")
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
        #endregion

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
            Data_txt.Text = DateTime.Now.ToString("yyyy-mmm-dd HH:mm:ss");
        }
        
        private void BT_GoToDB_Click(object sender, EventArgs e)
        {

        }

        private void BT_AddUser_Click(object sender, EventArgs e)
        {

        }
    }
}
