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
                if (MessageBox.Show("Are you sure you want to add this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql_connect.Open();
                    sql_command = new SqlCommand("INSERT INTO tbl_categories(categoryName) VALUES (@categoryName)", sql_connect);
                    sql_command.Parameters.AddWithValue("@categoryName", tb_addCategory.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    MessageBox.Show("A new category has been successfully added.");
                    categoriesList.LoadCategory();
                    this.Clear();
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