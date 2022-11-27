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

        public void LoadStockHistory()
        {
            int i = 0;
            string dateMin = dtp_from.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateMax = dtp_to.Value.ToString("yyyy-MM-dd 23:59:59");

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

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadStockHistory();
        }

        public void print_stocks(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(stockHistory, 0, 0);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            stockHistory = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(stockHistory);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);

        }
    }
}