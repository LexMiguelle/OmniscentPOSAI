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
            form_inventoryListReport inventoryReport = new form_inventoryListReport();
            inventoryReport.LoadInventoryReport();
            inventoryReport.ShowDialog();
        }

        /*
        // Sold Items
        // load Sold Items
        public void LoadSoldItems()
        {
            int i = 0;
            double totalSales = 0;

            string dateMin = dtp_soldItemsFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_soldItemsTo.Value.ToString("yyyy-MM-dd 23:59:59");


            dgv_soldItems.Rows.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total, x.cashierName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                totalSales += double.Parse(sql_datareader[7].ToString());
                dgv_soldItems.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

         // dtp_soldItemsFrom value changed event
        private void dtp_soldItemsFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        // dtp_soldItemsTo value changed event
        private void dtp_soldItemsTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_soldItemsPrint_Click(object sender, EventArgs e)
        {
            form_salesReport salesReport = new form_salesReport();
            salesReport.ShowDialog();
        }
        */

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

       

        public void print_stocks(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(stockHistory, 0, 0);
        }


        // printStockHistory button click event
        private void btn_printStockHistory_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            stockHistory = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(stockHistory);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
        }

        //
        private void dtp_stockHistoryFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        private void dtp_stockHistoryTo_ValueChanged(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        
    }
}