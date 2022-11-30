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

    public partial class form_updateProduct : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();
        module_products productList;

        public form_updateProduct(module_products prodList)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            productList = prodList;
        }

        public void LoadCategory()
        {
            cb_category.Items.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryName FROM tbl_categories", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_category.Items.Add(sql_datareader[0].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                string productName = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE productName = @productName", sql_connect);
                sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    productName = sql_datareader["productName"].ToString();
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("This product has already been added into the list");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string categoryID = "";
                        sql_connect.Open();
                        sql_command = new SqlCommand("SELECT categoryID FROM tbl_categories WHERE categoryName LIKE '" + cb_category.Text + "'", sql_connect);
                        sql_datareader = sql_command.ExecuteReader();
                        sql_datareader.Read();

                        if (sql_datareader.HasRows)
                        {
                            categoryID = sql_datareader[0].ToString();
                        }

                        sql_datareader.Close();
                        sql_connect.Close();

                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_products SET barcode = @barcode, productName = @productName, categoryID = @categoryID, price = @price WHERE productID LIKE @productID", sql_connect);
                        sql_command.Parameters.AddWithValue("@productID", tb_productID.Text);
                        sql_command.Parameters.AddWithValue("@barcode", tb_barcode.Text);
                        sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                        sql_command.Parameters.AddWithValue("@categoryID", categoryID);
                        sql_command.Parameters.AddWithValue("@price", tb_price.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        productList.LoadProducts();
                        MessageBox.Show("A product has been successfully updated");
                        this.Dispose();
                        }
                    }
                }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
