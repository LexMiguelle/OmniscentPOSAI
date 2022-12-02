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
    public partial class module_sales : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        public module_sales()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            LoadCashiers();
            LoadSalesRecords();
        }

        public void LoadCashiers()
        {
            cb_cashierName.Items.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT cashierName FROM tbl_transaction", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_cashierName.Items.Add(sql_datareader[0].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        public void LoadSalesRecords()
        {
            int i = 0;
            double totalSales = 0;

            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");


            dgv_sales.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total, x.cashierName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold') AND (cashierName LIKE '%" + cb_cashierName.Text + "%') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                totalSales += double.Parse(sql_datareader[7].ToString());
                dgv_sales.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
            tb_salesTotal.Text = totalSales.ToString("#,##0.00");
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        private void cb_cashierName_TextChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        private void btn_printSales_Click(object sender, EventArgs e)
        {
            form_salesReport salesReport = new form_salesReport(this);
            salesReport.LoadSalesReport();
            salesReport.ShowDialog();
        }
    }
}
