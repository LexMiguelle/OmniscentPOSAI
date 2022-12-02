using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
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
    public partial class module_cashier : Form
    {
        String transactionID;
        String prc;

        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        module_login loginModule;

        public module_cashier(module_login login)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            this.KeyPreview = true;
            btn_addProduct.Enabled = false;
            tb_searchBox.Enabled = false;
            btn_scanBarcode.Enabled = false;
            loginModule = login;
        }

        // logout function
        public void cashierLogout()
        {
            this.Dispose();
            loginModule.Dispose();
        }

        // generate transaction number function
        public void getTransactionNo()
        {
            try
            {
                string transDate = DateTime.Now.ToString("yyyyMMdd");
                string transNo;
                int count;

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT TOP 1 transactionNo FROM tbl_transaction WHERE transactionNo LIKE '" + transDate + "%' ORDER BY transactionID DESC", sql_connect); ;
                sql_datareader = sql_command.ExecuteReader();   
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    transNo = sql_datareader[0].ToString();
                    count = int.Parse(transNo.Substring(8, 4));
                    transactionNo.Text = transDate + (count + 1);
                }
                else
                {
                    transNo = transDate + "1001";
                    transactionNo.Text = transNo;
                }
                sql_datareader.Close();
                sql_connect.Close();

            }

            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Cashier Module", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // getTotal function
        public void getTotal()
        {
            double total = Double.Parse(subTotal.Text);
            double discount = Double.Parse(totalDiscount.Text);
            double vat = total * db_connect.getVAT();
            double vatable = total - vat;
            double amountTotal = total - discount;


            totalAmount.Text = amountTotal.ToString("#,##0.00");
            totalVAT.Text = vat.ToString("#,##0.00");                                                                            
            totalVATable.Text = vatable.ToString("#,##0.00");

        }

        // load contents to cart
        public void LoadCart()
        {
            try
            {
                int i = 0;
                double total = 0;
                double disc = 0;

                dgv_cart.Rows.Clear();
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT x.transactionID, y.productCode, x.productID, y.productName, z.categoryName, x.price, x.quantity, x.discount, x.total FROM tbl_transaction AS x INNER JOIN tbl_products as y ON x.productID = y.productID INNER JOIN tbl_categories as z ON y.categoryID = z.categoryID WHERE transactionNo LIKE '" + transactionNo.Text + "' AND status LIKE 'Pending'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                while (sql_datareader.Read())
                {
                    i++;
                    total += Double.Parse(sql_datareader["total"].ToString());
                    disc += Double.Parse(sql_datareader["discount"].ToString());
                    dgv_cart.Rows.Add(i, sql_datareader["transactionID"].ToString(), sql_datareader["productCode"].ToString(), sql_datareader["productID"].ToString(), sql_datareader["productName"].ToString(), sql_datareader["categoryName"].ToString(), sql_datareader["price"].ToString(), sql_datareader["quantity"].ToString(), sql_datareader["discount"].ToString(), Double.Parse(sql_datareader["total"].ToString()).ToString("#,##0.00"));
                }
                sql_datareader.Close();
                sql_connect.Close();

                subTotal.Text = total.ToString("#,##0.00");
                totalDiscount.Text = disc.ToString("#,##0.00");
                getTotal();
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Cashier Module", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sql_connect.Close();
            }
        }
         
        // new transaction button event
        public void btn_newTransaction_Click(object sender, EventArgs e)
        {
            getTransactionNo();
            transactionDate.Text = DateTime.Now.ToLongDateString();
            btn_newTransaction.Enabled = false;
            btn_addProduct.Enabled = true;
            btn_addDiscount.Enabled = true;
            btn_scanBarcode.Enabled = true;
            btn_clearTransaction.Enabled = true;
        }

        // clear transaction button event
        private void btn_clearTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql_connect.Open();
                sql_command = new SqlCommand("DELETE FROM tbl_transaction WHERE transactionNo LIKE '" + transactionNo.Text + "'", sql_connect);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();
                LoadCart();

                transactionNo.Text = "000000000000";
                transactionDate.Text = "00/00/00";
                btn_newTransaction.Enabled = true;
                btn_clearTransaction.Enabled = false;
                btn_scanBarcode.Enabled = false;
                btn_addProduct.Enabled = false;
                btn_addDiscount.Enabled = false;
                tb_searchBox.Enabled = false;
                btn_settleTransaction.Enabled = false;
                
            }
            else
            {
                return;
            }

        }

        // scan productCode button event
        private void btn_scanBarcode_Click(object sender, EventArgs e)
        {
            tb_searchBox.Enabled = true;
            tb_searchBox.Focus();
            //enable productCode scanner
        }

        // check price button event
        private void btn_checkPrice_Click(object sender, EventArgs e)
        {
            form_checkPrice checkPrice = new form_checkPrice();
            checkPrice.ShowDialog();
        }

        // sales button event
        private void btn_cashierSales_Click(object sender, EventArgs e)
        {
            form_cashierSales cashierSales = new form_cashierSales(this);
            cashierSales.ShowDialog();
        }

        // settings button event
        private void btn_settings_Click(object sender, EventArgs e)
        {
            module_settings settings = new module_settings(this);
            settings.ShowDialog();

        }

        // cart event
        private void dgv_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_cart.Columns[e.ColumnIndex].Name;

            if (col_name == "cart_remove")
            {
                if (MessageBox.Show("Remove from selected product from cart?", "Remove from cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("DELETE FROM tbl_transaction WHERE transactionID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    LoadCart();
                    MessageBox.Show("The selected product has been removed from the cart", "Remove from cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // add product to cart button
        private void btn_addProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (transactionNo.Text == "000000000000")
            {
                return;
            }
            else
            {
                form_addToCart addToCart = new form_addToCart(this);
                addToCart.tb_searchProductList.Focus();
                addToCart.LoadProductList();
                addToCart.ShowDialog();
            }
        }

        // addDiscount button event
        private void btn_addDiscount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_addDiscount addDiscount = new form_addDiscount(this);
            addDiscount.lbl_ID.Text = transactionID;
            addDiscount.tb_price.Text = prc;  
            addDiscount.ShowDialog();
        }

        // tb_searchBox trigger
        private void tb_searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_searchBox.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE productCode LIKE '" + tb_searchBox.Text + "'", sql_connect);
                    sql_datareader = sql_command.ExecuteReader();
                    sql_datareader.Read();
                    if (sql_datareader.HasRows)
                    {
                        form_addQuantity addQuantity = new form_addQuantity(this);
                        addQuantity.productDetails(sql_datareader["productID"].ToString(), double.Parse(sql_datareader["price"].ToString()), transactionNo.Text);
                        sql_datareader.Close();
                        sql_connect.Close();
                        addQuantity.ShowDialog();
                    }
                    else
                    {
                        sql_datareader.Close();
                        sql_connect.Close();
                    }

                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Cashier Module", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // time ticker
        private void timer_clock_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        // Enable btn_settleTransaction trigger
        private void dgv_cart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_settleTransaction.Enabled = true;
        }

        // settle transaction button
        private void btn_settleTransaction_Click(object sender, EventArgs e)
        {
            form_settleTransaction settleTransaction = new form_settleTransaction(this);
            settleTransaction.tb_totalAmount.Text = totalAmount.Text;
            settleTransaction.ShowDialog();
        }

        // dgv_cart selection changed event
        private void dgv_cart_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgv_cart.CurrentRow.Index;
            transactionID = dgv_cart[1, i].Value.ToString();
            prc = dgv_cart[6, i].Value.ToString();
        }

        // close button event
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the application without logging out?", "Omniscent: Point of Sale System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                loginModule.Dispose();
            }
            else
            {
                return;
            }
        }
    }
}
            
