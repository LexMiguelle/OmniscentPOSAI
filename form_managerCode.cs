using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class form_managerCode : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        public form_managerCode()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Action Granted", "Manager Authorization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void btn_closeManagerCode_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
