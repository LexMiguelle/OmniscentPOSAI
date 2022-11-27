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
    public partial class module_settings : Form
    {

        Thread thread;

        public module_settings()
        {
            InitializeComponent();
        }

        // closeCashier function
        public void closeCashier()
        {
            Application.Exit();
            Application.Run(new module_login());
        }

        // logout button event
        private void btn_logout_Click(object sender, EventArgs e)
        {
            thread = new Thread(closeCashier);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        // update button event
        private void btn_updatePassword_Click(object sender, EventArgs e)
        {

        }

        // back button event
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // close button event
        private void btn_closeSettings_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}