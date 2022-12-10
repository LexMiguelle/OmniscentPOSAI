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
using System.Web.ModelBinding;
using System.Security.Cryptography.X509Certificates;

namespace OmniscentPOSAI
{
    public partial class module_users : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_inventory inventoryModule;

        String oldPass = "";

        public module_users(module_inventory inventory)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            inventoryModule = inventory;
            LoadUserID();
            LoadUsersCP();
            LoadRolesAL();
            cb_roleLog.Text = "All Roles";
            LoadLogsAL();
        }

        // Create Account tab
        // clear create account function
        private void ClearCA()
        {
            tb_usernameCA.Clear();
            tb_passwordCA.Clear();
            tb_retypePasswordCA.Clear();
            tb_lastNameCA.Clear();
            tb_firstNameCA.Clear();
            cb_roleCA.Text = " ";
            tb_usernameCA.Focus();
        }

        // create button event
        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_users WHERE username = '" + tb_usernameCA.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                while (sql_datareader.Read())
                {
                    if (sql_datareader.HasRows)
                    {
                        hasRows = true;
                    }
                    else
                    {
                        hasRows = false;
                    }
                }
                sql_datareader.Close();
                sql_connect.Close();

                if (hasRows == true)
                {
                    MessageBox.Show("This username has already been taken.\nPlease try another username.", "Create Account: Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    if (tb_passwordCA.Text != tb_retypePasswordCA.Text)
                    {
                        MessageBox.Show("Password input did not match with the confirmation input", "Create Account: Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (string.IsNullOrWhiteSpace(tb_usernameCA.Text) || string.IsNullOrWhiteSpace(tb_lastNameCA.Text) || string.IsNullOrWhiteSpace(tb_firstNameCA.Text) || string.IsNullOrWhiteSpace(cb_roleCA.Text) || string.IsNullOrWhiteSpace (tb_passwordCA.Text) || string.IsNullOrWhiteSpace(tb_retypePasswordCA.Text))
                    {
                        MessageBox.Show("Empty input detected!", "Create Account: Empty input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (tb_passwordCA.Text.Length < 8 || tb_passwordCA.Text.Length > 16)
                    {
                        MessageBox.Show("The password must be between 8 to 16 characters", "Create Account: Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_passwordCA.Clear();
                        tb_retypePasswordCA.Clear();
                    }
                    else
                    {
                        sql_connect.Open();
                        sql_command = new SqlCommand("INSERT INTO tbl_users (username, password, role, lastName, firstName) VALUES (@username, @password, @role, @lastName, @firstName)", sql_connect);
                        sql_command.Parameters.AddWithValue("@username", tb_usernameCA.Text);
                        sql_command.Parameters.AddWithValue("@password", tb_passwordCA.Text);
                        sql_command.Parameters.AddWithValue("@role", cb_roleCA.Text);
                        sql_command.Parameters.AddWithValue("@lastName", tb_lastNameCA.Text);
                        sql_command.Parameters.AddWithValue("@firstName", tb_firstNameCA.Text);
                        sql_command.ExecuteNonQuery();
                        sql_connect.Close();

                        ClearCA();
                        LoadUserID();
                        LoadUsersCP();
                        MessageBox.Show("New account successfully created!", "Create Account: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Create Account: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // cancel button event
        private void btn_cancelCA_Click(object sender, EventArgs e)
        {
            ClearCA();
        }

        // Update Information tab
        // Load userID
        public void LoadUserID()
        {
            cb_userIDUI.Items.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT userID FROM tbl_users" , sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read ())
            {
                cb_userIDUI.Items.Add(sql_datareader["userID"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // cb_userIDUI selected value changed
        private void cb_userIDUI_SelectedValueChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_users WHERE userID LIKE '" + cb_userIDUI.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_usernameUI.Text = sql_datareader["username"].ToString();
                usernameUI.Text = sql_datareader["username"].ToString();
                tb_lastNameUI.Text = sql_datareader["lastName"].ToString();
                lastNameUI.Text = sql_datareader["lastName"].ToString();
                tb_firstNameUI.Text = sql_datareader["firstName"].ToString();
                firstNameUI.Text = sql_datareader["firstName"].ToString();
                cb_roleUI.Text = sql_datareader["role"].ToString();
                roleUI.Text = sql_datareader["role"].ToString();

            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Clear UI fields
        public void ClearUI()
        {
            cb_userIDUI.Text = "";
            tb_usernameUI.Clear();
            cb_roleUI.Text = "";
            tb_lastNameUI.Clear();
            tb_firstNameUI.Clear();
        }

        // updateUI function
        public void updateUI()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_users SET username = @username, role = @role, lastName = @lastName, firstName = @firstName WHERE userID LIKE '" + cb_userIDUI.Text + "'", sql_connect);
            sql_command.Parameters.AddWithValue("@username", tb_usernameUI.Text);
            sql_command.Parameters.AddWithValue("@role", cb_roleUI.Text);
            sql_command.Parameters.AddWithValue("@lastName", tb_lastNameUI.Text);
            sql_command.Parameters.AddWithValue("@firstName", tb_firstNameUI.Text);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        // update button event
        private void btn_updateUI_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasRows = false;

                // usernameUI
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT username FROM tbl_users WHERE userID LIKE '" + cb_userIDUI.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                if (sql_datareader.HasRows)
                {
                    if (tb_usernameUI.Text != usernameUI.Text)
                    {
                        MessageBox.Show("This username is already taken", "Update Information: Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    sql_datareader.Close();
                    sql_connect.Close();

                }
                else
                {
                    sql_datareader.Close();
                    sql_command = new SqlCommand("UPDATE tbl_users SET username = @username WHERE userID = @userID", sql_connect);
                    sql_command.Parameters.AddWithValue("@username", tb_usernameUI.Text);
                    sql_command.Parameters.AddWithValue("@userID", cb_userIDUI.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                }

                // firstNameUI, lastNameUI, roleUI
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT role FROM tbl_users WHERE userID LIKE '" + cb_userIDUI.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                if (sql_datareader.HasRows)
                {
                    if (roleUI.Text != sql_datareader["role"].ToString())
                    {
                        if (MessageBox.Show("Are you sure that you would like to change the role of " + tb_firstNameUI.Text + " " + tb_lastNameUI.Text + " to " + sql_datareader[0].ToString() + "?", "Update Information: Role Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql_command = new SqlCommand("UPDATE tbl_users SET role = @role WHERE userID = @userID", sql_connect);
                            sql_command.Parameters.AddWithValue("@role", cb_roleUI.Text);
                            sql_command.Parameters.AddWithValue("@userID", cb_userIDUI.Text);
                            sql_command.ExecuteNonQuery();
                        }
                    }
                    sql_datareader.Close();
                    sql_connect.Close();
                }
                else
                {
                    sql_datareader.Close();
                    sql_command = new SqlCommand("UPDATE tbl_users SET role = @role WHERE userID = @userID", sql_connect);
                    sql_command.Parameters.AddWithValue("@role", cb_roleUI.Text);
                    sql_command.Parameters.AddWithValue("@userID", cb_userIDUI.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                }

                /*
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT role FROM tbl_users WHERE userID LIKE '" + cb_userIDUI.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                if (sql_datareader.HasRows)
                {
                    if (roleUI.Text == sql_datareader[0].ToString())
                    {
                        MessageBox.Show("User: " + tb_firstNameUI.Text + " " + tb_lastNameUI.Text + " is already assigned to the role: " + sql_datareader[0].ToString() + ".", "Update Information: Role Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("Are you sure that you would like to change the role of " + tb_firstNameUI.Text + " " + tb_lastNameUI.Text + " to " + sql_datareader[0].ToString() + "?", "Update Information: Role Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql_command = new SqlCommand("UPDATE tbl_users SET role = @role WHERE userID = @userID", sql_connect);
                            sql_command.Parameters.AddWithValue("@role", cb_roleUI.Text);
                            sql_command.Parameters.AddWithValue("@userID", tb_userIDCP.Text);
                            sql_command.ExecuteNonQuery();
                        }
                    }
                    sql_datareader.Close();
                    sql_connect.Close();
                }
                else
                {
                    sql_datareader.Close();
                    sql_command = new SqlCommand("UPDATE tbl_users SET role = @role WHERE userID = @userID", sql_connect);
                    sql_command.Parameters.AddWithValue("@role", cb_roleUI.Text);
                    sql_command.Parameters.AddWithValue("@userID", tb_userIDCP.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                }

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT username, role, lastName, firstName FROM tbl_users WHERE username LIKE '" + tb_usernameUI.Text + "'", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                if (sql_datareader.HasRows)
                {
                    hasRows = false;
                }
                else
                {
                    hasRows = false;
                }
                sql_datareader.Close();
                sql_connect.Close();
                
                if (hasRows == true)
                {
                    if (tb_usernameUI.Text == usernameUI.Text && cb_roleUI.Text == roleUI.Text && tb_firstNameUI.Text == firstNameUI.Text && tb_lastNameUI.Text ==lastNameUI.Text)
                    {
                        if (MessageBox.Show("No changes found", "Update Information: No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            ClearUI();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username is already taken", "Update Information: Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    updateUI();
                    MessageBox.Show("User information updated", "Update Information: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                */
            }   
            catch (Exception except) 
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Update Information: Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Change Password tab
        // Load usernames to cb_usernameCP
        public void LoadUsersCP()
        {
            cb_usernameCP.Items.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT username FROM tbl_users", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_usernameCP.Items.Add(sql_datareader["username"].ToString());
            }
            sql_connect.Close();
        }

        // cb_usernameCP selected value changed
        private void cb_usernameCP_SelectedValueChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT userID, password FROM tbl_users where username LIKE '" + cb_usernameCP.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_userIDCP.Text = sql_datareader["userID"].ToString();
                oldPass = sql_datareader["password"].ToString();
            }
            sql_connect.Close();
        }

        // clear CP
        public void ClearCP()
        {
            cb_usernameCP.Text = "";
            tb_oldPasswordCP.Clear();
            tb_newPasswordCP.Clear();
            tb_confirmPasswordCP.Clear();
        }

        // forgot password CP event
        private void btn_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tb_oldPasswordCP.Text = oldPass;
        }

        // update button CP event
        private void btn_updateCP_Click(object sender, EventArgs e)
        {
            if (tb_newPasswordCP.Text == oldPass)
            {
                MessageBox.Show("Your new password is exactly the same as your old password.", "Change Password: Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (tb_newPasswordCP.Text == tb_confirmPasswordCP.Text)
            {
                MessageBox.Show("Your new password does not match with your confirm password.", "Change Password: Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (tb_newPasswordCP.Text.Length < 8 || tb_newPasswordCP.Text.Length > 16)
            {
                MessageBox.Show("Your password must contain 8 to 16 characters", "Change Password: Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sql_connect.Open();
                sql_command = new SqlCommand("UPDATE tbl_users SET password = @password WHERE username = @username, userID = @userID", sql_connect);
                sql_command.Parameters.AddWithValue("@password", tb_newPasswordCP.Text);
                sql_command.Parameters.AddWithValue("@username", cb_usernameCP.Text);
                sql_command.Parameters.AddWithValue("@userId", tb_userIDCP.Text);
                sql_connect.Close();

                MessageBox.Show("The password for " + cb_usernameCP.Text + " has been changed.", "Change Password: Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCP();
            }
        }

        // cancel CP event
        private void btn_cancelCP_Click(object sender, EventArgs e)
        {
            ClearCP();
        }



        // Account Status tab
        // checkbox status changed
        private void check_active_CheckedChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            if (check_status.Checked == true)
            {
                sql_command = new SqlCommand("UPDATE tbl_users SET status = 'active' WHERE username LIKE '" + cb_usernameAS.Text + "'", sql_connect);
            }
            else
            {
                sql_command = new SqlCommand("UPDATE tbl_users SET status = 'deactivated' WHERE username LIKE '" + cb_usernameAS.Text + "'", sql_connect);
            }
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        // Load usernames AS
        public void LoadUsernameAS()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT usernam FROM tbl_users", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_usernameAS.Items.Add(sql_datareader["username"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // AS combobox selected value changed
        private void cb_usernameAS_SelectedValueChanged(object sender, EventArgs e)
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT lastName, firstName, status FROM tbl_users WHERE username LIKE '" + cb_usernameAS.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                tb_lastNameAS.Text = sql_datareader["lastName"].ToString();
                tb_firstNameAS.Text = sql_datareader["firstName"].ToString();
                String statusAS = sql_datareader["status"].ToString();
                if (statusAS == "active")
                {
                    check_status.Checked = true;
                }
                else
                {
                    check_status.Checked = false;
                }
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // AS cancel button event
        private void btn_cancelUI_Click(object sender, EventArgs e)
        {
            ClearUI();
        }

        // Void Code
        // Load Void Code
        public void LoadCode()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT voidCode FROM tbl_users WHERE username LIKE '" + inventoryModule.tb_username.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                voidCode.Text = sql_datareader[0].ToString();
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // generate new void code
        private void btn_generateVoidCode_Click(object sender, EventArgs e)
        {
            int min = 1000;
            int max = 9999;
            string employee = inventoryModule.tb_username.Text;

            Random vc = new Random();
            int code = vc.Next(min, max);

            voidCode.Text = code.ToString();

            sql_connect.Open();
            sql_command = new SqlCommand("UPDATE tbl_users SET voidCode = " + voidCode.Text + " WHERE username LIKE '" + inventoryModule.tb_username.Text + "'", sql_connect);
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        

        // Log Activity tab
        // Load Roles
        public void LoadRolesAL()
        {
            cb_roleLog.Items.Clear();
            cb_roleLog.Items.Add("All Roles");
            cb_roleLog.Items.Add("administrator");
            cb_roleLog.Items.Add("manager");
            cb_roleLog.Items.Add("cashier");
        }

        // Load Users AL
        public void LoadUsersAL()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT username FROM tbl_activity  WHERE role = '" + cb_roleLog.Text + "'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_usernameLog.Items.Clear();
                cb_usernameLog.Items.Add(sql_datareader["username"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Load Logs AL
        public void LoadLogsAL()
        {
            string dateMin = dtp_logFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_logTo.Value.ToString("yyyy-MM-dd 23:59:59");
            dgv_log.Rows.Clear();
            sql_connect.Open();
            if (cb_roleLog.Text == "All Roles")
            {
                sql_command = new SqlCommand("SELECT * FROM tbl_activity WHERE (datetime BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
                cb_usernameLog.Enabled = false;
            }
            else
            {
                cb_usernameLog.Enabled = true;
                if (cb_roleLog.Text == "administrator")
                {
                    sql_command = new SqlCommand("SELECT * FROM tbl_activity WHERE (datetime BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND role = 'administrator'", sql_connect);
                }
                else if (cb_roleLog.Text == "manager")
                {
                    sql_command = new SqlCommand("SELECT * FROM tbl_activity WHERE (datetime BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND role = 'manager'", sql_connect);
                }
                else if (cb_roleLog.Text == "cashier")
                {
                    sql_command = new SqlCommand("SELECT * FROM tbl_activity WHERE (datetime BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND role = 'cashier'", sql_connect);
                }
            }
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                dgv_log.Rows.Add(sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Date value changed AL
        private void dtp_logDate_ValueChanged(object sender, EventArgs e)
        {
            LoadLogsAL();
        }

        // role combobox value changed AL
        private void cb_roleLog_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadUsersAL();
            LoadLogsAL();
        }

        private void tbCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_NameCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_usernameUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_NameUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_nameCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
