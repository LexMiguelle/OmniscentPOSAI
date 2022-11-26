using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OmniscentPOSAI
{
    public partial class module_admin : Form
    {
        SqlConnection sqlConnect = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DBConnector dbConnect = new DBConnector();
        public module_admin()
        {
            InitializeComponent();
            sqlConnect = new SqlConnection(dbConnect.DBConnection());
            sqlConnect.Open();
            MessageBox.Show("Database Connected");
            sqlConnect.Close();
        }

        private void module_admin_Load(object sender, EventArgs e)
        {

        
        }
    }
}
