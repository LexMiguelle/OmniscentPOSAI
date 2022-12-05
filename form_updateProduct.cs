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
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();
        module_products productsModule;

        int categoryID = 0;

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
            string productCode = (tb_categoryPrefix.Text + tb_productCode.Text).ToString();

            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_products SET productCode = @productCode, productName = @productName, categoryID = @categoryID, price = @price, restock = @restock WHERE productID LIKE '" + lbl_ID + "'", sql_connect);
            sql_command.Parameters.AddWithValue("@productCode", productCode);
            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
            sql_command.Parameters.AddWithValue("@categoryID", categoryID);
            sql_command.Parameters.AddWithValue("@price", double.Parse(tb_price.Text));
            sql_command.Parameters.AddWithValue("@restock", int.Parse(tb_restock.Text));
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
            
            MessageBox.Show("This product has been successfully updated", "Update Product: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            productsModule.LoadProducts();
        }

        // product code text change event
        private void tb_productCode_TextChanged(object sender, EventArgs e)
        {
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
                string categoryID = sql_datareader[1].ToString();
            }
            sql_datareader.Close();
            sql_connect.Close();

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.productID FROM tbl_products AS x INNER JOIN tbl_categories AS y ON x.categoryID = y.categoryID WHERE y.categoryName = @categoryName", sql_connect);
            sql_command.Parameters.AddWithValue("@categoryName", cb_category.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_categoryID.Text = sql_datareader["productID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_categoryID.Text = lbl_ID.Text;
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

        // update button click event
        private void btn_update_Click(object sender, EventArgs e)
        {
            bool hasRows = false;
            string productCode = (tb_categoryPrefix.Text + tb_productCode.Text).ToString();

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE productName = @productName OR productCode = @productCode", sql_connect);
            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
            sql_command.Parameters.AddWithValue("@productCode", productCode);
            sql_datareader = sql_command.ExecuteReader();
            sql_datareader.Read();

            if (sql_datareader.HasRows)
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
                if (lbl_productCodeID.Text == lbl_ID.Text && lbl_productNameID.Text == lbl_ID.Text)
                {
                    
                    if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        getCategoryID();
                        updateProduct();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Duplicate input detected!", "Updarte Product: Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (tb_productCode.Text.Length < 12)
            {
                MessageBox.Show("Product Code must contain 12 numbers", "Update Product: Missing Numbers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(tb_productName.Text) || string.IsNullOrEmpty(tb_productCode.Text) || string.IsNullOrEmpty(cb_category.Text) || tb_price.Text == "0.00")
                {
                    MessageBox.Show("One or more textboxes are empty.", "Update Product: Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        getCategoryID();
                        updateProduct();
                        this.Dispose();

                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
