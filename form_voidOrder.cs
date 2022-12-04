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
    public partial class form_voidOrder : Form
    {
        SqlConnection sql_connect;
        SqlCommand sql_command;
        SqlDataReader sql_datareader;
        DBConnector db_connect = new DBConnector();

        module_sales salesModule;

        public form_voidOrder(module_sales sales)
        {
            InitializeComponent();
            sql_connect = new SqlConnection(db_connect.DBConnection());
            cb_action.Text = "Return to Inventory";
            salesModule = sales;
        }

        private void btn_closeCancelOrder_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void reloadSales()
        {
            salesModule.LoadSalesRecords();
        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_cancelQuantity.Text) || string.IsNullOrEmpty(tb_remarks.Text))
                {
                    MessageBox.Show("One or more textboxes are empty", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                else
                {
                    if (int.Parse(tb_quantity.Text) >= int.Parse(tb_cancelQuantity.Text))
                    {
                        form_voidConfirm voidConfirm = new form_voidConfirm(this);
                        voidConfirm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Cancel quantity must be equal or lesser than the transaction quantity", "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Cancel Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_voidBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_cancelQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_remarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
