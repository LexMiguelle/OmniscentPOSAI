using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OmniscentPOSAI
{
    public partial class module_users : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        public module_users()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        private void ClearCA()
        {
            tb_userNameCA.Clear();
            tb_passwordCA.Clear();
            tb_retypePasswordCA.Clear();
            tb_lastNameCA.Clear();
            tb_firstNameCA.Clear();
            cb_roleCA.Text = " ";
            tb_userNameCA.Focus();
        }

        // create button event
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if(tb_passwordCA.Text != tb_retypePasswordCA.Text)
                {
                    MessageBox.Show("Password did not match", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql_connect.Open();
                sql_command = new SqlCommand("INSERT INTO tbl_users (username, password, role, lastName, firstName) VALUES (@username, @password, @role, @lastName, @firstName)", sql_connect);
                sql_command.Parameters.AddWithValue("@username", tb_userNameCA.Text);
                sql_command.Parameters.AddWithValue("@password", tb_passwordCA.Text);
                sql_command.Parameters.AddWithValue("@role", cb_roleCA.Text);
                sql_command.Parameters.AddWithValue("@lastName", tb_lastNameCA.Text);
                sql_command.Parameters.AddWithValue("@firstName", tb_firstNameCA.Text);
                sql_command.ExecuteNonQuery();
                sql_connect.Close();

                MessageBox.Show("New account successfully created!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cancel button event
        private void btn_cancelCA_Click(object sender, EventArgs e)
        {
            ClearCA();
        }


    }
}
