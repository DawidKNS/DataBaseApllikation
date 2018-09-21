using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabasesPeopleWork.DataBases
{
    public partial class User_Window : Form
    {
        LogIn LoginWindow;
        public User_Window()
        {
            InitializeComponent();
        }
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
            Data_txt.Text = DateTime.UtcNow.ToLocalTime().ToString();
        }
    }
}
