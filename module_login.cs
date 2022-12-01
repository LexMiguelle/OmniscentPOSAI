using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OmniscentPOSAI
{


    public partial class module_login : Form
    {

        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        int attempt;
        int count;

        public module_login()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        private void module_login_Load(object sender, EventArgs e)
        {
            attempt = 0;
            
        }

        private void loginTimer_Tick(object sender, EventArgs e)
        {
            if(count == 0)
            {
                loginTimer.Enabled = false;
                btn_login.Enabled = true;
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                tb_username.Focus();
                lbl_try.Text = "";
            } 
            else
            {
                lbl_try.Text = "Try again in " + count;
                count--;
            }
        }

        public void disableLogin()
        {
            if(attempt == 3)
            {
                MessageBox.Show("Max login attempts reached. Please try again later");
                attempt = 0;
                count = 10;
                loginTimer.Enabled = true;
                btn_login.Enabled = false;
                tb_username.Enabled = false;
                tb_password.Enabled = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string _username = "";
            string _role = "";
            string _lastName = "";
            string _firstName = "";

            

            try
            {
                
                bool found = false;

                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM tbl_users WHERE username = @username AND password = @password", sql_connect);
                sql_command.Parameters.AddWithValue("@username", tb_username.Text);
                sql_command.Parameters.AddWithValue("@password", tb_password.Text);
                sql_datareader = sql_command.ExecuteReader();
                sql_datareader.Read();

                if (sql_datareader.HasRows)
                {
                    found = true;
                    _username = sql_datareader["username"].ToString();
                    _role = sql_datareader["role"].ToString();
                    _lastName = sql_datareader["lastName"].ToString();
                    _firstName = sql_datareader["firstName"].ToString();
                }
                else
                {
                    found = false;
                }

                sql_datareader.Close();
                sql_connect.Close();

                if (found == true)
                {
                    if (_role == "administrator")
                    {
                        MessageBox.Show("Welcome back " + _firstName + " " + _lastName + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_username.Clear();
                        tb_password.Clear();
                        this.Hide();

                        module_admin adminModule = new module_admin(this);
                        adminModule.tb_name.Text = _lastName + ", " + _firstName;
                        adminModule.tb_username.Text = _username;
                        adminModule.tb_role.Text = _role;
                        adminModule.ShowDialog();
                        
                    }
                    else if (_role == "cashier")
                    {
                        MessageBox.Show("Welcome " + _firstName + " " + _lastName + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_username.Clear();
                        tb_password.Clear();
                        this.Hide();

                        module_cashier cashierModule = new module_cashier(this);
                        cashierModule.tb_name.Text = _lastName + ", " + _firstName;
                        cashierModule.tb_username.Text = _username;
                        cashierModule.tb_role.Text = _role;
                        cashierModule.ShowDialog();
                    }
                    else if (_role == "manager")
                    {
                        MessageBox.Show("Welcome " + _firstName + " " + _lastName + "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_username.Clear();
                        tb_password.Clear();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username/password\nPlease try again.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_username.Clear();
                    tb_password.Clear();
                    tb_username.Focus();
                    attempt++;
                    disableLogin();
                }
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tb_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
