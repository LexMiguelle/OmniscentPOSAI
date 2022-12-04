using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace OmniscentPOSAI
{
    public partial class form_salesReport : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataAdapter sql_dataadapter = new SqlDataAdapter();
        DBConnector db_connect = new DBConnector();
        DataSet1 dataset = new DataSet1();
        SqlDataReader sql_datareader;

        module_sales salesModule;

        public form_salesReport(module_sales sales)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            salesModule = sales;
        }

        public void LoadSalesReport()
        {
            try
            {
                ReportDataSource rds; 

                this.rv_sales.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_sales.rdlc";
                this.rv_sales.LocalReport.DataSources.Clear();

                string dateMin = salesModule.dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
                string dateMax = salesModule.dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");


                sql_connect.Open();
                if (salesModule.cb_cashierName.Text == "All Cashiers")
                {
                    sql_dataadapter.SelectCommand = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE status LIKE 'Sold'  AND transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "'", sql_connect);

                }
                else
                {
                    sql_dataadapter.SelectCommand = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold')  AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND (cashierName LIKE '%" + salesModule.cb_cashierName.Text + "%')", sql_connect);
                }
                sql_dataadapter.Fill(dataset.Tables["dt_soldReport"]);
                sql_connect.Close();

                ReportParameter rp_date = new ReportParameter("rp_date", "Date From: " + dateMin + " - Date To: " + dateMax);
                ReportParameter rp_cashierName = new ReportParameter("rp_cashierName", "Cashier: " + salesModule.cb_cashierName.Text);
                ReportParameter rp_headTitle = new ReportParameter("rp_headTitle", "SALES REPORT");

                rv_sales.LocalReport.SetParameters(rp_date);
                rv_sales.LocalReport.SetParameters(rp_cashierName);
                rv_sales.LocalReport.SetParameters(rp_headTitle);
                rds = new ReportDataSource("DataSet1", dataset.Tables["dt_soldReport"]);
                rv_sales.LocalReport.DataSources.Add(rds);
                rv_sales.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rv_sales.ZoomMode = ZoomMode.Percent;
                rv_sales.ZoomPercent = 100;
            }
            catch
            {

            }
        }

        private void btn_closeCheckPrice_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void form_salesReport_Load(object sender, EventArgs e)
        {

            this.rv_sales.RefreshReport();
        }
    }
}
