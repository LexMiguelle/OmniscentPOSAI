using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class form_voidCode : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        form_cancelOrder cancelOrderForm;

        public form_voidCode(form_cancelOrder cancelOrder)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());

            cancelOrderForm = cancelOrder;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_voidCode.Text) || string.IsNullOrEmpty(tb_voidBy.Text))
            {
                MessageBox.Show("One or more textboxes are empty.\nPlease fill them out in order to proceed", "Void Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool hasRows = false;
                string voidCode = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_users WHERE username = @username AND role NOT LIKE 'cashier'", sql_connect);
                sql_command.Parameters.AddWithValue("@username", tb_voidBy.Text);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();
                
                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    voidCode = sql_datareader["voidCode"].ToString();
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    if (tb_voidCode.Text == voidCode)
                    {
                        cancelOrder();

                        if (cancelOrderForm.cb_action.Text == "Return to Inventory")
                        {
                            returnToInventory();
                            updateQuantity();
                        }

                        MessageBox.Show("Sales transaction has been successfully cancelled", "Void Code: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        cancelOrderForm.Dispose();
                        cancelOrderForm.reloadSales();
                    }
                    else
                    {
                        MessageBox.Show("Please try again", "Void Code: Wrong Code", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        tb_voidCode.Clear();
                        return;
                    }
                } 
                else
                {
                    MessageBox.Show("The input username must belong to an administrator or a manager", "Void Code: Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
        }
        
        public void cancelOrder()
        {
            double total = double.Parse(cancelOrderForm.tb_price.Text) * double.Parse(cancelOrderForm.tb_cancelQuantity.Text);

            sql_connect.Open();
            sql_command = new SqlCommand("INSERT INTO tbl_cancelTransaction (transactionNo, productID, price, quantity, total, cancelDate, voidBy, cancelledBy, action, remarks) VALUES (@transactionNo, @productID, @price, @quantity, @total, @cancelDate, @voidBy, @cancelledBy, @action, @remarks)", sql_connect);
            sql_command.Parameters.AddWithValue("@transactionNo", cancelOrderForm.tb_transactionNo.Text);
            sql_command.Parameters.AddWithValue("@productID", cancelOrderForm.tb_productID.Text);
            sql_command.Parameters.AddWithValue("@price", double.Parse(cancelOrderForm.tb_price.Text));
            sql_command.Parameters.AddWithValue("@quantity", int.Parse(cancelOrderForm.tb_cancelQuantity.Text));
            sql_command.Parameters.AddWithValue("@total", total);
            sql_command.Parameters.AddWithValue("@cancelDate", DateTime.Now);
            sql_command.Parameters.AddWithValue("@voidBy", tb_voidBy.Text);
            sql_command.Parameters.AddWithValue("@cancelledBy", cancelOrderForm.tb_cancelledBy.Text);
            sql_command.Parameters.AddWithValue("@action", cancelOrderForm.cb_action.Text);
            sql_command.Parameters.AddWithValue("@remarks", cancelOrderForm.tb_remarks.Text);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        public void returnToInventory()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_products SET quantity = quantity + " + int.Parse(cancelOrderForm.tb_cancelQuantity.Text) + " WHERE productID = '" + cancelOrderForm.tb_productID.Text + "'", sql_connect);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        public void updateQuantity() 
        {
            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = quantity - " + int.Parse(cancelOrderForm.tb_cancelQuantity.Text) + " WHERE transactionID LIKE '" + cancelOrderForm.transactionID.Text + "'", sql_connect);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        private void btn_voidCodeClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tb_voidCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_voidBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
