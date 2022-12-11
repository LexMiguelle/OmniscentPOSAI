using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Tulpep.NotificationWindow;

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
        module_inventory inventoryModule;

        int quantity;
        private module_cashier cashierModule;


        // init
        public module_cashier(module_login login)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            this.KeyPreview = true;
            btn_addProduct.Enabled = false;
            tb_searchBox.Enabled = false;
            btn_scanProductCode.Enabled = false;
            loginModule = login;
            notifyCriticalItems();
        }

        public module_cashier(module_inventory inventory)
        {
            inventoryModule = inventory;
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            this.tb_name.Text = inventoryModule.tb_name.Text;
            this.tb_username.Text = inventoryModule.tb_username.Text;
            this.tb_role.Text = inventoryModule.tb_role.Text;
        }

        public void getInfo(String name, String role, String username)
        {
            name = tb_name.Text;
            role = tb_role.Text;
            username = tb_role.Text;

        }

        public void notifyCriticalItems()
        {
            int i = 0;
            string critical = "";
            string count = "";

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT count(*) FROM view_criticalStocks", sql_connect);
            count = sql_command.ExecuteScalar().ToString();
            sql_connect.Close();

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_criticalStocks", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                critical += i + ". " + sql_datareader["productName"].ToString() + " (" + sql_datareader["categoryName"].ToString() + ")" + Environment.NewLine;
            }
            sql_datareader.Close();
            sql_connect.Close();

            PopupNotifier popUp = new PopupNotifier();
            popUp.Image = Properties.Resources.warning_24;
            popUp.TitleText = count + " CRITICAL ITEM(S):";
            popUp.ContentText = critical;
            popUp.Popup();
        }

        // logout function
        public void cashierLogout()
        {
            this.Dispose();
            loginModule.Show();
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
            btn_scanProductCode.Enabled = true;
            btn_clearTransaction.Enabled = true;
        }

        // clear transaction function
        public void clearTransaction()
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
            btn_scanProductCode.Enabled = false;
            btn_addProduct.Enabled = false;
            btn_addDiscount.Enabled = false;
            tb_searchBox.Enabled = false;
            tb_quantity.Enabled = false;
            btn_settleTransaction.Enabled = false;
        }

        // clear transaction button event
        private void btn_clearTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel this transaction?", "Cancel Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearTransaction();
            }
            else
            {
                return;
            }
        }

        // scan productCode button event
        private void btn_scanBarcode_Click(object sender, EventArgs e)
        {
            tb_quantity.Enabled = true;
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
            cashierSales.LoadCashierSales();
            cashierSales.ShowDialog();
            
        }

        // settings button event
        private void btn_settings_Click(object sender, EventArgs e)
        {
            module_settings settings = new module_settings(this);
            settings.tb_userName.Text = tb_username.Text;
            settings.ShowDialog();

        }

        // cart event
        private void dgv_cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_cart.Columns[e.ColumnIndex].Name;

            if (col_name == "cart_add") //add
            {
                int i = 0; 
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT sum(quantity) AS quantity FROM tbl_products WHERE productID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[3].Value.ToString() + "' GROUP BY productID", sql_connect);
                i = int.Parse(sql_command.ExecuteScalar().ToString());
                sql_connect.Close();

                if ( int.Parse(dgv_cart.Rows[e.RowIndex].Cells[7].Value.ToString()) < i)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = quantity + 1 WHERE transactionNo LIKE '" + transactionNo.Text + "' AND productID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("The selected product has only " + i + " stock(s) left in the inventory", "Add Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (col_name == "cart_subtract") // subtract
            {
                int i = 0;
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT sum(quantity) AS quantity FROM tbl_transaction WHERE productID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[3].Value.ToString() + "' AND transactionNo LIKE '" + transactionNo.Text + "' GROUP BY transactionNo, productID", sql_connect);
                i = int.Parse(sql_command.ExecuteScalar().ToString());
                sql_connect.Close();

                if (i > 1)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = quantity - 1 WHERE transactionNo LIKE '" + transactionNo.Text + "' AND productID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();

                    LoadCart();
                }
                else
                {
                    MessageBox.Show("The selected product has only " + i + " stock left in the cart", "Subtract Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_searchBox.Clear();
                }
            }
            else if (col_name == "cart_remove") // remove
            {
                if (MessageBox.Show("Remove from selected product from cart?", "Remove from cart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("DELETE FROM tbl_transaction WHERE transactionID LIKE '" + dgv_cart.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    LoadCart();
                    MessageBox.Show("The selected product has been removed from the cart", "Remove from cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_searchBox.Clear();
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
            addDiscount.tb_wholeNum.Focus();
            addDiscount.tb_wholeNum.SelectAll();
            addDiscount.tb_price.Text = prc;  
            addDiscount.ShowDialog();
        }

        // add quantity
        public void addQuantity(string _productID, double _price, int _quantity)
        {
            bool hasRows = false;
            int transactionQuantity = 0;

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_transaction WHERE transactionNo = @transactionNo AND productID = @productID", sql_connect);
            sql_command.Parameters.AddWithValue("@transactionNo", transactionNo.Text);
            sql_command.Parameters.AddWithValue("@productID", _productID);
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
                if (quantity < (int.Parse(tb_quantity.Text) + transactionQuantity))
                {
                    MessageBox.Show("Unable to process request.\nThe selected product has " + quantity + " stock(s) on hand", "Add Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql_connect.Open();
                sql_command = new SqlCommand("UPDATE tbl_transaction SET quantity = (quantity + " + int.Parse(tb_quantity.Text) + ") WHERE transactionID = '" + transactionID + "'", sql_connect);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                tb_searchBox.Clear();
                tb_searchBox.Focus();
                LoadCart();
            }
            else
            {
                if (quantity < int.Parse(tb_quantity.Text))
                {
                    MessageBox.Show("Unable to process request.\nThe selected product has " + quantity + " stock(s) on hand", "Add Quantity: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql_connect.Open();
                sql_command = new SqlCommand("INSERT INTO tbl_transaction (transactionNo, productID, price, quantity, transactionDate, cashierName) VALUES (@transactionNo, @productID, @price, @quantity, @transactionDate, @cashierName)", sql_connect);
                sql_command.Parameters.AddWithValue("@transactionNo", transactionNo.Text);
                sql_command.Parameters.AddWithValue("@productID", _productID);
                sql_command.Parameters.AddWithValue("@price", _price);
                sql_command.Parameters.AddWithValue("@quantity", _quantity);
                sql_command.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                sql_command.Parameters.AddWithValue("@cashierName", tb_name.Text);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                tb_searchBox.Clear();
                tb_searchBox.Focus();
                LoadCart();
            }
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
                    String _productID;
                    double _price;
                    int _quantity;

                    sql_connect.Open();
                    sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE productCode LIKE '" + tb_searchBox.Text + "'", sql_connect);
                    sql_datareader = sql_command.ExecuteReader();
                    sql_datareader.Read();
                    if (sql_datareader.HasRows)
                    {
                        quantity = int.Parse(sql_datareader["quantity"].ToString());
                        //form_addQuantity addQuantity = new form_addQuantity(this);
                        //addQuantity.productDetails(sql_datareader["productID"].ToString(), double.Parse(sql_datareader["price"].ToString()), transactionNo.Text, quantity);
                        _productID = sql_datareader["productID"].ToString();
                        _price = double.Parse(sql_datareader["price"].ToString());
                        _quantity = int.Parse(tb_quantity.Text);
                        sql_datareader.Close();
                        sql_connect.Close();

                        addQuantity(_productID, _price, _quantity);
                        //addQuantity.ShowDialog();
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

        // Rows Added event
        private void dgv_cart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btn_settleTransaction.Enabled = true;
            btn_addDiscount.Enabled = true;
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
            prc = dgv_cart[9, i].Value.ToString();
        }

        // close button event
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the application without logging out?\nClosing the application will cancel the current transaction.", "Omniscent: Point of Sale System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clearTransaction();
                this.Dispose();
                loginModule.Dispose();
            }
            else
            {
                return;
            }
        }

        public void LoadInvoice()
        {
            
            ReportDataSource reportDataSource;

            try
            {
                rv_invoice.Clear();
                int height = 1000;
                this.rv_invoice.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_invoice.rdlc";
                this.rv_invoice.LocalReport.DataSources.Clear();

                DataSet1 dataset = new DataSet1();
                SqlDataAdapter sql_dataadapter = new SqlDataAdapter();

                sql_connect.Open();
                sql_dataadapter.SelectCommand = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, x.price, x.quantity, x.discount, x.total, x.transactionDate, y.productName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE transactionNo LIKE '" + transactionNo.Text + "'", sql_connect);
                sql_dataadapter.Fill(dataset.Tables["dt_sold"]);
                sql_connect.Close();

                ReportParameter rp_cashierName = new ReportParameter("rp_cashierName", tb_name.Text);
                ReportParameter rp_invoiceNo = new ReportParameter("rp_invoiceNo", transactionNo.Text);
                ReportParameter rp_totalAmount = new ReportParameter("rp_totalAmount", totalAmount.Text);

                rv_invoice.LocalReport.SetParameters(rp_cashierName);
                rv_invoice.LocalReport.SetParameters(rp_invoiceNo);
                rv_invoice.LocalReport.SetParameters(rp_totalAmount);

                reportDataSource = new ReportDataSource("DataSet1", dataset.Tables["dt_sold"]);
                rv_invoice.LocalReport.DataSources.Add(reportDataSource);
                rv_invoice.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1100, height);
                rv_invoice.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rv_invoice.ZoomMode = ZoomMode.Percent;
                rv_invoice.ZoomPercent = 80;
                rv_invoice.RefreshReport();
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message);
            }
        }

        private void totalAmount_TextChanged(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        private void tb_searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tb_role.Text != "cashier")
            {
                this.Dispose();
                inventoryModule.Show();
            }
            
            
        }
    }
}
            
