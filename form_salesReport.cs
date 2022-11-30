using Microsoft.Reporting.WebForms;
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
            salesModule = sales;
        }

        public void LoadSalesReport()
        {
            try
            {
                ReportDataSource reportDataSource; 

                this.rv_sales.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_sales.rdlc";
                this.rv_sales.LocalReport.DataSources.Clear();

                string dateMin = salesModule.dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
                string dateMax = salesModule.dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");


                sql_connect.Open();
                sql_dataadapter.SelectCommand = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold')  AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
                sql_connect.Close();
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
