﻿using System;
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

namespace OmniscentPOSAI
{
    public partial class module_inventory : Form
    {
        Thread thread;
        SqlConnection sql_connect;
        DBConnector db_connect = new DBConnector();

        module_login loginModule;

        public module_inventory(module_login login)
        {

            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            sql_connect.Open();
            loginModule = login;
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
            records.cb_cashierName.Text = "All Cashiers";
            records.LoadSoldItems();
            records.LoadCriticalStocks();
            records.LoadInventory();
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
    }
}
