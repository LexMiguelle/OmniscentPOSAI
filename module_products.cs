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
            sql_command = new SqlCommand("SELECT x.productID, x.barcode, x.productName, x.categoryID, x.price, x.quantity, x.restock FROM tbl_products AS x INNER JOIN tbl_categories AS y ON y.categoryID = x.categoryID WHERE x.productName LIKE '" + tb_search.Text + "%'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                id++;
                dgv_products.Rows.Add(id, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
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
                form_updateProduct updateProduct = new form_updateProduct(this);
                updateProduct.LoadCategory();
                updateProduct.tb_productID.Text = dgv_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateProduct.tb_barcode.Text = dgv_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                updateProduct.tb_productName.Text = dgv_products.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateProduct.cb_category.Text = dgv_products.Rows[e.RowIndex].Cells[4].Value.ToString();
                updateProduct.tb_price.Text = dgv_products.Rows[e.RowIndex].Cells[5].Value.ToString();
                updateProduct.ShowDialog();
            }
            else if (col_name == "col_delete") //delete column event
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

        // addProduct button event
        private void btn_addProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_addProduct addProduct = new form_addProduct(this);
            addProduct.LoadCategory();
            addProduct.ShowDialog();
        }


    }
}