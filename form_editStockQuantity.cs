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
    public partial class form_editStockQuantity : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_stocks stocksModule;


        public form_editStockQuantity(module_stocks stocks)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            stocksModule = stocks;
        }

        // editQuantity function
        public void editStockQuantity()
        {
            if (string.IsNullOrWhiteSpace(tb_editStockQuantity.Text) || int.Parse(tb_editStockQuantity.Text) == 0)
            {
                MessageBox.Show("The input cannot be empty nor 0", "Add Stock Quantity: Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sql_connect.Open();
                sql_command = new SqlCommand("UPDATE tbl_addStock SET quantity = " + tb_editStockQuantity.Text + " WHERE ID = '" + ID.Text + "'", sql_connect);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                stocksModule.LoadAddStock();
                MessageBox.Show("The desired quantity has been added to the product in the stock list");
                this.Dispose();
            }
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
                    editStockQuantity();
                }
            }
        }

        // OK button event
        private void btn_OK_Click(object sender, EventArgs e)
        {
            editStockQuantity();
        }

        // close button event
        private void btn_closeAddQuantity_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
