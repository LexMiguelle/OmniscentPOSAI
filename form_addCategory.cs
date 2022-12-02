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
    public partial class form_addCategory : Form 
    { 
        SqlConnection sql_connect;
        SqlCommand sql_command;
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_categories categoryModule;

        public form_addCategory(module_categories categories)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            categoryModule = categories;
        }

        // clear function
        private void Clear()
        {
            tb_addCategory.Clear();
            tb_addCategory.Focus();
        }

        // save button event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                string categoryName = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_categories WHERE categoryName = @categoryName OR categoryPrefix = @categoryPrefix", sql_connect);
                sql_command.Parameters.AddWithValue("@categoryName", tb_addCategory.Text);
                sql_command.Parameters.AddWithValue("@categoryPrefix", tb_categoryPrefix.Text);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    categoryName = sql_datareader["categoryName"].ToString();
                }
                else
                {
                    hasRows = false;
                }   
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("Duplicate input detected!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(tb_addCategory.Text) || string.IsNullOrEmpty(tb_categoryPrefix.Text))
                    {
                        MessageBox.Show("One or more textbox is empty.\nPlease try again", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (tb_categoryPrefix.Text.Length < 2) 
                    {
                        MessageBox.Show("Category Prefix must contain 2 letters\nPlease try again.", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure you want to add this category?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql_connect.Open();
                            sql_command = new SqlCommand("INSERT INTO tbl_categories(categoryName, categoryPrefix) VALUES (@categoryName, @categoryPrefix)", sql_connect);
                            sql_command.Parameters.AddWithValue("@categoryName", tb_addCategory.Text);
                            sql_command.Parameters.AddWithValue("@categoryPrefix", tb_categoryPrefix.Text);
                            sql_command.ExecuteNonQuery();
                            sql_connect.Close();
                            MessageBox.Show("A new category has been successfully added.");
                            categoryModule.LoadCategory();
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

        // cancel button event
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // tb_addCategory restrictions
        private void tb_addCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // tb_categoryPrefix restrictions
        private void tb_categoryPrefix_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}