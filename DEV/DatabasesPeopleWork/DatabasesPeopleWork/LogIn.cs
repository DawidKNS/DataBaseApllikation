using System;
using System.Windows.Forms;
using DatabasesPeopleWork.DataBases;
using DatabasesPeopleWork.Settings;

namespace DatabasesPeopleWork
{
    public partial class LogIn : Form
    {
        public string user;
        public LogIn()
        {
            InitializeComponent();
        }

        public void Button_login_Click(object sender, EventArgs e)
        {
            //connecting to Databases
            DataBaseConnectiong dataBaseConnectiong = new DataBaseConnectiong();
            string user = textBox_User.Text;
            string password = this.textBox_password.Text;

            //check user and password
            if (dataBaseConnectiong.CheckUserPassword(user,password))
            {
                //go to window appstart
                User_Window AppStartDB = new User_Window(this);
                this.Visible = false;
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

        public string User
        {
           get { return user = textBox_User.Text; }
        }
    }
}
