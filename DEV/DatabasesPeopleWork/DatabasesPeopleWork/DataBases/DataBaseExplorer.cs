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
    public partial class DataBaseExplorer : Form
    {
        LogIn LoginWindow;
        public DataBaseExplorer()
        {
            InitializeComponent();
        }

        public DataBaseExplorer(LogIn loginWindow)
        {
            InitializeComponent();
            LoginWindow = loginWindow;
        }

        private void DataBaseExplorer_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginWindow.Visible = true;
        }
    }
}
