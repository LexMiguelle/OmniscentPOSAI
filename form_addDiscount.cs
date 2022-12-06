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

        String discountPercentage;

        public form_addDiscount(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
            addDot();
        }

        // add dot
        private void addDot()
        {
            if (!tb_decNum.Text.Contains("."))
            {
                tb_decNum.Text += "0.00";
            }
        }

        // tb_discountPercentage text changed event
        private void tb_discountPercentage_TextChanged(object sender, EventArgs e)
        {
            addDot();
            double disc = Double.Parse(tb_price.Text) * Double.Parse(tb_decNum.Text);
            tb_discountedPrice.Text = disc.ToString("#,##0.00");
        }

        // confirm button event
        private void btn_confirmDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount to the product?", "Add Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(tb_decNum.Text) || tb_decNum.Text == "0.00")
                    {
                        MessageBox.Show("Discount Percentage input is empty", "Add Discount: Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
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

        private void tb_wholeNum_TextChanged(object sender, EventArgs e)
        {
            if (tb_wholeNum.Text == "1")
            {
                tb_decNum.Enabled = false;
                tb_decNum.Text = "00";
            }
            else
            {
                tb_decNum.Enabled = true;
            }
        }

        private void tb_wholeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals("1") || !e.KeyChar.Equals("0"))
            {
                e.Handled = true;
            }
        }

        private void tb_decNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void getDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            discountPercentage = tb_wholeNum.Text + tb_dot.Text + tb_decNum.Text;
            Double dp = Convert.ToDouble(discountPercentage);
            int pv = Convert.ToInt32(dp);
            String percent = Convert.ToString(pv);
            tb_percentValue.Text = pv + "%";
        }
    }
}
