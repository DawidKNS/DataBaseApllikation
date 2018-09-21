using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace DatabasesPeopleWork.Settings
{
    public partial class Settings_Name : Form
    {
        LogIn LoginWindow;
        public Settings_Name()
        {
            InitializeComponent();
        }
        #region for window back
        public Settings_Name(LogIn loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
        }

        private void Settings_Name_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginWindow.Visible = true;
        }
        #endregion

        private void Button_UpdateConnectionStringDB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = TextBox_ConnectionStringDB.Text;
            Properties.Settings.Default.Save();
        }

        private void Settings_Name_Load(object sender, EventArgs e)
        {
            TextBox_ConnectionStringDB.Text = Properties.Settings.Default.ConnectionString;
            textBox_DatabaseName.Text = Properties.Settings.Default.DBName;
        }

        private void buttonUP_DatabaseName_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBName = textBox_DatabaseName.Text;
            Properties.Settings.Default.Save();
        }

        private void button_UpdateAll_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = TextBox_ConnectionStringDB.Text;
            Properties.Settings.Default.DBName = textBox_DatabaseName.Text;
        }
    }
}
