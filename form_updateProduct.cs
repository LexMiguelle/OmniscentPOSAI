using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{

    public partial class form_updateProduct : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();
        module_products productsModule;

        int categoryID = 0;
        string productCode = string.Empty;
        string productID = string.Empty;

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

        // get categoryID
        public void getCategoryID()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryID FROM tbl_categories WHERE categoryName = @categoryName", sql_connect);
            sql_command.Parameters.AddWithValue("@categoryName", cb_category.Text);
            sql_datareader = sql_command.ExecuteReader();
            sql_datareader.Read();
            if (sql_datareader.HasRows)
            {
                categoryID = int.Parse(sql_datareader[0].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // update product
        public void updateProduct()
        {
            
        }

        // update button click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            /*
            bool hasRows = false;
            productCode = tb_categoryPrefix.Text + tb_productCode.Text;

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID FROM tbl_products WHERE productName = @productName OR productCode = @productCode", sql_connect);
            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
            sql_command.Parameters.AddWithValue("@productCode", productCode);
            sql_datareader = sql_command.ExecuteReader();
            sql_datareader.Read();

            if (sql_datareader.HasRows)
            {
                hasRows = true;
                productID = sql_datareader["productID"].ToString();
            }
            else
            {
                hasRows = false;
            }
            sql_datareader.Close();
            sql_connect.Close();
            */

            if (string.IsNullOrWhiteSpace(tb_productName.Text) || string.IsNullOrWhiteSpace(tb_productCode.Text) || string.IsNullOrEmpty(tb_restock.Text) || int.Parse(tb_productCode.Text.Length.ToString()) < 12 || double.Parse(tb_price.Text) <= 0.00)
            {
              MessageBox.Show("Invalid input detected!", "Update Product: Invalid Input(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //if (hasRows == true)
                //{
                    if (lbl_productCodeID.Text == lbl_ID.Text && lbl_productNameID.Text == lbl_ID.Text)
                    {
                        if (MessageBox.Show("Are you sure you want to edit this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                        productCode = tb_categoryPrefix.Text + tb_productCode.Text;
                        getCategoryID();

                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_products SET productCode = '" + productCode + "', productName = '" + tb_productName.Text + "', categoryID = " + categoryID + ", price = " + tb_price.Text + ", restock = " + tb_restock.Text + " WHERE productID LIKE '" + lbl_ID.Text + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();

                        productsModule.LoadProducts();
                        MessageBox.Show("This product has been successfully updated", "Update Product: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate input detected!", "Update Product: Duplicate Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                /*}
                //else
                //{
                    if (lbl_productCodeID.Text == lbl_ID.Text && lbl_productNameID.Text == lbl_ID.Text)
                    {
                        if (MessageBox.Show("Are you sure you want to edit this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            updateProduct();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate input detected!", "Update Product: Duplicate Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }*/
            }
        }

        // product code text change event
        private void tb_productCode_TextChanged(object sender, EventArgs e)
        {
            lbl_pcodeLength.Text = tb_productCode.Text.Length.ToString();

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID FROM tbl_products WHERE productCode = @productCode", sql_connect);
            sql_command.Parameters.AddWithValue("@productCode", tb_productCode.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_productCodeID.Text = sql_datareader["productID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_productCodeID.Text = lbl_ID.Text;
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // product name text change event
        private void tb_productName_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productID FROM tbl_products WHERE productName = @productName", sql_connect);
            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_productNameID.Text = sql_datareader["productID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_productNameID.Text = lbl_ID.Text;
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // cb_category text change event
        private void cb_category_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryPrefix, categoryID FROM tbl_categories WHERE categoryName = '" + cb_category.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_categoryPrefix.Text = sql_datareader[0].ToString();
                categoryID = int.Parse(sql_datareader[1].ToString());
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

        // cancel button event
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
