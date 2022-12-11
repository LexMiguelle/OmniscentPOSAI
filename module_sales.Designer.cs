namespace OmniscentPOSAI
{
    partial class module_sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_salesHead = new System.Windows.Forms.Panel();
            this.tb_salesTotal = new System.Windows.Forms.TextBox();
            this.cb_cashierName = new System.Windows.Forms.ComboBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_cashierName = new System.Windows.Forms.Label();
            this.lbl_dateFilter = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.sales_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_transactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sashier_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_salesHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_salesHead
            // 
            this.panel_salesHead.Controls.Add(this.tb_salesTotal);
            this.panel_salesHead.Controls.Add(this.cb_cashierName);
            this.panel_salesHead.Controls.Add(this.dtp_to);
            this.panel_salesHead.Controls.Add(this.dtp_from);
            this.panel_salesHead.Controls.Add(this.lbl_from);
            this.panel_salesHead.Controls.Add(this.lbl_to);
            this.panel_salesHead.Controls.Add(this.lbl_cashierName);
            this.panel_salesHead.Controls.Add(this.lbl_dateFilter);
            this.panel_salesHead.Controls.Add(this.lbl_sales);
            this.panel_salesHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_salesHead.Location = new System.Drawing.Point(0, 0);
            this.panel_salesHead.Name = "panel_salesHead";
            this.panel_salesHead.Size = new System.Drawing.Size(1064, 75);
            this.panel_salesHead.TabIndex = 0;
            // 
            // tb_salesTotal
            // 
            this.tb_salesTotal.BackColor = System.Drawing.Color.Black;
            this.tb_salesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salesTotal.ForeColor = System.Drawing.Color.Lime;
            this.tb_salesTotal.Location = new System.Drawing.Point(734, 8);
            this.tb_salesTotal.Name = "tb_salesTotal";
            this.tb_salesTotal.Size = new System.Drawing.Size(318, 53);
            this.tb_salesTotal.TabIndex = 13;
            this.tb_salesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_cashierName
            // 
            this.cb_cashierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cashierName.IntegralHeight = false;
            this.cb_cashierName.ItemHeight = 16;
            this.cb_cashierName.Location = new System.Drawing.Point(519, 32);
            this.cb_cashierName.Name = "cb_cashierName";
            this.cb_cashierName.Size = new System.Drawing.Size(150, 24);
            this.cb_cashierName.TabIndex = 12;
            this.cb_cashierName.SelectedValueChanged += new System.EventHandler(this.cb_cashierName_SelectedValueChanged);
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(296, 43);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 9;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.Checked = false;
            this.dtp_from.Location = new System.Drawing.Point(296, 16);
            this.dtp_from.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 10;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.White;
            this.lbl_from.Location = new System.Drawing.Point(249, 19);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(41, 16);
            this.lbl_from.TabIndex = 6;
            this.lbl_from.Text = "From:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(263, 47);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 6;
            this.lbl_to.Text = "To:";
            // 
            // lbl_cashierName
            // 
            this.lbl_cashierName.AutoSize = true;
            this.lbl_cashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashierName.ForeColor = System.Drawing.Color.White;
            this.lbl_cashierName.Location = new System.Drawing.Point(516, 12);
            this.lbl_cashierName.Name = "lbl_cashierName";
            this.lbl_cashierName.Size = new System.Drawing.Size(96, 16);
            this.lbl_cashierName.TabIndex = 7;
            this.lbl_cashierName.Text = "Cashier Name:";
            // 
            // lbl_dateFilter
            // 
            this.lbl_dateFilter.AutoSize = true;
            this.lbl_dateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateFilter.ForeColor = System.Drawing.Color.White;
            this.lbl_dateFilter.Location = new System.Drawing.Point(144, 16);
            this.lbl_dateFilter.Name = "lbl_dateFilter";
            this.lbl_dateFilter.Size = new System.Drawing.Size(99, 20);
            this.lbl_dateFilter.TabIndex = 8;
            this.lbl_dateFilter.Text = "Date Filter:";
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sales.ForeColor = System.Drawing.Color.White;
            this.lbl_sales.Location = new System.Drawing.Point(35, 22);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(87, 31);
            this.lbl_sales.TabIndex = 3;
            this.lbl_sales.Text = "Sales";
            // 
            // dgv_sales
            // 
            this.dgv_sales.AllowUserToAddRows = false;
            this.dgv_sales.AllowUserToResizeColumns = false;
            this.dgv_sales.AllowUserToResizeRows = false;
            this.dgv_sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sales_num,
            this.sales_ID,
            this.sales_transactionNo,
            this.sashier_productID,
            this.sale_productName,
            this.sale_price,
            this.sale_quantity,
            this.sale_discount,
            this.sale_total,
            this.sales_cancel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sales.EnableHeadersVisualStyles = false;
            this.dgv_sales.GridColor = System.Drawing.Color.Black;
            this.dgv_sales.Location = new System.Drawing.Point(0, 75);
            this.dgv_sales.MultiSelect = false;
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sales.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_sales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_sales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_sales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sales.Size = new System.Drawing.Size(1064, 586);
            this.dgv_sales.TabIndex = 7;
            this.dgv_sales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sales_CellContentClick);
            // 
            // sales_num
            // 
            this.sales_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sales_num.HeaderText = "#";
            this.sales_num.MinimumWidth = 30;
            this.sales_num.Name = "sales_num";
            this.sales_num.ReadOnly = true;
            this.sales_num.Width = 30;
            // 
            // sales_ID
            // 
            this.sales_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_ID.HeaderText = "ID";
            this.sales_ID.Name = "sales_ID";
            this.sales_ID.ReadOnly = true;
            this.sales_ID.Visible = false;
            // 
            // sales_transactionNo
            // 
            this.sales_transactionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sales_transactionNo.HeaderText = "TRANSACTION NO.";
            this.sales_transactionNo.Name = "sales_transactionNo";
            this.sales_transactionNo.ReadOnly = true;
            this.sales_transactionNo.Width = 119;
            // 
            // sashier_productID
            // 
            this.sashier_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sashier_productID.HeaderText = "PRODUCT ID";
            this.sashier_productID.Name = "sashier_productID";
            this.sashier_productID.ReadOnly = true;
            this.sashier_productID.Width = 90;
            // 
            // sale_productName
            // 
            this.sale_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sale_productName.HeaderText = "PRODUCT";
            this.sale_productName.Name = "sale_productName";
            this.sale_productName.ReadOnly = true;
            // 
            // sale_price
            // 
            this.sale_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sale_price.HeaderText = "PRICE";
            this.sale_price.Name = "sale_price";
            this.sale_price.ReadOnly = true;
            this.sale_price.Width = 63;
            // 
            // sale_quantity
            // 
            this.sale_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sale_quantity.HeaderText = "QUANTITY";
            this.sale_quantity.Name = "sale_quantity";
            this.sale_quantity.ReadOnly = true;
            this.sale_quantity.Width = 86;
            // 
            // sale_discount
            // 
            this.sale_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sale_discount.HeaderText = "DISCOUNT";
            this.sale_discount.Name = "sale_discount";
            this.sale_discount.ReadOnly = true;
            this.sale_discount.Width = 87;
            // 
            // sale_total
            // 
            this.sale_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sale_total.HeaderText = "TOTAL";
            this.sale_total.Name = "sale_total";
            this.sale_total.ReadOnly = true;
            this.sale_total.Width = 66;
            // 
            // sales_cancel
            // 
            this.sales_cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sales_cancel.HeaderText = "";
            this.sales_cancel.Image = global::OmniscentPOSAI.Properties.Resources.cross_small_16;
            this.sales_cancel.MinimumWidth = 25;
            this.sales_cancel.Name = "sales_cancel";
            this.sales_cancel.ReadOnly = true;
            this.sales_cancel.Width = 25;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::OmniscentPOSAI.Properties.Resources.cross_small_16;
            this.dataGridViewImageColumn1.MinimumWidth = 25;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // module_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.panel_salesHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "module_sales";
            this.panel_salesHead.ResumeLayout(false);
            this.panel_salesHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_salesHead;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_cashierName;
        private System.Windows.Forms.Label lbl_dateFilter;
        private System.Windows.Forms.Label lbl_from;
        public System.Windows.Forms.ComboBox cb_cashierName;
        public System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.DateTimePicker dtp_from;
        public System.Windows.Forms.TextBox tb_salesTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_transactionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sashier_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sale_total;
        private System.Windows.Forms.DataGridViewImageColumn sales_cancel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}