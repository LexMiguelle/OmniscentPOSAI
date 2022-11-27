using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class module_login : Form
    {
        Thread thread;

        public module_login()
        {
            InitializeComponent();

        }

        public void openAdmin()
        {
            Application.Run(new module_admin());
        }

        public void openCashier()
        {
            Application.Run(new module_cashier());
        }


        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                if (tb_username.Text == "admin" && tb_password.Text == "admin")
                {
                    this.Close();
                    thread = new Thread(openAdmin);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();

                }
                else if (tb_username.Text == "cashier" && tb_password.Text == "cashier")
                {
                    this.Close();
                    thread = new Thread(openCashier);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Please recheck your username or password", "INVALID USER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please recheck your username or password", "INVALID USER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
