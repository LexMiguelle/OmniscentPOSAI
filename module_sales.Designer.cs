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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(module_sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_salesHead = new System.Windows.Forms.Panel();
            this.tb_salesTotal = new System.Windows.Forms.TextBox();
            this.cb_cashierName = new System.Windows.Forms.ComboBox();
            this.btn_printSales = new System.Windows.Forms.Button();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_cashierName = new System.Windows.Forms.Label();
            this.lbl_dateFilter = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.cashierSales_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_transactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesCashier_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSale_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSale_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSale_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSale_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSale_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_salesHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_salesHead
            // 
            this.panel_salesHead.Controls.Add(this.tb_salesTotal);
            this.panel_salesHead.Controls.Add(this.cb_cashierName);
            this.panel_salesHead.Controls.Add(this.btn_printSales);
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
            this.tb_salesTotal.Location = new System.Drawing.Point(852, 8);
            this.tb_salesTotal.Name = "tb_salesTotal";
            this.tb_salesTotal.Size = new System.Drawing.Size(200, 53);
            this.tb_salesTotal.TabIndex = 13;
            this.tb_salesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_cashierName
            // 
            this.cb_cashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cashierName.FormattingEnabled = true;
            this.cb_cashierName.Location = new System.Drawing.Point(519, 32);
            this.cb_cashierName.Name = "cb_cashierName";
            this.cb_cashierName.Size = new System.Drawing.Size(150, 24);
            this.cb_cashierName.TabIndex = 12;
            this.cb_cashierName.SelectedValueChanged += new System.EventHandler(this.cb_cashierName_SelectedValueChanged);
            // 
            // btn_printSales
            // 
            this.btn_printSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_printSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printSales.ForeColor = System.Drawing.Color.Black;
            this.btn_printSales.Image = ((System.Drawing.Image)(resources.GetObject("btn_printSales.Image")));
            this.btn_printSales.Location = new System.Drawing.Point(712, 26);
            this.btn_printSales.Name = "btn_printSales";
            this.btn_printSales.Size = new System.Drawing.Size(100, 30);
            this.btn_printSales.TabIndex = 11;
            this.btn_printSales.Text = "Print";
            this.btn_printSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_printSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_printSales.UseVisualStyleBackColor = false;
            this.btn_printSales.Click += new System.EventHandler(this.btn_printSales_Click);
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
            this.dtp_from.Location = new System.Drawing.Point(296, 16);
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
            this.cashierSales_num,
            this.cashierSales_ID,
            this.cashierSales_transactionNo,
            this.salesCashier_productID,
            this.cashierSale_productName,
            this.cashierSale_price,
            this.cashierSale_quantity,
            this.cashierSale_discount,
            this.cashierSale_total});
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
            // 
            // cashierSales_num
            // 
            this.cashierSales_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cashierSales_num.HeaderText = "#";
            this.cashierSales_num.MinimumWidth = 30;
            this.cashierSales_num.Name = "cashierSales_num";
            this.cashierSales_num.Width = 30;
            // 
            // cashierSales_ID
            // 
            this.cashierSales_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_ID.HeaderText = "ID";
            this.cashierSales_ID.Name = "cashierSales_ID";
            this.cashierSales_ID.Visible = false;
            // 
            // cashierSales_transactionNo
            // 
            this.cashierSales_transactionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_transactionNo.HeaderText = "TRANSACTION NO.";
            this.cashierSales_transactionNo.Name = "cashierSales_transactionNo";
            this.cashierSales_transactionNo.Width = 119;
            // 
            // salesCashier_productID
            // 
            this.salesCashier_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salesCashier_productID.HeaderText = "PRODUCT ID";
            this.salesCashier_productID.Name = "salesCashier_productID";
            this.salesCashier_productID.Width = 90;
            // 
            // cashierSale_productName
            // 
            this.cashierSale_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cashierSale_productName.HeaderText = "PRODUCT";
            this.cashierSale_productName.Name = "cashierSale_productName";
            // 
            // cashierSale_price
            // 
            this.cashierSale_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSale_price.HeaderText = "PRICE";
            this.cashierSale_price.Name = "cashierSale_price";
            this.cashierSale_price.Width = 63;
            // 
            // cashierSale_quantity
            // 
            this.cashierSale_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSale_quantity.HeaderText = "QUANTITY";
            this.cashierSale_quantity.Name = "cashierSale_quantity";
            this.cashierSale_quantity.Width = 86;
            // 
            // cashierSale_discount
            // 
            this.cashierSale_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSale_discount.HeaderText = "DISCOUNT";
            this.cashierSale_discount.Name = "cashierSale_discount";
            this.cashierSale_discount.Width = 87;
            // 
            // cashierSale_total
            // 
            this.cashierSale_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSale_total.HeaderText = "TOTAL";
            this.cashierSale_total.Name = "cashierSale_total";
            this.cashierSale_total.Width = 66;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_transactionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCashier_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSale_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSale_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSale_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSale_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSale_total;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_cashierName;
        private System.Windows.Forms.Label lbl_dateFilter;
        private System.Windows.Forms.Button btn_printSales;
        private System.Windows.Forms.Label lbl_from;
        public System.Windows.Forms.ComboBox cb_cashierName;
        public System.Windows.Forms.DateTimePicker dtp_to;
        public System.Windows.Forms.DateTimePicker dtp_from;
        public System.Windows.Forms.TextBox tb_salesTotal;
    }
}