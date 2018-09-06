using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleDatabase
{
    public partial class AppStart : Form
    {
        LogIn Loginhed;
        public AppStart()
        {
            InitializeComponent();
        }

        public AppStart(LogIn loginhedd)
        {
            InitializeComponent();
            Loginhed = loginhedd;
        }

        private void AppStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginhed.Visible = true;
        }
    }
}
