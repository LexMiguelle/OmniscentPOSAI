using Microsoft.Reporting.WinForms;
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
    public partial class printPreview_topSellingReport : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataAdapter sql_dataadapter = new SqlDataAdapter();
        DBConnector db_connect = new DBConnector();
        DataSet1 dataset = new DataSet1();
        SqlDataReader sql_datareader;

        module_records recordsModule;

        public printPreview_topSellingReport(module_records records)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            recordsModule = records;
        }

        public void LoadTopSellingReport()
        {
            try
            {
                ReportDataSource rds;

                this.rv_topSelling.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_topSelling.rdlc";
                this.rv_topSelling.LocalReport.DataSources.Clear();

                string dateMin = recordsModule.dtp_topFrom.Value.ToString("yyyy-MM-dd 00:00:00");
                string dateMax = recordsModule.dtp_topTo.Value.ToString("yyyy-MM-dd 23:59:59");


                sql_connect.Open();
                sql_dataadapter.SelectCommand = new SqlCommand("SELECT TOP 10 productID, productName, ISNULL(sum(quantity), 0) AS quantity FROM view_sale WHERE (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "') AND status LIKE 'Sold' GROUP BY productID, productName ORDER BY quantity DESC", sql_connect);
                sql_dataadapter.Fill(dataset.Tables["dt_topSelling"]);
                sql_connect.Close();

                ReportParameter rp_date = new ReportParameter("rp_date", "Date From: " + dateMin + " - Date To: " + dateMax);
                ReportParameter rp_cashierName = new ReportParameter("rp_cashierName", "Cashier: " + recordsModule.cb_cashierName.Text);
                ReportParameter rp_headTitle = new ReportParameter("rp_headTitle", "TOP SELLING ITEMS");

                rv_topSelling.LocalReport.SetParameters(rp_date);
                rv_topSelling.LocalReport.SetParameters(rp_cashierName);
                rv_topSelling.LocalReport.SetParameters(rp_headTitle);
                rds = new ReportDataSource("DataSet1", dataset.Tables["dt_topSelling"]);
                rv_topSelling.LocalReport.DataSources.Add(rds);
                rv_topSelling.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rv_topSelling.ZoomMode = ZoomMode.Percent;
                rv_topSelling.ZoomPercent = 100;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rv_topSelling.RefreshReport();
        }

        private void btn_closeinventoryListReport_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
