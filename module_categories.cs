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
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        public module_categories()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

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
                dgv_categories.Rows.Add(id, sql_datareader[0].ToString(), sql_datareader[1].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        private void dgv_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column_name = dgv_categories.Columns[e.ColumnIndex].Name;

            if (column_name == "col_edit")
            {
                form_updateCategory updateCategory = new form_updateCategory(this);
                updateCategory.tb_updateCategory.Text = dgv_categories.Rows[e.RowIndex].Cells[2].Value.ToString();
                updateCategory.lbl_ID.Text = dgv_categories.Rows[e.RowIndex].Cells[1].Value.ToString();
                updateCategory.ShowDialog();

            }
            else if (column_name == "col_delete")
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

        private void btn_addCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_addCategory add_category = new form_addCategory(this);
            add_category.ShowDialog();
        }
    }
}

