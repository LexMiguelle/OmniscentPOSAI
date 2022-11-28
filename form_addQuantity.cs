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

        public form_addQuantity(module_cashier cashier)
        {
            InitializeComponent();
            db_connect = new DBConnector();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }

        // productDetails function
        public void productDetails(String productID, double price, String transactionNo)
        {
            this.productID = productID;
            this.transactionNo = transactionNo;
            this.price = price;
        }

        // tb_addQuantity key pressed event
        private void tb_addQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (tb_addQuantity.Text != String.Empty))
            {
                bool hasRows = false;
                string transactionID = "";

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
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = (quantity + " + int.Parse(tb_addQuantity.Text) + ") WHERE transactionID = '" + transactionID + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();

                    cashierModule.tb_searchBox.Clear();
                    cashierModule.tb_searchBox.Focus();
                    cashierModule.LoadCart();
                    this.Dispose();
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

                    cashierModule.tb_searchBox.Clear();
                    cashierModule.tb_searchBox.Focus();
                    cashierModule.LoadCart();
                    this.Dispose();
                }
                
            }
        }

        // OK button event
        private void btn_OK_Click(object sender, EventArgs e)
        {
            bool hasRows = false;
            string transactionID = "";

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
            }
            else
            {
                hasRows = false;
            }
            sql_datareader.Close();
            sql_connect.Close();

            if (hasRows == true)
            {
                sql_connect.Open();
                sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = (quantity + " + int.Parse(tb_addQuantity.Text) + ") WHERE transactionID = '" + transactionID + "'", sql_connect);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                cashierModule.tb_searchBox.Clear();
                cashierModule.tb_searchBox.Focus();
                cashierModule.LoadCart();
                this.Dispose();
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

                cashierModule.tb_searchBox.Clear();
                cashierModule.tb_searchBox.Focus();
                cashierModule.LoadCart();
                this.Dispose();
            }
        }

        // close button event
        private void btn_closeAddQuantity_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
