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
        module_products productsModule;

        public form_updateProduct(module_products products)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            productsModule = products;
        }

        // load categories to cb_category
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

        // cb_category text change event
        private void cb_category_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryPrefix FROM tbl_categories WHERE categoryName = '" + cb_category.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_prodID.Text = sql_datareader[0].ToString();
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // add dot to tb_price
        private void addDot()
        {
            if (!tb_price.Text.Contains("."))
            {
                tb_price.Text += ".00";
            }
        }

        // tb_price text change event
        private void tb_price_TextChanged(object sender, EventArgs e)
        {
            addDot();
        }

        // cb_category text change event
        private void cb_category_TextChange(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryPrefix FROM tbl_categories WHERE categoryName = '" + cb_category.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_prodID.Text = sql_datareader[0].ToString();
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // tb_productID restriction
        private void tb_productID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // tb_productName restriction
        private void tb_productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // tb_price restriction
        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // update button click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                string productName = "";
                string productID = "";
                string productCode = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE (productName, productID, productCode) VALUES (@productName, @productID, @productCode)", sql_connect);
                sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                sql_command.Parameters.AddWithValue("@productID", tb_prodID.Text + tb_productID.Text);
                sql_command.Parameters.AddWithValue("@productCode", tb_productCode.Text);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    productName = sql_datareader["productName"].ToString();
                    productID = sql_datareader["productID"].ToString();
                    productCode = sql_datareader["productCode"].ToString();
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("This product has already been added into the list", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tb_productID.Text.Length < 4)
                {
                    MessageBox.Show("product ID must contain 4 numbers");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string prodID = "";

                        sql_connect.Open();
                        sql_command = new SqlCommand("SELECT productID FROM tbl_categories WHERE productName LIKE '" + tb_productName.Text + "'", sql_connect);
                        sql_datareader = sql_command.ExecuteReader();
                        sql_datareader.Read();

                        if (sql_datareader.HasRows)
                        {
                            prodID = sql_datareader[0].ToString();
                        }

                        sql_datareader.Close();
                        sql_connect.Close();

                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_products SET productCode = @productCode, productName = @productName, categoryID = @categoryID, price = @price, restock = @restock WHERE productID LIKE @productID", sql_connect);
                        sql_command.Parameters.AddWithValue("@productID", prodID);
                        sql_command.Parameters.AddWithValue("@productCode", tb_productCode.Text);
                        sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                        sql_command.Parameters.AddWithValue("@categoryID", cb_category.Text);
                        sql_command.Parameters.AddWithValue("@price", tb_price.Text);
                        sql_command.Parameters.AddWithValue("@restock", tb_restock.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();

                        productsModule.LoadProducts();
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

        private void tb_productCode_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productCode FROM tbl_products WHERE productCode = @productCode", sql_connect);
            sql_command.Parameters.AddWithValue("@productCode", tb_productCode.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_productCode.Text = sql_datareader["productCode"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_productCode.Text = lbl_ID.Text;
            }

            sql_datareader.Close();
            sql_connect.Close();
        }

        private void tb_productName_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID FROM tbl_products WHERE productName = @productName", sql_connect);
            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_prodCatID.Text = sql_datareader["productID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_prodCatID.Text = lbl_ID.Text;
            }

            sql_datareader.Close();
            sql_connect.Close();
        }
    }
}
