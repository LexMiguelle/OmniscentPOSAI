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
    public partial class form_updateCategory : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_categories categoriesList;

        public form_updateCategory(module_categories catList)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            categoriesList = catList;
        }

        public void updateCategory()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_categories SET categoryName = @categoryName, categoryPrefix = @categoryPrefix WHERE categoryID LIKE '" + lbl_ID.Text + "'", sql_connect);
            sql_command.Parameters.AddWithValue("@categoryName", tb_updateCategory.Text);
            sql_command.Parameters.AddWithValue("@categoryPrefix", tb_updateCategoryPrefix.Text);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
            MessageBox.Show("Category list updated", "Update Category: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_categories WHERE categoryName = @categoryName OR categoryPrefix = @categoryPrefix", sql_connect);
                sql_command.Parameters.AddWithValue("@categoryName", tb_updateCategory.Text);
                sql_command.Parameters.AddWithValue("@categoryPrefix", tb_updateCategoryPrefix.Text);
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
                    if (lbl_ID.Text == lbl_catID_name.Text && lbl_ID.Text == lbl_catID_prefix.Text)
                    {
                        if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            updateCategory();
                            categoriesList.LoadCategory();
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate input detected!", "Update Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_updateCategory.Text) || string.IsNullOrEmpty(tb_updateCategoryPrefix.Text))
                    {
                        MessageBox.Show("One or more textbox is empty.\nPlease try again", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (tb_updateCategoryPrefix.Text.Length < 2)
                    {
                        MessageBox.Show("Category Prefix must contain 2 letters\nPlease try again.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            updateCategory();
                            categoriesList.LoadCategory();
                            this.Dispose();
                        }
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

        private void tb_updateCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_updateCategoryPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (char.IsLetter(e.KeyChar))
                {
                    char.ToUpper(e.KeyChar);
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_updateCategory_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryID FROM tbl_categories WHERE categoryName = @categoryName", sql_connect);
            sql_command.Parameters.AddWithValue("@categoryName", tb_updateCategory.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_catID_name.Text = sql_datareader["categoryID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_catID_name.Text = lbl_ID.Text;
            }

            sql_datareader.Close();
            sql_connect.Close();
        }

        private void tb_updateCategoryPrefix_TextChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryID FROM tbl_categories WHERE categoryPrefix = @categoryPrefix", sql_connect);
            sql_command.Parameters.AddWithValue("@categoryPrefix", tb_updateCategoryPrefix.Text);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                lbl_catID_prefix.Text = sql_datareader["categoryID"].ToString();
            }

            if (!sql_datareader.HasRows)
            {
                lbl_catID_prefix.Text = lbl_ID.Text;
            }
            sql_datareader.Close();
            sql_connect.Close();
        }
    }
}