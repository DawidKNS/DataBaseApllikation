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
        }

        private void DataBaseExplorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginWindow.Visible = true;
        }
        #endregion

        private void User_Window_Load(object sender, EventArgs e)
        {
        #region refresch clock
            Timer timer = new Timer();
            timer.Interval = (1* 100); // 1 msecs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            #endregion
        }
        //Zegarek
        private void timer_Tick(object sender, EventArgs e)
        {
            Data_txt.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
