﻿using System;
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
    public partial class form_addProduct : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();
        module_products productList;

        public form_addProduct(module_products prodList)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            productList = prodList;
        }

        // clear function
        private void Clear()
        {
            tb_productID.Clear();
            tb_barcode.Clear();
            tb_productName.Clear();
            tb_price.Clear();
            cb_category.Text = "";
            tb_productID.Focus();
        }

        // load category function
        public void LoadCategory()
        {
            cb_category.Items.Clear();
            sql_connect.Open();
            sql_command = new SqlCommand("SELECT categoryName FROM tbl_categories", sql_connect);
            sql_datareader = sql_command.ExecuteReader();
            while (sql_datareader.Read())
            {
                cb_category.Items.Add(sql_datareader[0].ToString());
            }
            sql_datareader.Close();
            sql_connect.Close();
        }

        // save button event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string categoryID = "";
                    sql_connect.Open();
                    sql_command = new SqlCommand("SELECT categoryID FROM tbl_categories WHERE categoryName LIKE '" + cb_category.Text + "'", sql_connect);
                    sql_datareader = sql_command.ExecuteReader();
                    sql_datareader.Read();

                    if (sql_datareader.HasRows)
                    {
                        categoryID = sql_datareader[0].ToString();
                    }

                    sql_datareader.Close();
                    sql_connect.Close();

                    sql_connect.Open();
                    sql_command = new SqlCommand("INSERT INTO tbl_products (productID, barcode, productName, categoryID, price) VALUES(@productID, @barcode, @productName, @categoryID, @price)", sql_connect);
                    sql_command.Parameters.AddWithValue("@productID", tb_productID.Text);
                    sql_command.Parameters.AddWithValue("@barcode", tb_barcode.Text);
                    sql_command.Parameters.AddWithValue("@productName", tb_productName.Text);
                    sql_command.Parameters.AddWithValue("@categoryID", categoryID);
                    sql_command.Parameters.AddWithValue("@price", tb_price.Text);
                    sql_command.ExecuteNonQuery();
                    sql_connect.Close();
                    MessageBox.Show("A product has been successfully added");
                    productList.LoadProducts();
                    Clear();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        // tb_price restriction
        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {

            }
            else if (e.KeyChar == 8)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        // cancel button event
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
