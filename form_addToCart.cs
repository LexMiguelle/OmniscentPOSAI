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
    public partial class form_addToCart : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_cashier cashierModule;

        public form_addToCart(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }

        // load product to dgv_productList
        public void LoadProductList()
        {
            int i = 0;
            dgv_productList.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.productID, x.productName, y.categoryName, x.quantity, x.price FROM tbl_products AS x INNER JOIN tbl_categories AS y ON y.categoryID = x.categoryID WHERE x.productCode LIKE '" + tb_searchProductList.Text + "%' OR x.productName LIKE '" + tb_searchProductList.Text + "%'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_productList.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // tb_addToCartSearch text changed event
        private void tb_searchProductList_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_searchProductList.Text == string.Empty)
                {
                    LoadProductList();
                    return;
                }
                else
                {
                    LoadProductList();
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_productList.Columns[e.ColumnIndex].Name;

            if (col_name == "productList_add")
            {
                form_addQuantity addQuantity = new form_addQuantity(cashierModule);
                addQuantity.productDetails(dgv_productList.Rows[e.RowIndex].Cells[1].Value.ToString(), Double.Parse(dgv_productList.Rows[e.RowIndex].Cells[5].Value.ToString()), cashierModule.transactionNo.Text, int.Parse(dgv_productList.Rows[e.RowIndex].Cells[4].Value.ToString()));
                addQuantity.ShowDialog();
            }
        }

        private void btn_closeAddToCart_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
