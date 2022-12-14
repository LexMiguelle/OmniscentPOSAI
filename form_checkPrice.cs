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
    public partial class form_checkPrice : Form
    {

        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        public form_checkPrice()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        // clearAll function
        public void clearAll()
        {
            tb_productID.Clear();
            tb_productName.Clear();
            tb_price.Clear();
            tb_category.Clear();
            tb_productCode.Clear();
            sql_connect.Close();
        }


        // tb_productCode text changed event
        private void tb_productCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_productCode.Text == "")
            {
                tb_productCode.Enabled = false;
                return;
            }
            else
            {
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT x.productID, x.productName, x.price, y.categoryName FROM tbl_products AS x INNER JOIN tbl_categories AS Y ON x.categoryID = y.categoryID WHERE productCode LIKE '%" + tb_productCode.Text + "%'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();

                while (sql_datareader.Read())
                {
                    tb_productID.Text = sql_datareader.GetValue(0).ToString();
                    tb_productName.Text = sql_datareader.GetValue(1).ToString();
                    tb_price.Text = sql_datareader.GetValue(2).ToString();
                    tb_category.Text = sql_datareader.GetValue(3).ToString();
                }
                sql_connect.Close();
            }
        }

        // scan button event
        private void btn_scanBarcode_Click(object sender, EventArgs e)
        {
            tb_productCode.Enabled = true;
            this.clearAll();
            tb_productCode.Focus();
        }

        // close button event
        private void btn_closeCheckPrice_Click(object sender, EventArgs e)
        {
            this.clearAll();
            this.Dispose();
        }

        // tb_productCode restriction
        private void tb_productCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
