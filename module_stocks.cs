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
    public partial class module_stocks : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        int _quantity = 0;
        string productID = string.Empty;
        String addStockID = "";
        String quantity = "";

        public module_stocks()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            this.KeyPreview = true;
        }


        private void module_stocks_Load(object sender, EventArgs e)
        {
            LoadStocks();
            LoadAddProducts();
            cb_status.Text = "Done";
        }

        // Stock Overview tab
        // Load Stocks
        public void LoadStocks()
        {
            int i = 0;
            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");
            string status = cb_status.Text;

            dgv_stockOverview.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_stockOverview WHERE stockDate BETWEEN '" + dateMin + "' AND '" + dateMax + "' AND status LIKE '" + status + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            sql_datareader.Read();
            while (sql_datareader.Read())
            {
                i++;
                dgv_stockOverview.Rows.Add(i, sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // cb_status value changed
        private void cb_status_TextChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        // dtp_from value changed
        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        // dtp_to value changed
        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            LoadStocks();
        }

        // tp_addStock
        // load products to dgv_addProducts
        public void LoadAddProducts()
        {
            int i = 0;
            dgv_addProducts.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID, productName, quantity FROM tbl_products WHERE productname LIKE '%" + tb_searchBar.Text + "%' ORDER BY productName", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_addProducts.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // tb_referenceNo text changed event
        private void tb_referenceNo_TextChanged(object sender, EventArgs e)
        {
            LoadAddProducts();
        }

        // load stocks to dgv_addStocks
        public void LoadAddStock()
        {
            int i = 0;
            dgv_addStocks.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_addStock WHERE referenceNo LIKE '" + tb_referenceNo.Text + "' AND status LIKE 'Pending'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_addStocks.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }
        private void dgv_addProducts_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgv_addProducts.CurrentRow.Index;
            productID = dgv_addProducts[1, i].Value.ToString();
            lbl_pid.Text = productID;
        }


        // dgv_addProducts click event
        private void dgv_addProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool hasRows = false;
            string col_name = dgv_addProducts.Columns[e.ColumnIndex].Name;
            

            if (tb_referenceNo.Text == string.Empty)
            {
                MessageBox.Show("Reference number is missing", "Stocks: Missing Reference No.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_generate.Focus();
                return;
            }

            if (col_name == "addProducts_add") // addProducts_add event
            {
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * from tbl_addStock WHERE referenceNo LIKE '" + tb_referenceNo.Text + "' AND productID LIKE '" + productID + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                while (sql_datareader.Read())
                {
                    if (sql_datareader.HasRows)
                    {
                        hasRows = true;
                    }
                    else
                    {
                        hasRows = false;
                    }
                }
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("The selected product has already been added.", "Add Stock: Products", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    form_addStockQuantity addStockQuantity = new form_addStockQuantity(this);
                    addStockQuantity.ID.Text = productID;
                    addStockQuantity.ShowDialog();
                }
            }
        }

        // dgv_addStocks click event
        private void dgv_addStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_addStocks.Columns[e.ColumnIndex].Name;
            if (col_name == "addStocks_remove") // addStocks_remove event
            {
                if (MessageBox.Show("Remove selected product from the list?", "Remove Stock: Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("DELETE FROM tbl_addStock WHERE ID = '" + dgv_addStocks.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();

                    MessageBox.Show("Product removed from list", "Stocks: Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAddStock();
                }
            }
            else if (col_name == "addStocks_quantity") // add quantity
            {
                form_editStockQuantity editStockQuantity = new form_editStockQuantity(this);
                editStockQuantity.ID.Text = addStockID.ToString();
                editStockQuantity.tb_editStockQuantity.Text = quantity;
                editStockQuantity.ShowDialog();
            }
        }

        // reset function
        public void Reset()
        {
            tb_referenceNo.Clear();
        }

        // generate button event
        private void btn_generate_Click(object sender, EventArgs e)
        {
            tb_referenceNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            btn_generate.Hide();
            btn_clear.Enabled = true;
            btn_save.Enabled = true;
            btn_editStockQuantity.Enabled = true;
        }

        // clear button event
        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to clear the added products?", "Clear Products", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgv_addStocks.Rows.Clear();

                sql_connect.Open();
                sql_command = new SqlCommand("DELETE FROM tbl_addStock WHERE referenceNo LIKE '" + tb_referenceNo.Text + "'", sql_connect);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                MessageBox.Show("All products cleared", "Clear Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAddStock();
                btn_editStockQuantity.Enabled = false;
            }
        }

        // save button event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_addStocks.Rows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to save this list?", "Add Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int x = 0; x < dgv_addStocks.Rows.Count; x++)
                        {
                            sql_connect.Open();
                            sql_command = new SqlCommand("UPDATE tbl_products SET quantity = quantity + '" + int.Parse(dgv_addStocks.Rows[x].Cells[5].Value.ToString()) + "' WHERE productID LIKE '" + dgv_addStocks.Rows[x].Cells[3].Value.ToString() + "'", sql_connect);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();

                            sql_connect.Open();
                            sql_command = new SqlCommand("UPDATE tbl_addStock SET quantity = quantity + '" + int.Parse(dgv_addStocks.Rows[x].Cells[5].Value.ToString()) + "', status = 'Done' WHERE ID LIKE '" + dgv_addStocks.Rows[x].Cells[1].Value.ToString() + "'", sql_connect);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();
                        }
                    }
                    LoadAddProducts();
                    LoadAddStock();
                    tb_referenceNo.Clear();
                    btn_generate.Show();
                    btn_clear.Enabled = false;
                    MessageBox.Show("The selected stocks has been added into the inventory", "Stocks Module: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The stock table does not contain any rows.", "Add Stock: Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Add Stock: ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        // tp_manageStock
        // load stocks to tp_manageStocks
        public void LoadManageStocks()
        {
            int i = 0;
            dgv_manageStocks.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.productID, x.productCode, x.productName, y.categoryName, x.price, x.quantity FROM tbl_products AS x INNER JOIN tbl_categories AS y ON y.categoryID = x.categoryID WHERE x.productName LIKE '%" + tb_searchBar.Text + "' ORDER BY x.productName", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_manageStocks.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }


        // tb_refNo function
        public void referenceNo()
        {
            tb_refNo.Text = DateTime.Now.ToString("MMddyyyyHHmmss");
        }

        // tb_searchBar 'Enter' keypress event
        private void tb_searchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                LoadManageStocks();
                referenceNo();
            }
        }

        // dgv_manageStocks event
        private void dgv_manageStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_manageStocks.Columns[e.ColumnIndex].Name;
            if (col_name == "manageStocks_select")
            {
                tb_productID.Text = dgv_manageStocks.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_productName.Text = dgv_manageStocks.Rows[e.RowIndex].Cells[3].Value.ToString();
                _quantity = int.Parse(dgv_manageStocks.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
        }

        // reset textboxes function
        public void resetTextboxes()
        {
            tb_productID.Clear();
            tb_productName.Clear();
            tb_quantity.Clear();
            cb_action.Text = "";
            tb_stockRemarks.Clear();
        }

        // clear textboxes button event
        private void btn_clearTextboxes_Click(object sender, EventArgs e)
        {
            resetTextboxes();
        }


        // confirm button event
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tb_quantity.Text) > _quantity)
                {
                    MessageBox.Show("Stock quantity should be greater than the modified quantity", "Manage Stocks: WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cb_action.Text == "Add to Inventory")
                {
                    SqlStatement ("UPDATE tbl_products SET quantity = (quantity + " + int.Parse(tb_quantity.Text) + ") WHERE productID LIKE '" + tb_productID.Text + "'");
                }
                else if(cb_action.Text == "Remove from Inventory")
                {
                    SqlStatement("UPDATE tbl_products SET quantity = (quantity - " + int.Parse(tb_quantity.Text) + ") WHERE productID LIKE '" + tb_productID.Text + "'");
                }
                
                SqlStatement ("INSERT INTO tbl_manageStocks(referenceNo, productID, quantity, action, remarks, stockDate) VALUES ('" + tb_refNo.Text + "','" + tb_productID.Text + "','" + int.Parse(tb_quantity.Text) + "','" + cb_action.Text + "','" + tb_stockRemarks.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                MessageBox.Show("Stocks have been successfully modified", "Manage Stocks", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadManageStocks();
                resetTextboxes();
                referenceNo();

            } catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Manage Stocks: WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SqlStatement(string _sql)
        {
            sql_connect.Open();
            sql_command = new SqlCommand(_sql, sql_connect);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        private void tb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_addStocks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_addStocks.Rows.Count; i++)
            {
                if (int.Parse(dgv_addStocks.Rows[i].Cells[5].Value.ToString()) == 0)
                {
                    MessageBox.Show("NO ZERO");
                    return;
                }
                else if (dgv_addStocks.Rows[i].Cells[5].Value.ToString() == "")
                {
                    MessageBox.Show("EMPTY");
                    return;
                } else if (dgv_addStocks.Rows[i].Cells[5].Value.ToString() == null)
                {
                    MessageBox.Show("NULL");
                }
                cid.Text = dgv_addStocks.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void dgv_addStocks_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgv_addStocks.CurrentRow.Index;
            addStockID = dgv_addStocks[1, i].Value.ToString();
            quantity = dgv_addStocks[5, i].Value.ToString();
        }

        private void btn_editStockQuantity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_editStockQuantity editStockQuantity = new form_editStockQuantity(this);
            editStockQuantity.ID.Text = addStockID;
            editStockQuantity.tb_editStockQuantity.Text = quantity;
            editStockQuantity.ShowDialog();
        }

        private void tb_stockRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
