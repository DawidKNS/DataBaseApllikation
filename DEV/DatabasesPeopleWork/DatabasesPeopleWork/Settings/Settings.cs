using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabasesPeopleWork;

namespace DatabasesPeopleWork.Settings
{
    public partial class Settings_Name : Form
    {
        LogIn LoginWindow;
        public Settings_Name()
        {
            InitializeComponent();
        }

        public Settings_Name(LogIn loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
        }

        private void Settings_Name_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginWindow.Visible = true;
        }
    }
}
