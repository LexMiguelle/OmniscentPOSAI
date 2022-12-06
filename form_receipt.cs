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
using System.Drawing.Printing;

namespace OmniscentPOSAI
{
    public partial class form_receipt : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        DBConnector db_connect = new DBConnector();
        SqlDataReader sql_datareader;

        module_cashier cashierModule;

        string storeName = "Omniscent";
        string storeAddress = "12A Plata St., Brgy. Caniogan, Pasig City, Metro Manila";

        public form_receipt(module_cashier cashier)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cashierModule = cashier;
        }

        public void LoadReport(string rpCash, string rpChange)
        {
            ReportDataSource reportDataSource;
            try
            {
                int height = 1000;
                this.rv_receipt.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_receipt.rdlc";
                this.rv_receipt.LocalReport.DataSources.Clear();

                DataSet1 dataset = new DataSet1();
                SqlDataAdapter sql_dataadapter = new SqlDataAdapter();

                sql_connect.Open();
                sql_dataadapter.SelectCommand = new SqlCommand( "SELECT x.transactionID, x.transactionNo, x.productID, x.price, x.quantity, x.discount, x.total, x.transactionDate, y.productName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE transactionNo LIKE '" + cashierModule.transactionNo.Text + "'",sql_connect);
                sql_dataadapter.Fill(dataset.Tables["dt_sold"]);
                sql_connect.Close();

                ReportParameter rp_VATable = new ReportParameter("rp_VATable", cashierModule.totalVATable.Text);
                ReportParameter rp_VAT = new ReportParameter("rp_VAT", cashierModule.totalVAT.Text);
                ReportParameter rp_discount = new ReportParameter("rp_discount", cashierModule.totalDiscount.Text);
                ReportParameter rp_totalAmount = new ReportParameter("rp_totalAmount", cashierModule.totalAmount.Text);
                ReportParameter rp_cash = new ReportParameter("rp_cash", rpCash);
                ReportParameter rp_change = new ReportParameter("rp_change", rpChange);
                ReportParameter rp_storeName = new ReportParameter("rp_storeName", storeName);
                ReportParameter rp_storeAddress = new ReportParameter("rp_storeAddress", storeAddress);
                ReportParameter rp_transactionNo = new ReportParameter("rp_transactionNo", "Invoice No.: " + cashierModule.transactionNo.Text);
                ReportParameter rp_cashierName = new ReportParameter("rp_cashierName", cashierModule.tb_name.Text);

                rv_receipt.LocalReport.SetParameters(rp_VATable);
                rv_receipt.LocalReport.SetParameters(rp_VAT);
                rv_receipt.LocalReport.SetParameters(rp_discount);
                rv_receipt.LocalReport.SetParameters(rp_totalAmount);
                rv_receipt.LocalReport.SetParameters(rp_cash);
                rv_receipt.LocalReport.SetParameters(rp_change);
                rv_receipt.LocalReport.SetParameters(rp_storeName);
                rv_receipt.LocalReport.SetParameters(rp_storeAddress);
                rv_receipt.LocalReport.SetParameters(rp_transactionNo);
                rv_receipt.LocalReport.SetParameters(rp_cashierName);

                reportDataSource = new ReportDataSource("DataSet1", dataset.Tables["dt_sold"]);
                rv_receipt.LocalReport.DataSources.Add(reportDataSource);
                rv_receipt.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Custom", 1100, height);
                rv_receipt.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rv_receipt.ZoomMode = ZoomMode.Percent;
                rv_receipt.ZoomPercent = 100;
                rv_receipt.RefreshReport();
            }
            catch (Exception except)
            {
                sql_connect.Close();
                MessageBox.Show(except.Message);
            }
        }

        private void form_receipt_Load(object sender, EventArgs e)
        {

            this.rv_receipt.RefreshReport();
        }

        private void btn_closeCheckPrice_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
