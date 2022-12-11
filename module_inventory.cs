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
using System.Threading;
using Tulpep.NotificationWindow;
using System.Web.Security;

namespace OmniscentPOSAI
{
    public partial class module_inventory : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_login loginModule;
        module_cashier cashierModule;

        String activity = "";
        

        public module_inventory(module_login login)
        {

            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            loginModule = login;
            notifyCriticalItems();
            
        }

        private void module_inventory_Load(object sender, EventArgs e)
        {
            checkRole();
        }

        public void checkRole()
        {
            if (tb_role.Text == "manager")
            {
                btn_users.Visible = false;
                btn_users.Hide();
            }
            else
            {
                btn_users.Visible = true;
                btn_users.Show();
            }
        }

        public void LogActivity()
        {
            String role = tb_role.Text;

            sql_connect.Open();
            sql_command = new SqlCommand("INSERT INTO tbl_activity (username, role, activity, datetime) VALUES (@username, @role, @activity, @datetime)", sql_connect);
            sql_command.Parameters.AddWithValue("@username", tb_username.Text);
            sql_command.Parameters.AddWithValue("@role", role);
            sql_command.Parameters.AddWithValue("@activity", activity);
            sql_command.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
            sql_command.ExecuteNonQuery();
            sql_connect.Close();
        }

        public void notifyCriticalItems()
        {
            int i = 0;
            string critical = "";
            string count = "";

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT count(*) FROM view_criticalStocks", sql_connect);
            count = sql_command.ExecuteScalar().ToString();
            sql_connect.Close();

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_criticalStocks", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                critical += i + ". " + sql_datareader["productName"].ToString() + " (" + sql_datareader["categoryName"].ToString() + ")" + Environment.NewLine;
            }
            sql_datareader.Close();
            sql_connect.Close();

            PopupNotifier popUp = new PopupNotifier();
            popUp.Image = Properties.Resources.warning_24;
            popUp.TitleText = count + " CRITICAL ITEM(S):";
            popUp.ContentText = critical;
            popUp.Popup();
        }

        //dashboard button event
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_dashboard dashboard = new module_dashboard();
            dashboard.TopLevel = false;
            panel_activity.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();

        }

        // categories button event
        private void btn_categories_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_categories categories = new module_categories();
            categories.TopLevel = false;
            panel_activity.Controls.Add(categories);
            categories.BringToFront();
            categories.LoadCategory();
            categories.Show();
        }

        // products button event
        private void btn_products_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_products products = new module_products();
            products.TopLevel = false;
            panel_activity.Controls.Add(products);
            products.BringToFront();
            products.LoadProducts();
            products.Show();
        }

        // stocks button event
        private void btn_stocks_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_stocks stocks = new module_stocks();
            stocks.TopLevel = false;
            panel_activity.Controls.Add(stocks);
            stocks.BringToFront();
            stocks.user.Text = tb_name.Text;
            stocks.cb_status.Text = "Done";
            stocks.LoadStocks();
            stocks.LoadAddProducts();
            stocks.LoadAddStock();
            stocks.LoadManageStocks();
            stocks.referenceNo();
            stocks.Show();
        }

        // records button event
        private void btn_records_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_records records = new module_records();
            records.TopLevel = false;
            panel_activity.Controls.Add(records);
            records.LoadStockHistory();
            records.LoadCashiers();
            records.LoadCriticalStocks();
            records.LoadInventory();
            records.LoadReturnedItems();
            records.BringToFront();
            records.Show();
        }

        // sales button event
        private void btn_sales_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_sales sales = new module_sales(this);
            sales.TopLevel = false;
            panel_activity.Controls.Add(sales);
            sales.BringToFront();
            sales.Show();
        }

        // users button event
        private void btn_users_Click(object sender, EventArgs e)
        {
            panel_activity.Controls.Clear();
            module_users users = new module_users(this);
            users.LoadCode();
            users.TopLevel = false;
            panel_activity.Controls.Add(users);
            users.BringToFront();
            users.Show();
        }

        // logout button event
        private void btn_logout_Click(object sender, EventArgs e)
        {
            activity = "Logged out";
            LogActivity();
            this.Dispose();
            loginModule.Show();
        }

        

        // close button event
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Close the application without logging out?", "Omniscent: Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                loginModule.Dispose();
            }
            else
            {
                return;
            }
            
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            module_cashier cashierModule = new module_cashier(this);
            this.Hide();
            cashierModule.Show();
        }

        
    }
}
