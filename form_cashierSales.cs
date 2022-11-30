using Microsoft.Reporting.WebForms.Internal.Soap.ReportingServices2005.Execution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class form_cashierSales : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_cashier cashierModule;

        string userCashier;

        public form_cashierSales(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            LoadCashierSales();
            cashierModule = cashier;
            testMe.Text = cashierModule.tb_username.Text;
            userCashier = cashierModule.tb_name.Text.ToString();
        }

        // load to dgv_cashierSales
        public void LoadCashierSales()
        {
            int i = 0;
            double totalSales = 0;

            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");
            
            
            dgv_cashierSales.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold') AND (cashierName LIKE '" + userCashier + "') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while(sql_datareader.Read()) 
            {
                i++;
                totalSales += double.Parse(sql_datareader[7].ToString());
                dgv_cashierSales.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
            tb_totalSales.Text = totalSales.ToString("#,##0.00");
        }

        private void btn_loadSales_Click(object sender, EventArgs e)
        {
            LoadCashierSales();
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            LoadCashierSales();
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            LoadCashierSales();
        }

        private void btn_closeCashierSales_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
