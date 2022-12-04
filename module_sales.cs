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

        module_inventory inventoryModule;

        public module_sales(module_inventory inventory)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            LoadCashiers();
            LoadSalesRecords();
            cb_cashierName.Text = "All Cashiers";
            inventoryModule = inventory;
        }

        // load cashiers to cb_cashierName
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

        // load sales to dgv_sales
        public void LoadSalesRecords()
        {
            int i = 0;
            double totalSales = 0;
            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");

            dtp_from.Value = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, 1).AddDays(0);
            dtp_to.Value = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, 1).AddMonths(1).AddDays(-1);

            dgv_sales.Rows.Clear();
            sql_connect.Open();
            if (cb_cashierName.Text == "All Cashiers")
            {
                sql_command = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total, x.cashierName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);

            }
            else
            {
                sql_command = new SqlCommand("SELECT x.transactionID, x.transactionNo, x.productID, y.productName, x.price, x.quantity, x.discount, x.total, x.cashierName FROM tbl_transaction AS x INNER JOIN tbl_products AS y ON x.productID = y.productID WHERE (status LIKE 'Sold') AND (cashierName LIKE '" + cb_cashierName.Text + "') AND (transactionDate BETWEEN '" + dateMin + "' AND '" + dateMax + "')", sql_connect);
            }

            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                i++;
                totalSales += double.Parse(sql_datareader[7].ToString());
                dgv_sales.Rows.Add(i, sql_datareader[0].ToString(), sql_datareader[1].ToString(), sql_datareader[2].ToString(), sql_datareader[3].ToString(), sql_datareader[4].ToString(), sql_datareader[5].ToString(), sql_datareader[6].ToString(), sql_datareader[7].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
            tb_salesTotal.Text = totalSales.ToString("#,##0.00");

            if (cb_cashierName.Text == " ")
            {
                btn_printSales.Enabled = false;
            }
            else
            {
                btn_printSales.Enabled = true;
            }
        }

        // dtp_from value changed event
        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        // dtp_to value changed event
        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        // cb_cashierName selected value changed event
        private void cb_cashierName_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSalesRecords();
        }

        private void btn_printSales_Click(object sender, EventArgs e)
        {
            form_salesReport salesReport = new form_salesReport(this);
            salesReport.LoadSalesReport();
            salesReport.ShowDialog();
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col_name = dgv_sales.Columns[e.ColumnIndex].Name;
            if (col_name == "sales_cancel")
            {
                form_voidOrder voidOrder = new form_voidOrder(this);
                voidOrder.transactionID.Text = dgv_sales.Rows[e.RowIndex].Cells[1].Value.ToString();
                voidOrder.tb_transactionNo.Text = dgv_sales.Rows[e.RowIndex].Cells[2].Value.ToString();
                voidOrder.tb_productID.Text = dgv_sales.Rows[e.RowIndex].Cells[3].Value.ToString();
                voidOrder.tb_productName.Text = dgv_sales.Rows[e.RowIndex].Cells[4].Value.ToString();
                voidOrder.tb_price.Text = dgv_sales.Rows[e.RowIndex].Cells[5].Value.ToString();
                voidOrder.tb_quantity.Text = dgv_sales.Rows[e.RowIndex].Cells[6].Value.ToString();
                voidOrder.tb_discount.Text = dgv_sales.Rows[e.RowIndex].Cells[7].Value.ToString();
                voidOrder.tb_total.Text = dgv_sales.Rows[e.RowIndex].Cells[8].Value.ToString();
                voidOrder.tb_voidBy.Text = inventoryModule.tb_name.Text;
                voidOrder.ShowDialog();
            }
        }
    }
}
