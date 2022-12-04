using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class module_products : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        String prodID;

        public module_products()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        // module_products load event
        private void module_products_Load(object sender, System.EventArgs e)
        {
            LoadProducts();
        }

        // load products function
        public void LoadProducts()
        {
            int id = 0;

            dgv_products.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.productID, x.productCode, x.productName, y.categoryName, x.price, x.quantity, x.restock FROM tbl_products AS x INNER JOIN tbl_categories AS y ON y.categoryID = x.categoryID WHERE x.productName LIKE '" + tb_search.Text + "%'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                id++;
                dgv_products.Rows.Add(id, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // addProduct button event
        private void btn_addProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_addProduct addProduct = new form_addProduct(this);
            addProduct.tb_ID.Text = "OS";
            addProduct.LoadCategory();
            addProduct.ShowDialog();
        }


        // search event
        private void tb_search_TextChanged(object sender, System.EventArgs e)
        {
            LoadProducts();
        }

        // data grid view events
        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_products.Columns[e.ColumnIndex].Name;
            if (col_name == "col_edit") //edit column event
            {
                string IDprefix = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                string catPrefix = dgv_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                string productID = IDprefix.Substring(IDprefix.Length - 4);
                string productCode = catPrefix.Substring(catPrefix.Length - 4);

                form_updateProduct updateProduct = new form_updateProduct(this);
                updateProduct.LoadCategory();
                updateProduct.lbl_ID.Text = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateProduct.tb_ID.Text = "OS";
                updateProduct.tb_productID.Text = productID;
                updateProduct.tb_productCode.Text = productCode;
                updateProduct.tb_productName.Text = dgv_products.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateProduct.cb_category.Text = dgv_products.Rows[e.RowIndex].Cells[4].Value.ToString();
                updateProduct.tb_price.Text = dgv_products.Rows[e.RowIndex].Cells[5].Value.ToString();
                updateProduct.tb_restock.Text = dgv_products.Rows[e.RowIndex].Cells[6].Value.ToString();
                updateProduct.ShowDialog();
            }
            else if (col_name == "col_delete") //delete column event
            {
                bool hasRows = false;
                int i = dgv_products.CurrentRow.Index;
                string productID = dgv_products[1, i].Value.ToString();

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT quantity FROM tbl_products WHERE productID = @productID", sql_connect);
                sql_command.Parameters.AddWithValue("@productID", productID);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (int.Parse(dgv_products[6, i].Value.ToString()) != 0 )
                {
                    hasRows = true;
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("This product cannot be deleted.\nSelected product still contain stocks in the inventory.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (MessageBox.Show("Delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("DELETE FROM tbl_products WHERE productID LIKE '" + dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        LoadProducts();
                    }
                }
            }
        }

        private void dgv_products_SelectionChanged(object sender, System.EventArgs e)
        {
            int i = dgv_products.CurrentRow.Index;
            prodID = dgv_products[1, i].Value.ToString();
            lbl_prodID.Text = prodID;
        }
    }
}