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
using System.Windows.Forms.DataVisualization.Charting;

namespace OmniscentPOSAI
{
    public partial class module_dashboard : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        public module_dashboard()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            getDailySales();
            getTotalProducts();
            getTotalStocks();
            getCriticalStocks();
            LoadSalesChart();
            LoadTopSales();
        }

        public void getDailySales()
        {
            string salesDateMin = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            string salesDateMax = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT ISNULL(sum(total), 0) AS total FROM tbl_transaction WHERE (transactionDate BETWEEN '" + salesDateMin + "' AND '" + salesDateMax + "') AND status LIKE 'Sold'", sql_connect);
            dailySales.Text = (double.Parse(sql_command.ExecuteScalar().ToString())).ToString("₱#,##0.00");
            sql_connect.Close();
        }

        public void getTotalProducts()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT count(*) from tbl_products", sql_connect);
            totalProducts.Text = (int.Parse(sql_command.ExecuteScalar().ToString())).ToString();
            sql_connect.Close();
        }

        public void getTotalStocks()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT ISNULL(sum(quantity), 0) AS quantity from tbl_products", sql_connect);
            totalStocks.Text = (int.Parse(sql_command.ExecuteScalar().ToString())).ToString();
            sql_connect.Close();
        }

        public void getCriticalStocks()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT count(*) from view_criticalStocks", sql_connect);
            totalCriticalStocks.Text = (int.Parse(sql_command.ExecuteScalar().ToString())).ToString();
            sql_connect.Close();
        }

        public void LoadSalesChart()
        {
            sql_connect.Open();
            SqlDataAdapter sql_dataadapter = new SqlDataAdapter("SELECT Year(transactionDate) AS year, ISNULL(sum(total), 0.0) AS total FROM tbl_transaction WHERE status LIKE 'Sold' GROUP BY Year(transactionDate)", sql_connect);
            DataSet dataset = new DataSet();

            sql_dataadapter.Fill(dataset, "sales");
            chart_sales.DataSource = dataset.Tables["sales"];
            Series series = chart_sales.Series[0];
            series.ChartType = SeriesChartType.Doughnut;

            series.Name = "SALES";

            var chart = chart_sales;
            chart.Series[series.Name].XValueMember = "year";
            chart.Series[series.Name].YValueMembers = "total";
            chart.Series[0].IsValueShownAsLabel = true;
            sql_connect.Close();
        }

        public void LoadTopSales()
        {
            int i = 0;

            dgv_dashboardTop.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT productName, ISNULL(sum(quantity), 0) AS quantity FROM view_soldItems WHERE status = 'Sold' GROUP BY productName ORDER BY quantity DESC", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while(sql_datareader.Read())
            {
                i++;
                dgv_dashboardTop.Rows.Add(i, sql_datareader["productName"].ToString(), sql_datareader["quantity"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        private void totalCriticalStocks_Click(object sender, EventArgs e)
        {   /*
            Panel.
            dashboard.TopLevel = false;
            panel_activity.Controls.Add(dashboard);
            dashboard.BringToFront();
            dashboard.Show();
            */
        }
    }
}
