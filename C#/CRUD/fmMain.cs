using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace CRUD
{
    public partial class fmMain : Form
    {

        int ConnectResult;

        public fmMain()
        {
            InitializeComponent();
        }

        private void btnConnectToDB_Click(object sender, EventArgs e)
        {
            ConnectResult = DB.DBFunctions.DBConnection("initial db", "ip or name sql server", "username", "password");

            if (ConnectResult == 1) { MessageBox.Show("DB connected!"); } else { MessageBox.Show("Connections errors"); };
        }

    }
}
