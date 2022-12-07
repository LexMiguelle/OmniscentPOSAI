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

namespace OmniscentPOSAI
{
    public partial class module_records : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;
        Bitmap stockHistory;

        public module_records()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());

        }

        // Top Selling tab
        // load items to dgv_topSelling
        public void LoadTopSelling()
        {
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

        private void dtp_topFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadTopSelling();
        }

        private void dtp_topTo_ValueChanged(object sender, EventArgs e)
        {
            LoadTopSelling();
        }

        // Top Selling print button event
        private void btn_printTopSelling_Click(object sender, EventArgs e)
        {
            printPreview_topSellingReport topSelling = new printPreview_topSellingReport();
            topSelling.LoadTopSellingReport();
            topSelling.ShowDialog();
        }

        // Sold Items tab
        // load Sold Items
        public void LoadSoldItems()
        {
            int i = 0;
            double totalSales = 0;

            string dateMin = dtp_soldItemsFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_soldItemsTo.Value.ToString("yyyy-MM-dd 23:59:59");


            dgv_soldItems.Rows.Clear();
            sql_connect.Open();
            if (cb_cashierName.Text == "All Cashiers")
            {
                sql_command = new SqlCommand("SELECT x.productID, y.productCode, y.productName, z.categoryName, x.price, x.quantity, x.discount , x.cashierName, x.transactionDate FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID INNER JOIN tbl_categories AS z ON y.categoryID = z.categoryID WHERE (status LIKE 'Sold') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            }
            else
            {
                sql_command = new SqlCommand("SELECT x.productID, y.productCode, y.productName, z.categoryName, x.price, x.quantity, x.discount , x.cashierName, x.transactionDate FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID INNER JOIN tbl_categories AS z ON y.categoryID = z.categoryID WHERE (status LIKE 'Sold') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND (cashierName LIKE '" + cb_cashierName.Text + "') GROUP BY cashierName", sql_connect);
            }
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                totalSales += double.Parse(sql_datareader[7].ToString());
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

        // dtp_soldItemsFrom value changed event
        private void dtp_soldItemsFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        // dtp_soldItemsTo value changed event
        private void dtp_soldItemsTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSoldItems();
        }

        // cb_cashierName text changed
        private void cb_soldItemsCashierName_TextChanged(object sender, EventArgs e)
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

        private void btn_printInventoryList_Click(object sender, EventArgs e)
        {
            printPreview_inventoryListReport inventoryReport = new printPreview_inventoryListReport();
            inventoryReport.LoadInventoryReport();
            inventoryReport.ShowDialog();
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
            sql_command = new SqlCommand("SELECT * FROM view_stockOverview WHERE stockDate BETWEEN '" + dateMin + "' AND '" + dateMax + "' AND status LIKE 'Done'", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                dgv_stockHistory.Rows.Add(i, sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }


        // printStockHistory button click event
        private void btn_printStockHistory_Click(object sender, EventArgs e)
        {
            
        }

        // dtp_stockHistoryFrom value changed
        private void dtp_stockHistoryFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        // dtp_stockHistoryTo value changed
        private void dtp_stockHistoryTo_ValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        

        // Critical Stocks print button event
        private void btn_printCriticalStocks_Click(object sender, EventArgs e)
        {

        }

        
    }
}