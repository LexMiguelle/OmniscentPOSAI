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

        public module_stocks()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        private void module_stocks_Load(object sender, EventArgs e)
        {
            LoadAddProducts();
        }

        // tp_Overview event
        // load stocks to dgv_stockOverview
        public void LoadStockOverview()
        {
            int i = 0;
            dgv_stockOverview.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_stockOverview", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_stockOverview.Rows.Add(i, sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // load button event
        private void btn_load_Click(object sender, EventArgs e)
        {
            int i = 0;
            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd");
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

        // tp_addStock
        // load products to addProducts
        public void LoadAddProducts()
        {
            int i = 0;
            dgv_addProducts.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID, productName, quantity FROM tbl_products WHERE productname LIKE '%" + tb_search.Text + "%' ORDER BY productName", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_addProducts.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // load stocks to dgv_addStock
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

        //
        private void tb_search_overview_TextChanged(object sender, EventArgs e)
        {
            LoadAddProducts();
        }

        // dgv_addProducts click event
        private void dgv_addProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_addProducts.Columns[e.ColumnIndex].Name;
            if (tb_referenceNo.Text == string.Empty)
            {
                MessageBox.Show("Reference number is missing", "Missing Reference Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_generate.Focus();
                return;
            }
            if (col_name == "col_add") // col_add event
            {
                sql_connect.Open();
                sql_command = new SqlCommand("INSERT INTO tbl_addStock (referenceNo, productID, stockDate) VALUES (@referenceNo, @productID, @stockDate)", sql_connect);
                sql_command.Parameters.AddWithValue("@referenceNo", tb_referenceNo.Text);
                sql_command.Parameters.AddWithValue("@productID", dgv_addProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                sql_command.Parameters.AddWithValue("@stockDate", dtp_date.Value);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();
                LoadAddStock();
                MessageBox.Show("Product added to list", "Add Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        // dgv_addStocks click event
        private void dgv_addStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_addStocks.Columns[e.ColumnIndex].Name;
            if (col_name == "col_remove") // col_remove event
            {
                if (MessageBox.Show("Remove selected product from the list?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("DELETE FROM tbl_addStock WHERE ID = '" + dgv_addStocks.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();

                    MessageBox.Show("Product removed from list", "Remove Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAddStock();
                }
            }
        }

        // clear function
        public void Clear()
        {
            tb_referenceNo.Clear();
        }

        // generate button event
        private void btn_generate_Click(object sender, EventArgs e)
        {
            tb_referenceNo.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
            btn_generate.Hide();
        }

        // save button event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_addStocks.Rows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to save this list?", "Save Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgv_addStocks.Rows.Count; i++)
                        {
                            sql_connect.Open();
                            sql_command = new SqlCommand("UPDATE tbl_products SET quantity = quantity + '" + int.Parse(dgv_addStocks.Rows[i].Cells[5].Value.ToString()) + "' WHERE productID LIKE '" + dgv_addStocks.Rows[i].Cells[3].Value.ToString() + "'", sql_connect);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();

                            sql_connect.Open();
                            sql_command = new SqlCommand("UPDATE tbl_addStock SET quantity = quantity + '" + int.Parse(dgv_addStocks.Rows[i].Cells[5].Value.ToString()) + "', status = 'Done' WHERE ID LIKE '" + dgv_addStocks.Rows[i].Cells[1].Value.ToString() + "'", sql_connect);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();
                        }
                        dgv_addStocks.Rows.Clear();
                        LoadAddStock();
                        btn_generate.Show();
                    }
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv_addStocks.Rows.Clear();
        }

        // tp_manageStock
        // load stocks to tp_manageStocks
        public void LoadManageStock()
        {
            int i = 0;
            dgv_manageStocks.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.productID, x.barcode, x.productName, y.categoryName, x.quantity FROM tbl_products AS x INNER JOIN tbl_categories AS y ON y.categoryID = x.categoryID WHERE x.productName LIKE '%" + tb_search.Text + "' ORDER BY x.productName", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_manageStocks.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }


        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadManageStock();
            }
        }

        private void btn_clearTextboxes_Click(object sender, EventArgs e)
        {
            tb_refNo.Clear();
            tb_productID.Clear();
            tb_productName.Clear();
            tb_quantity.Clear();
            rtb_remarks.Clear();
        }
    }
}
