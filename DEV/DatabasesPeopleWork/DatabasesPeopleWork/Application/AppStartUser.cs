using System;
using System.Windows.Forms;

namespace DatabasesPeopleWork.DataBases
{
    public partial class User_Window : Form
    {
        LogIn LoginWindow;

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
