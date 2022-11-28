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
using System.Data.SqlClient;

namespace OmniscentPOSAI
{
    

    public partial class module_login : Form
    {
        Thread thread;

        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        public module_login()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
        }

        /* public void openAdmin()
        {
            Application.Run(new module_admin());
        }

        public void openCashier()
        {
            Application.Run(new module_cashier());
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (tb_username.Text == "admin" && tb_password.Text == "admin")
                {
                    this.Close();
                    thread = new Thread(openAdmin);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                }
                else if (tb_username.Text == "cashier" && tb_password.Text == "cashier")
                {
                    this.Close();
                    thread = new Thread(openCashier);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Please recheck your username or password", "INVALID USER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please recheck your username or password", "INVALID USER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           */

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
                    else
                    {
                        MessageBox.Show("Invalid User!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }}
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
