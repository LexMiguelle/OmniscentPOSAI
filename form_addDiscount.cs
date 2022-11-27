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
    public partial class form_addDiscount : Form
    {

        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;
        module_cashier cashierModule;

        public form_addDiscount(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;

        }
        
        // tb_discountPercentage text changed event
        private void tb_discountPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discountedPrice = Double.Parse(tb_price.Text) * Double.Parse(tb_discountPercentage.Text);
                tb_discountedPrice.Text = discountedPrice.ToString("#,##0.00");
            }
            catch (Exception except)
            {

                MessageBox.Show(except.Message, "Add Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // confirm button event
        private void btn_confirmDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount to the product?", "Add Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("UPDATE tbl_transaction SET discount = @discount WHERE transactionID = @transactionID", sql_connect);
                    sql_command.Parameters.AddWithValue("@discount", Double.Parse(tb_discountedPrice.Text));
                    sql_command.Parameters.AddWithValue("@transactionID", int.Parse(lbl_ID.Text));
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    cashierModule.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Add Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // close button event
        private void btn_closeAddDiscount_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
