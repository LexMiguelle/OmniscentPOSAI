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
    public partial class form_settleTransaction : Form
    {
        
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();

        module_cashier cashierModule;

        public form_settleTransaction(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;

            transactionNo.Text = cashierModule.transactionNo.Text;
        }

        // load form_settleTransaction
        private void form_settleTransaction_Load(object sender, EventArgs e)
        {
            tb_amountPaid.Focus();
        }

        // settle transaction trigger
        private void tb_amountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double amountTotal = double.Parse(tb_totalAmount.Text);
                double amountPaid = double.Parse(tb_amountPaid.Text);
                double change = amountPaid - amountTotal;
                tb_change.Text = change.ToString("#,##0.00");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_change.Text = "0.00";
            }
        }

        // number button events
        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_0.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_1.Text;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_9.Text;
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Text += btn_00.Text;
        }

        // dot button event
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!tb_amountPaid.Text.Contains("."))
            {
                tb_amountPaid.Text = tb_amountPaid.Text + btn_dot.Text;
            }
        }

        // delete button event
        private void btn_deleteLast_Click(object sender, EventArgs e)
        {
            if (tb_amountPaid.Text.Length > 0)
            {
                tb_amountPaid.Text = tb_amountPaid.Text.Remove(tb_amountPaid.Text.Length - 1, 1);
            }
        }

        // clear button event
        private void btn_clearAmountPaid_Click(object sender, EventArgs e)
        {
            tb_amountPaid.Clear();
        }

        // enter button event
        private void btn_enterSettleTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if ((double.Parse(tb_change.Text) < 0) || (tb_amountPaid.Text == String.Empty))
                {
                    MessageBox.Show("Invalid input. Please input the correct amount", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int x = 0; x < cashierModule.dgv_cart.Rows.Count; x++)
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_products SET quantity = quantity - " + int.Parse(cashierModule.dgv_cart.Rows[x].Cells[7].Value.ToString()) + " WHERE productID = '" + cashierModule.dgv_cart.Rows[x].Cells[3].Value.ToString() + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();

                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_transaction SET status = 'Sold' WHERE transactionID LIKE '" + cashierModule.dgv_cart.Rows[x].Cells[1].Value.ToString() + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                    }

                    printPreview_receipt receipt = new printPreview_receipt(cashierModule);
                    receipt.LoadReport(tb_amountPaid.Text, tb_change.Text);
                    receipt.ShowDialog();

                    MessageBox.Show("Transaction settled successfully", "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cashierModule.getTransactionNo();
                    cashierModule.LoadCart();
                    this.Dispose();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Settle Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // exit button event
        private void btn_exitSettleTransaction_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // tb_amountPaid limit
        private void tb_amountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}