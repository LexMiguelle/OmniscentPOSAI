using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class module_settings : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        module_cashier cashierModule;

        public module_settings(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }

        // update button event
        private void btn_updatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPass = "";

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT password FROM tbl_users WHERE username LIKE '" + tb_userName.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                while (sql_datareader.Read()) 
                {
                    oldPass = sql_datareader["password"].ToString();
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (tb_oldPassword.Text == oldPass)
                {
                    if (tb_newPassword.Text == tb_confirmPassword.Text)
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("UPDATE tbl_users SET password = @password WHERE username LIKE '" + cashierModule.tb_username.Text + "'", sql_connect);
                        sql_command.Parameters.AddWithValue("@password", tb_newPassword.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();

                        MessageBox.Show("Your password has been successfully changed", "Change Password: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        sql_connect.Close();
                        MessageBox.Show("Your new password does not match with the confirmation password.", "Change Password: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Old Password input is incorrect.", "Change Password: Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Settings: ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // back button event
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // close button event
        private void btn_closeSettings_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // logout button event
        private void btn_settingsLogout_Click(object sender, EventArgs e)
        {
            if (cashierModule.dgv_cart.Rows.Count > 0)
            {
                MessageBox.Show("Please finish or cancel the transaction before logging out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            } else
            {
                if (MessageBox.Show("Logout from the application?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Dispose();
                    cashierModule.cashierLogout();
                }
            }
            
        }
    }
}