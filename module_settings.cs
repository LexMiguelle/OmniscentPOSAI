using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class module_settings : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        module_cashier cashierModule;

        public module_settings(module_cashier cashier)
        {
            InitializeComponent();
            cashierModule = cashier;
        }

        // closeCashier function
        public void closeCashier()
        {
            Application.Exit();
            Application.Run(new module_login());
        }

        // update button event
        private void btn_updatePassword_Click(object sender, EventArgs e)
        {

        }

        // back button event
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // close button event
        private void btn_closeSettings_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // logout button event
        private void btn_settingsLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            cashierModule.cashierLogout();
        }
    }
}