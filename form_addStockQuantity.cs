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
    public partial class form_addStockQuantity : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_stocks stocksModule;


        public form_addStockQuantity(module_stocks stocks)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            stocksModule = stocks;
        }

        // addQuantity function
        public void addQuantity()
        {
            
        }

        // tb_addQuantity key pressed event
        private void tb_addQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if ((e.KeyChar == 13))
                {
                    addQuantity();
                }
            }
        }

            // OK button event
            private void btn_OK_Click(object sender, EventArgs e)
        {
            addQuantity();
        }

        // close button event
        private void btn_closeAddQuantity_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
