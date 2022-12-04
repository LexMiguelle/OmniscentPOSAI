namespace OmniscentPOSAI
{
    partial class form_cashierSales
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
            this.panel_cashierSalesHead = new System.Windows.Forms.Panel();
            this.btn_closeCashierSales = new System.Windows.Forms.Button();
            this.panel_cashierSales = new System.Windows.Forms.Panel();
            this.tb_totalSales = new System.Windows.Forms.TextBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_dateFilter = new System.Windows.Forms.Label();
            this.testMe = new System.Windows.Forms.Label();
            this.lbl_cashierSales = new System.Windows.Forms.Label();
            this.dgv_cashierSales = new System.Windows.Forms.DataGridView();
            this.cashierSales_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_transactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierSales_cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_cashierSalesHead.SuspendLayout();
            this.panel_cashierSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cashierSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cashierSalesHead
            // 
            this.panel_cashierSalesHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cashierSalesHead.Controls.Add(this.btn_closeCashierSales);
            this.panel_cashierSalesHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cashierSalesHead.ForeColor = System.Drawing.Color.White;
            this.panel_cashierSalesHead.Location = new System.Drawing.Point(0, 0);
            this.panel_cashierSalesHead.Name = "panel_cashierSalesHead";
            this.panel_cashierSalesHead.Size = new System.Drawing.Size(922, 30);
            this.panel_cashierSalesHead.TabIndex = 4;
            // 
            // btn_closeCashierSales
            // 
            this.btn_closeCashierSales.BackColor = System.Drawing.Color.Red;
            this.btn_closeCashierSales.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeCashierSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeCashierSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeCashierSales.ForeColor = System.Drawing.Color.White;
            this.btn_closeCashierSales.Location = new System.Drawing.Point(890, 0);
            this.btn_closeCashierSales.Name = "btn_closeCashierSales";
            this.btn_closeCashierSales.Size = new System.Drawing.Size(30, 28);
            this.btn_closeCashierSales.TabIndex = 1;
            this.btn_closeCashierSales.Text = "X";
            this.btn_closeCashierSales.UseVisualStyleBackColor = false;
            this.btn_closeCashierSales.Click += new System.EventHandler(this.btn_closeCashierSales_Click);
            // 
            // panel_cashierSales
            // 
            this.panel_cashierSales.Controls.Add(this.tb_totalSales);
            this.panel_cashierSales.Controls.Add(this.dtp_to);
            this.panel_cashierSales.Controls.Add(this.dtp_from);
            this.panel_cashierSales.Controls.Add(this.lbl_to);
            this.panel_cashierSales.Controls.Add(this.lbl_from);
            this.panel_cashierSales.Controls.Add(this.lbl_dateFilter);
            this.panel_cashierSales.Controls.Add(this.testMe);
            this.panel_cashierSales.Controls.Add(this.lbl_cashierSales);
            this.panel_cashierSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cashierSales.Location = new System.Drawing.Point(0, 30);
            this.panel_cashierSales.Name = "panel_cashierSales";
            this.panel_cashierSales.Size = new System.Drawing.Size(922, 75);
            this.panel_cashierSales.TabIndex = 5;
            // 
            // tb_totalSales
            // 
            this.tb_totalSales.BackColor = System.Drawing.Color.Black;
            this.tb_totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalSales.ForeColor = System.Drawing.Color.Lime;
            this.tb_totalSales.Location = new System.Drawing.Point(710, 11);
            this.tb_totalSales.Name = "tb_totalSales";
            this.tb_totalSales.Size = new System.Drawing.Size(200, 53);
            this.tb_totalSales.TabIndex = 4;
            this.tb_totalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(324, 42);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(200, 20);
            this.dtp_to.TabIndex = 2;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(324, 15);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(200, 20);
            this.dtp_from.TabIndex = 2;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(291, 46);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 1;
            this.lbl_to.Text = "To:";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(277, 19);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(41, 16);
            this.lbl_from.TabIndex = 1;
            this.lbl_from.Text = "From:";
            // 
            // lbl_dateFilter
            // 
            this.lbl_dateFilter.AutoSize = true;
            this.lbl_dateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateFilter.Location = new System.Drawing.Point(172, 15);
            this.lbl_dateFilter.Name = "lbl_dateFilter";
            this.lbl_dateFilter.Size = new System.Drawing.Size(99, 20);
            this.lbl_dateFilter.TabIndex = 1;
            this.lbl_dateFilter.Text = "Date Filter:";
            // 
            // testMe
            // 
            this.testMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.testMe.AutoSize = true;
            this.testMe.BackColor = System.Drawing.Color.Transparent;
            this.testMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMe.ForeColor = System.Drawing.Color.White;
            this.testMe.Location = new System.Drawing.Point(563, 20);
            this.testMe.Name = "testMe";
            this.testMe.Size = new System.Drawing.Size(87, 31);
            this.testMe.TabIndex = 0;
            this.testMe.Text = "Sales";
            // 
            // lbl_cashierSales
            // 
            this.lbl_cashierSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_cashierSales.AutoSize = true;
            this.lbl_cashierSales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cashierSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashierSales.ForeColor = System.Drawing.Color.White;
            this.lbl_cashierSales.Location = new System.Drawing.Point(24, 20);
            this.lbl_cashierSales.Name = "lbl_cashierSales";
            this.lbl_cashierSales.Size = new System.Drawing.Size(87, 31);
            this.lbl_cashierSales.TabIndex = 0;
            this.lbl_cashierSales.Text = "Sales";
            // 
            // dgv_cashierSales
            // 
            this.dgv_cashierSales.AllowUserToAddRows = false;
            this.dgv_cashierSales.AllowUserToResizeColumns = false;
            this.dgv_cashierSales.AllowUserToResizeRows = false;
            this.dgv_cashierSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cashierSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cashierSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_cashierSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cashierSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cashierSales_num,
            this.cashierSales_ID,
            this.cashierSales_transactionNo,
            this.cashierSales_productID,
            this.cashierSales_productName,
            this.cashierSales_price,
            this.cashierSales_quantity,
            this.cashierSales_discount,
            this.cashierSales_total,
            this.cashierSales_cancel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cashierSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cashierSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cashierSales.EnableHeadersVisualStyles = false;
            this.dgv_cashierSales.GridColor = System.Drawing.Color.Black;
            this.dgv_cashierSales.Location = new System.Drawing.Point(0, 105);
            this.dgv_cashierSales.MultiSelect = false;
            this.dgv_cashierSales.Name = "dgv_cashierSales";
            this.dgv_cashierSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cashierSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_cashierSales.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_cashierSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cashierSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cashierSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_cashierSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_cashierSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_cashierSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cashierSales.Size = new System.Drawing.Size(922, 440);
            this.dgv_cashierSales.TabIndex = 6;
            this.dgv_cashierSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cashierSales_CellContentClick);
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
            this.cashierSales_ID.Width = 42;
            // 
            // cashierSales_transactionNo
            // 
            this.cashierSales_transactionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_transactionNo.HeaderText = "TRANSACTION NO.";
            this.cashierSales_transactionNo.Name = "cashierSales_transactionNo";
            this.cashierSales_transactionNo.Width = 119;
            // 
            // cashierSales_productID
            // 
            this.cashierSales_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_productID.HeaderText = "PRODUCT ID";
            this.cashierSales_productID.Name = "cashierSales_productID";
            this.cashierSales_productID.Width = 90;
            // 
            // cashierSales_productName
            // 
            this.cashierSales_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cashierSales_productName.HeaderText = "PRODUCT";
            this.cashierSales_productName.Name = "cashierSales_productName";
            // 
            // cashierSales_price
            // 
            this.cashierSales_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_price.HeaderText = "PRICE";
            this.cashierSales_price.Name = "cashierSales_price";
            this.cashierSales_price.Width = 63;
            // 
            // cashierSales_quantity
            // 
            this.cashierSales_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_quantity.HeaderText = "QUANTITY";
            this.cashierSales_quantity.Name = "cashierSales_quantity";
            this.cashierSales_quantity.Width = 86;
            // 
            // cashierSales_discount
            // 
            this.cashierSales_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_discount.HeaderText = "DISCOUNT";
            this.cashierSales_discount.Name = "cashierSales_discount";
            this.cashierSales_discount.Width = 87;
            // 
            // cashierSales_total
            // 
            this.cashierSales_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cashierSales_total.HeaderText = "TOTAL";
            this.cashierSales_total.Name = "cashierSales_total";
            this.cashierSales_total.Width = 66;
            // 
            // cashierSales_cancel
            // 
            this.cashierSales_cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cashierSales_cancel.HeaderText = "";
            this.cashierSales_cancel.Image = global::OmniscentPOSAI.Properties.Resources.cross_small_16;
            this.cashierSales_cancel.MinimumWidth = 25;
            this.cashierSales_cancel.Name = "cashierSales_cancel";
            this.cashierSales_cancel.Width = 25;
            // 
            // form_cashierSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(922, 545);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_cashierSales);
            this.Controls.Add(this.panel_cashierSales);
            this.Controls.Add(this.panel_cashierSalesHead);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_cashierSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_cashierSalesHead.ResumeLayout(false);
            this.panel_cashierSales.ResumeLayout(false);
            this.panel_cashierSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cashierSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cashierSalesHead;
        private System.Windows.Forms.Button btn_closeCashierSales;
        private System.Windows.Forms.Panel panel_cashierSales;
        private System.Windows.Forms.Label lbl_cashierSales;
        private System.Windows.Forms.DataGridView dgv_cashierSales;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_dateFilter;
        private System.Windows.Forms.TextBox tb_totalSales;
        private System.Windows.Forms.Label testMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_transactionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierSales_total;
        private System.Windows.Forms.DataGridViewImageColumn cashierSales_cancel;
    }
}