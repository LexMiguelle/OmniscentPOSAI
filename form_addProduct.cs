using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class form_addProduct : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();
        module_products productModule;

        public form_addProduct(module_products products)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            productModule = products;
        }

        // form_addProduct load event
        private void form_addProduct_Load(object sender, EventArgs e)
        {
            tb_price.Text = "0.00";
            generateProductCode();
            generateproductID();

        }

        // generate product code function
        public void generateProductCode()
        {
            tb_productCode.Text = DateTime.Now.ToString("yyyyMMddHHmm");
        }

        //generate productID and restock level
        public void generateproductID()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT MAX(productID) FROM tbl_products", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            sql_datareader.Read();
            string lastIDResult = sql_datareader[0].ToString();
            int lastID = Int16.Parse(lastIDResult.Trim('O', 'S')) + 1;
            sql_datareader.Close();
            sql_connect.Close();
            tb_productID.Text = lastID.ToString();
            tb_restock.Text = "50"; //restock level
        }

        // add dot to tb_price
        private void addDot()
        {
            if (!tb_price.Text.Contains("."))
            {
                tb_price.Text += ".00";
            }
        }

        // clear function
        private void Clear()
        {
            tb_categoryPrefix.Clear();
            tb_productID.Clear();
            tb_productCode.Clear();
            tb_productName.Clear();
            tb_price.Text = "0.00";
            cb_category.Text = "";
            tb_productID.Focus();
        }

        // load category function
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
                tb_categoryPrefix.Text = sql_datareader[0].ToString();
            }
            sql_datareader.Close();
            sql_connect.Close();
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

        // save button event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                string productName = "";
                string productID = "";
                string productCode = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE productName = @productName OR productID = @productID OR productCode = @productCode", sql_connect);
                sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                sql_command.Parameters.AddWithValue("@productID", tb_ID.Text + tb_productID.Text);
                sql_command.Parameters.AddWithValue("@productCode", tb_categoryPrefix + tb_productCode.Text);
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
                    if (string.IsNullOrEmpty(tb_productID.Text) || string.IsNullOrEmpty(tb_productName.Text) || string.IsNullOrEmpty(cb_category.Text) || tb_price.Text == "0.00")
                    {
                        MessageBox.Show("Empty textbox detected!\nPlease try again.", "Add Product: Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        if (MessageBox.Show("Are you sure you want to add this product?", "Add Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                            sql_command = new SqlCommand("INSERT INTO tbl_products (productID, productCode, productName, categoryID, price, restock, active) VALUES (@productID, @productCode, @productName, @categoryID, @price, @restock, @active)", sql_connect);
                            sql_command.Parameters.AddWithValue("@productID",  tb_ID.Text + tb_productID.Text);
                            sql_command.Parameters.AddWithValue("@productCode", tb_categoryPrefix.Text + tb_productCode.Text);
                            sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                            sql_command.Parameters.AddWithValue("@categoryID", categoryID);
                            sql_command.Parameters.AddWithValue("@price", tb_price.Text);
                            sql_command.Parameters.AddWithValue("@restock", tb_restock.Text);
                            sql_command.Parameters.AddWithValue("@active", 1);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();
                            MessageBox.Show("A product has been successfully added");
                            productModule.LoadProducts();
                            this.Dispose();
                        }
                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cancel button event
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}