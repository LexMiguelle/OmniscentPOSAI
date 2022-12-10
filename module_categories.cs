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
    public partial class module_categories : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        String catID;
        

        public module_categories()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            
        }

        // load categories to dgv_categories
        public void LoadCategory()
        {
            int id = 0;

            dgv_categories.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_categories ORDER BY categoryName", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                id++;
                dgv_categories.Rows.Add(id, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // dgv_categories click events
        private void dgv_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_name = dgv_categories.Columns[e.ColumnIndex].Name;

            if (column_name == "categories_edit")
            {
                form_updateCategory updateCategory = new form_updateCategory(this);
                updateCategory.lbl_ID.Text = dgv_categories.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateCategory.tb_updateCategory.Text = dgv_categories.Rows[e.RowIndex].Cells[2].Value.ToString();
                updateCategory.tb_updateCategoryPrefix.Text = dgv_categories.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateCategory.ShowDialog();

            }
            else if (column_name == "categories_delete")
            {
                bool hasRows = false;

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_products WHERE categoryID = @categoryID", sql_connect);
                sql_command.Parameters.AddWithValue("@categoryID", catID);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    hasRows = true;
                    catID = sql_datareader["categoryID"].ToString();
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("This category cannot be deleted.");
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("DELETE FROM tbl_categories WHERE categoryID LIKE '" + dgv_categories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", sql_connect);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();
                        MessageBox.Show("Category removed successfully");
                        LoadCategory();
                    }
                }
            }
        }

        private void btn_addCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_addCategory add_category = new form_addCategory(this);
            add_category.ShowDialog();
        }

        private void dgv_categories_SelectionChanged(object sender, EventArgs e)
        {
            int i = dgv_categories.CurrentRow.Index;
            catID = dgv_categories[1, i].Value.ToString();
            lbl_catID.Text = catID;
        }

        private void searchCategory_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            dgv_categories.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_categories WHERE categoryName LIKE '%" + searchCategory.Text + "%'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_categories.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString());
            }
            sql_connect.Close();
        }
    }
}

