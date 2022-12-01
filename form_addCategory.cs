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

        module_categories categoriesList;

        public form_addCategory(module_categories catList)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            categoriesList = catList;
        }

        private void Clear()
        {
            tb_addCategory.Clear();
            tb_addCategory.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                string categoryName = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_categories WHERE categoryName = @categoryName", sql_connect);
                sql_command.Parameters.AddWithValue("@categoryName", tb_addCategory.Text);
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
                    if (MessageBox.Show("Are you sure you want to add this category?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("INSERT INTO tbl_categories(categoryName) VALUES (@categoryName)", sql_connect);
                        sql_command.Parameters.AddWithValue("@categoryName", tb_addCategory.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        MessageBox.Show("A new category has been successfully added.");
                        categoriesList.LoadCategory();
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

        private void tb_addCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar < 65) || (e.KeyChar > 90))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar < 97) || (e.KeyChar > 122))
            {
                e.Handled = true;
            }
            else if ((e.KeyChar < 192) || (e.KeyChar > 255))
            {
                e.Handled = true;
            }
        }
    }
}