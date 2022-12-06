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
    public partial class form_inventoryListReport : Form
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataAdapter sql_dataadapter = new SqlDataAdapter();
        DBConnector db_connect = new DBConnector();
        DataSet1 dataset = new DataSet1();
        SqlDataReader sql_datareader;

        

        public form_inventoryListReport()
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            
        }

        private void btn_closeInventoryListReport_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadInventoryReport()
        {
            ReportDataSource invRDS;
            try
            {
                rv_inventoryList.LocalReport.ReportPath = Application.StartupPath + @"\Reports\report_inventoryList.rdlc";
                rv_inventoryList.LocalReport.DataSources.Clear();
                
                DataSet1 dataset = new DataSet1();
                SqlDataAdapter sql_dataadapter = new SqlDataAdapter();

                sql_connect.Open();
                sql_dataadapter.SelectCommand = new SqlCommand("SELECT * FROM view_inventoryList", sql_connect);
                sql_dataadapter.Fill(dataset.Tables["dt_inventoryList"]);
                sql_connect.Close();

                invRDS = new ReportDataSource("DataSet1", dataset.Tables["dt_inventoryList"]);
                rv_inventoryList.LocalReport.DataSources.Add(invRDS);
                rv_inventoryList.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                rv_inventoryList.ZoomMode = ZoomMode.Percent;
                rv_inventoryList.ZoomPercent = 100;
            }
            catch (Exception exception)
            {
                sql_connect.Close();
                MessageBox.Show(exception.Message, "Inventory List Report: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void form_salesReport_Load(object sender, EventArgs e)
        {

            this.rv_inventoryList.RefreshReport();
        }
    }
}
