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
        module_categories categoriesList;

        public form_updateCategory(module_categories catList)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            categoriesList = catList;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("UPDATE tbl_categories SET categoryName = @categoryName WHERE categoryID LIKE '" + lbl_ID.Text + "'", sql_connect);
                    sql_command.Parameters.AddWithValue("@categoryName", tb_updateCategory.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    MessageBox.Show("Category list updated");
                    categoriesList.LoadCategory();
                    this.Dispose();
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