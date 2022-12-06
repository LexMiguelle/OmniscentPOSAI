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

        String percentValue;
        String discountPercentageString;
        Double discountPercentageDouble;
        int discountPercentageInt;

        public form_addDiscount(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }
        
        // get variables
        public void getDiscountPercentage()
        {
            discountPercentageString = tb_wholeNum.Text + tb_dot.Text + tb_decNum.Text;
            discountPercentageDouble = Convert.ToDouble(discountPercentageString);
            discountPercentageInt = Convert.ToInt32(discountPercentageDouble * 100);
            percentValue = Convert.ToString(discountPercentageInt);
        }

        private void getDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            if (tb_wholeNum.Text == "1")
            {
                tb_decNum.Text = "00";
                tb_decNum.Enabled = false;

            }
            else
            {
                tb_decNum.Enabled = true;
            }

            getDiscountPercentage();
            tb_percentValue.Text = percentValue.ToString() + "%";
            double disc = double.Parse(tb_price.Text) * discountPercentageDouble;
            tb_discountedPrice.Text = disc.ToString("#,##0.00");
        }

        // confirm button event
        private void btn_confirmDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_percentValue.Text == "0%")
                {
                    MessageBox.Show("No discount will be added to the selected product", "Add Discount:Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Dispose();
                }
                else
                {
                    if (MessageBox.Show("Add discount to the product?", "Add Discount: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void tb_wholeNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == (char)48 || e.KeyChar == (char)49)
                {
                    // Do nothing
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_decNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
