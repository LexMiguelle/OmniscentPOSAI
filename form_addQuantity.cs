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
    public partial class form_addQuantity : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_cashier cashierModule;

        private string productID;
        private string transactionNo;
        private double price;
        private int quantity;

        public form_addQuantity(module_cashier cashier)
        {
            InitializeComponent();
            db_connect = new DBConnector();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }

        // productDetails function
        public void productDetails(String productID, double price, String transactionNo, int quantity)
        {
            this.productID = productID;
            this.transactionNo = transactionNo;
            this.price = price;
            this.quantity = quantity;
        }

        // addQuantity function
        public void addQuantity()
        {
            if ((string.IsNullOrEmpty(tb_addQuantity.Text) || tb_addQuantity.Text == "0"))
            {
                MessageBox.Show("Incorrect input", "Add Quantity: Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_addQuantity.Text = "1";
                tb_addQuantity.Focus();
                tb_addQuantity.SelectAll();
            }
            else
            {
                bool hasRows = false;
                string transactionID = "";
                int transactionQuantity = 0;

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_transaction WHERE transactionNo = @transactionNo AND productID = @productID", sql_connect);
                sql_command.Parameters.AddWithValue("@transactionNo", cashierModule.transactionNo.Text);
                sql_command.Parameters.AddWithValue("@productID", productID);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    transactionID = sql_datareader["transactionID"].ToString();
                    transactionQuantity = int.Parse(sql_datareader["quantity"].ToString());
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    if (quantity < (int.Parse(tb_addQuantity.Text) + transactionQuantity))
                    {
                        MessageBox.Show("The selected product only has " + quantity + " stock(s) on hand", "Add Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        tb_addQuantity.Focus();
                        tb_addQuantity.SelectAll();
                    }
                    else
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = (quantity + " + int.Parse(tb_addQuantity.Text) + ") WHERE transactionID = '" + transactionID + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        this.Dispose();
                    }

                    cashierModule.LoadCart();
                }
                else
                {
                    if (quantity < int.Parse(tb_addQuantity.Text))
                    {
                        MessageBox.Show("The selected product only has " + quantity + " stock(s) on hand", "Add Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                        tb_addQuantity.Focus();
                        tb_addQuantity.SelectAll();
                    }
                    else
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("INSERT INTO tbl_transaction (transactionNo, productID, price, quantity, transactionDate, cashierName) VALUES (@transactionNo, @productID, @price, @quantity, @transactionDate, @cashierName)", sql_connect);
                        sql_command.Parameters.AddWithValue("@transactionNo", transactionNo);
                        sql_command.Parameters.AddWithValue("@productID", productID);
                        sql_command.Parameters.AddWithValue("@price", price);
                        sql_command.Parameters.AddWithValue("@quantity", int.Parse(tb_addQuantity.Text));
                        sql_command.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                        sql_command.Parameters.AddWithValue("@cashierName", cashierModule.tb_name.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        this.Dispose();
                    }

                    cashierModule.LoadCart();
                }
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
