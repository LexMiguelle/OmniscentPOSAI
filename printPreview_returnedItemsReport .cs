using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmniscentPOSAI
{
    public partial class printPreview_returnedItemsReport : Form
    {
        public printPreview_returnedItemsReport()
        {
            InitializeComponent();
        }

        public void LoadReturnedItemsReport()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rv_topSelling.RefreshReport();
        }

        private void btn_closeinventoryListReport_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
