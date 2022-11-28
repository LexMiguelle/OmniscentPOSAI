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
            tb_barcode.Clear();
            sql_connect.Close();
        }


        // tb_barcode text changed event
        private void tb_barcode_TextChanged(object sender, EventArgs e)
        {
            if (tb_barcode.Text == "")
            {
                tb_barcode.Enabled = false;
                return;
            }
            else
            {
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT x.productID, x.productName, x.price, y.categoryName FROM tbl_products AS x INNER JOIN tbl_categories AS Y ON x.categoryID = y.categoryID WHERE barcode LIKE '%" + tb_barcode.Text + "%'", sql_connect);
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
            tb_barcode.Enabled = true;
            this.clearAll();
            tb_barcode.Focus();
        }

        // close button event
        private void btn_closeCheckPrice_Click(object sender, EventArgs e)
        {
            this.clearAll();
            this.Dispose();
        }
    }
}
