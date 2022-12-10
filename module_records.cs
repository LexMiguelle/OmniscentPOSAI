using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OmniscentPOSAI
{
    public partial class module_records : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        String name;

        public module_records()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cb_cashierName.Text = "All Cashiers";
        }

        private void module_records_Load(object sender, EventArgs e)
        {
            LoadCashiers();
            LoadManagers();
        }

        // Top Selling tab
        // load items to dgv_topSelling
        public void LoadTopSelling()
        {
            dgv_topSelling.Rows.Clear();
            int i = 0;
            string dateMin = dtp_topFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_topTo.Value.ToString("yyyy-MM-dd 23:59:59");

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT TOP 10 productID, productName, sum(quantity) AS quantity FROM view_sale WHERE transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "' AND status LIKE 'Sold' GROUP BY productID, productName ORDER BY quantity DESC", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_topSelling.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString());
            }
            sql_connect.Close();
        }

        // Load Top Selling Chart
        public void LoadTopSellingChart()
        {
            string topSoldFrom = dtp_topFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string topSoldTo = dtp_topTo.Value.ToString("yyyy-MM-dd 23:59:59");

            sql_connect.Open();
            SqlDataAdapter sql_dataadapter = new SqlDataAdapter("SELECT TOP 10 productID, productName, ISNULL(sum(quantity), 0) AS quantity FROM view_sale WHERE (transactionDate BETWEEN '" + topSoldFrom + "' AND '" + topSoldTo + "') AND status LIKE 'Sold' GROUP BY productID, productName ORDER BY quantity DESC", sql_connect);
            DataSet dataset = new DataSet();

            sql_dataadapter.Fill(dataset, "topSales");
            chart_topSales.DataSource = dataset.Tables["topSales"];
            Series series = chart_topSales.Series[0];
            series.ChartType = SeriesChartType.Doughnut;

            series.Name = "TOP SALES";
            var chart = chart_topSales;
            chart.Series[series.Name].XValueMember = "productName";
            chart.Series[series.Name].YValueMembers = "quantity";
            chart.Series[0]["PieLabelStyle"] = "Disabled";
            sql_connect.Close();
        }

        // dtp values changed event
        private void dtp_topSelling_ValueChanged(object sender, EventArgs e)
        {
            LoadTopSelling();
            LoadTopSellingChart();
        }

        // Top Selling print button event
        private void btn_printTopSelling_Click(object sender, EventArgs e)
        {
            printPreview_topSellingReport topSelling = new printPreview_topSellingReport(this);
            topSelling.LoadTopSellingReport();
            topSelling.ShowDialog();
        }
        
        // crashes when changing soldItemsMinDate
        // Sold Items tab
        // load Sold Items
        public void LoadSoldItems()
        {
            int i = 0;

            string soldItemsMinDate = dtp_soldItemsFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string soldItemsMaxDate = dtp_soldItemsTo.Value.ToString("yyyy-MM-dd 23:59:59");

            dgv_soldItems.Rows.Clear();
            sql_connect.Open();

            if (cb_cashierName.Text == "All Cashiers")
            {
                sql_command = new SqlCommand("SELECT * FROM view_soldItems WHERE (status LIKE 'Sold') AND (transactionDate BETWEEN '" + soldItemsMinDate + "' AND '" + soldItemsMaxDate + "')", sql_connect);
            }
            else
            {
                sql_command = new SqlCommand("SELECT * FROM view_soldItems WHERE (status LIKE 'Sold') AND (cashierName LIKE '" + cb_cashierName.Text + "') AND (transactionDate BETWEEN '" + soldItemsMinDate + "' AND '" + soldItemsMaxDate + "')", sql_connect);
            }

            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_soldItems.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString(), sql_datareader[8].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Load cashiers function
        public void LoadCashiers()
        {
            cb_cashierName.Items.Clear();
            cb_cashierName.Items.Add("All Cashiers");
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_users WHERE role LIKE 'cashier'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_cashierName.Items.Add(sql_datareader["lastName"].ToString() + ", " + sql_datareader["firstName"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        //dtp value changed
        private void dtp_soldItems_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        // cb_cashierName value changed
        private void cb_cashierName_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        // Print Sold Items Report
        private void btn_printSoldItems_Click(object sender, EventArgs e)
        {
            printPreview_salesReport salesReport = new printPreview_salesReport(this);
            salesReport.LoadSalesReport();
            salesReport.ShowDialog();
        }
        

        // Critical Items tab
        // Load Critical Items
        public void LoadCriticalStocks()
        {
            try
            {
                int i = 0;

                dgv_criticalStocks.Rows.Clear();
                sql_connect.Open();
                sql_command = new SqlCommand("SELECT * FROM view_criticalStocks", sql_connect);
                sql_datareader = sql_command.ExecuteReader();
                while (sql_datareader.Read())
                {
                    i++;
                    dgv_criticalStocks.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString());
                }
                sql_connect.Close();

            } catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message, "Critical Records: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Critical Stocks print button event
        private void btn_printCriticalStocks_Click(object sender, EventArgs e)
        {
            printPreview_criticalStocksReport criticalStocks = new printPreview_criticalStocksReport();
            criticalStocks.LoadCriticalStocksReport();
            criticalStocks.ShowDialog();
        }

        // Inventory Items tab
        //Load Inventory Items
        public void LoadInventory()
        {
            int i = 0;

            dgv_inventoryList.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM view_inventoryList",sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_inventoryList.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Inventory List print button event
        private void btn_printInventoryList_Click(object sender, EventArgs e)
        {
            printPreview_inventoryListReport inventoryReport = new printPreview_inventoryListReport();
            inventoryReport.LoadInventoryReport();
            inventoryReport.ShowDialog();
        }

        // Returned Items tab
        // Load Returned Items
        public void LoadReturnedItems()
        {
            
            int i = 0;
            string returnDateFrom = dtp_returnedItemsFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string returnDateTo = dtp_returnedItemsTo.Value.ToString("yyyy-MM-dd 23:59:59");

            sql_connect.Open();
            sql_command = new SqlCommand("SELECT transactionNo, productID, productCode, productName, categoryName, quantity, cancelledBy, remarks, cancelDate FROM view_returnedItems WHERE action LIKE 'Return to Inventory' AND (cancelDate BETWEEN '" + returnDateFrom + "' AND '" + returnDateTo + "')", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_returnedItems.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString(), sql_datareader[8].ToString());
            }
            sql_connect.Close();
            sql_datareader.Close();
            sql_connect.Close();
        }
        // Returned Items print button event
        private void btn_printReturnedItems_Click(object sender, EventArgs e)
        {
            printPreview_returnedItemsReport returnedItemsReport = new printPreview_returnedItemsReport();
            returnedItemsReport.LoadReturnedItemsReport();
            returnedItemsReport.ShowDialog();
        }

        // returned items dtp value changed 
        private void dtp_returnedItems_ValueChanged(object sender, EventArgs e)
        {
            LoadReturnedItems();
        }

        // Cancelled Orders tab
        // Load Cancelled Orders
        public void LoadCancelledOrders()
        {
            sql_connect.Open();
            sql_command = new SqlCommand("", sql_connect);
            sql_connect.Close();
        }
        // Cancelled Orders print button event
        private void btn_printCancelledOrders_Click(object sender, EventArgs e)
        {
            printPreview_cancelledOrdersReport cancelledOrdersReport = new printPreview_cancelledOrdersReport();
            cancelledOrdersReport.LoadCancelledOrdersReport();
            cancelledOrdersReport.ShowDialog();
        }

        public void LoadManagers()
        {
            cb_modifiedBy.Items.Clear();
            cb_modifiedBy.Items.Add("All Managers");
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT LastName, FirstName from tbl_users WHERE NOT role = 'cashier'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while(sql_datareader.Read())
            {
                name = sql_datareader["lastName"].ToString() + ", " + sql_datareader["firstName"].ToString();
                cb_modifiedBy.Items.Add(name);
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // Stock History
        // load stocks to Stock History
        public void LoadStockHistory()
        {
            int i = 0;
            string dateMin = dtp_stockHistoryFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_stockHistoryTo.Value.ToString("yyyy-MM-dd 23:59:59");

            dgv_stockHistory.Rows.Clear();
            sql_connect.Open();
            if (cb_modifiedBy.Text == "All Managers")
            {
                sql_command = new SqlCommand("SELECT * FROM view_stockHistory WHERE (stockDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            }
            else
            {
                sql_command = new SqlCommand("SELECT * FROM view_stockHistory WHERE (stockDate BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND modifiedBy = '" + cb_modifiedBy.Text + "'", sql_connect);
            }

            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_stockHistory.Rows.Add(i, sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // dtp_stockHistoryFrom value changed
        private void dtp_stockHistory_ValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        // cb_managers value changed
        private void cb_modifiedBy_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        // printStockHistory button click event
        private void btn_printStockHistory_Click(object sender, EventArgs e)
        {
            printPreview_stockHistoryReport stockHistoryReport = new printPreview_stockHistoryReport();
            stockHistoryReport.LoadStockHistoryReport();
            stockHistoryReport.ShowDialog();
        }

    }
}