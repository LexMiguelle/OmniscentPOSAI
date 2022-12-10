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
        public void addStockQuantity()
        {
            if (string.IsNullOrWhiteSpace(tb_addStockQuantity.Text) || int.Parse(tb_addStockQuantity.Text) == 0)
            {
                MessageBox.Show("The input cannot be empty nor 0", "Add Stock Quantity: Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sql_connect.Open();
                sql_command = new SqlCommand("INSERT INTO tbl_addStock (referenceNo, productID, stockDate, quantity, stockedBy) VALUES (@referenceNo, @productID, @stockDate, @quantity, @stockedBy)", sql_connect);
                sql_command.Parameters.AddWithValue("@referenceNo", stocksModule.tb_referenceNo.Text);
                sql_command.Parameters.AddWithValue("@productID", ID.Text);
                sql_command.Parameters.AddWithValue("@stockDate", stocksModule.dtp_date.Value);
                sql_command.Parameters.AddWithValue("@quantity", tb_addStockQuantity.Text);
                sql_command.Parameters.AddWithValue("@stockedBy", stocksModule.user.Text);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();
                stocksModule.LoadAddStock();
                MessageBox.Show("Product added to list", "Add Stock: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    addStockQuantity();
                }
            }
        }

        // OK button event
        private void btn_OK_Click(object sender, EventArgs e)
        {
            addStockQuantity();
        }

        // close button event
        private void btn_closeAddQuantity_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
