using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniscentPOSAI
{
    internal class DBConnector
    {
        SqlConnection sql_connect = new SqlConnection();
        SqlCommand sql_command = new SqlCommand();
        SqlDataReader sql_datareader;

        public string DBConnection()
        {
            string connect = @"Data Source=DAPANAS\DAPANAS_OFFICE;Initial Catalog=OmniscentDB;Integrated Security=True";
            return connect;
        }

        public double getVAT()
        {
            double vat = 0;
            sql_connect.ConnectionString = DBConnection();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT * FROM tbl_vat", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                vat = Double.Parse(sql_datareader["vat"].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
            return vat;
        }
    }
}
