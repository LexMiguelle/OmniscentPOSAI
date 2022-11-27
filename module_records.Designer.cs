namespace OmniscentPOSAI
{
    partial class module_records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_records = new System.Windows.Forms.TabControl();
            this.tp_topSelling = new System.Windows.Forms.TabPage();
            this.tp_soldItems = new System.Windows.Forms.TabPage();
            this.tp_criticalSotcks = new System.Windows.Forms.TabPage();
            this.tp_inventoryList = new System.Windows.Forms.TabPage();
            this.tp_returnedItems = new System.Windows.Forms.TabPage();
            this.tp_cancelledOrders = new System.Windows.Forms.TabPage();
            this.tp_stockHistory = new System.Windows.Forms.TabPage();
            this.dgv_stockHistory = new System.Windows.Forms.DataGridView();
            this.stockOverview_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_referenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_stockHistoryHead = new System.Windows.Forms.Panel();
            this.lbl_stockHistory = new System.Windows.Forms.Label();
            this.panel_stockHistoryFoot = new System.Windows.Forms.Panel();
            this.panel_dateFilter = new System.Windows.Forms.Panel();
            this.btn_printStockHistory = new System.Windows.Forms.Button();
            this.btn_loadStocks = new System.Windows.Forms.Button();
            this.lbl_dateFilter = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tc_records.SuspendLayout();
            this.tp_stockHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockHistory)).BeginInit();
            this.panel_stockHistoryHead.SuspendLayout();
            this.panel_stockHistoryFoot.SuspendLayout();
            this.panel_dateFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 75);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Records";
            // 
            // tc_records
            // 
            this.tc_records.Controls.Add(this.tp_topSelling);
            this.tc_records.Controls.Add(this.tp_soldItems);
            this.tc_records.Controls.Add(this.tp_criticalSotcks);
            this.tc_records.Controls.Add(this.tp_inventoryList);
            this.tc_records.Controls.Add(this.tp_returnedItems);
            this.tc_records.Controls.Add(this.tp_cancelledOrders);
            this.tc_records.Controls.Add(this.tp_stockHistory);
            this.tc_records.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_records.Location = new System.Drawing.Point(0, 75);
            this.tc_records.Name = "tc_records";
            this.tc_records.SelectedIndex = 0;
            this.tc_records.Size = new System.Drawing.Size(1064, 661);
            this.tc_records.TabIndex = 4;
            // 
            // tp_topSelling
            // 
            this.tp_topSelling.BackColor = System.Drawing.Color.Black;
            this.tp_topSelling.ForeColor = System.Drawing.Color.White;
            this.tp_topSelling.Location = new System.Drawing.Point(4, 22);
            this.tp_topSelling.Name = "tp_topSelling";
            this.tp_topSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tp_topSelling.Size = new System.Drawing.Size(1056, 635);
            this.tp_topSelling.TabIndex = 0;
            this.tp_topSelling.Text = "Top Selling";
            // 
            // tp_soldItems
            // 
            this.tp_soldItems.Location = new System.Drawing.Point(4, 22);
            this.tp_soldItems.Name = "tp_soldItems";
            this.tp_soldItems.Padding = new System.Windows.Forms.Padding(3);
            this.tp_soldItems.Size = new System.Drawing.Size(1056, 635);
            this.tp_soldItems.TabIndex = 1;
            this.tp_soldItems.Text = "Sold Items";
            this.tp_soldItems.UseVisualStyleBackColor = true;
            // 
            // tp_criticalSotcks
            // 
            this.tp_criticalSotcks.Location = new System.Drawing.Point(4, 22);
            this.tp_criticalSotcks.Name = "tp_criticalSotcks";
            this.tp_criticalSotcks.Padding = new System.Windows.Forms.Padding(3);
            this.tp_criticalSotcks.Size = new System.Drawing.Size(1056, 635);
            this.tp_criticalSotcks.TabIndex = 2;
            this.tp_criticalSotcks.Text = "Critiical Stocks";
            this.tp_criticalSotcks.UseVisualStyleBackColor = true;
            // 
            // tp_inventoryList
            // 
            this.tp_inventoryList.Location = new System.Drawing.Point(4, 22);
            this.tp_inventoryList.Name = "tp_inventoryList";
            this.tp_inventoryList.Padding = new System.Windows.Forms.Padding(3);
            this.tp_inventoryList.Size = new System.Drawing.Size(1056, 635);
            this.tp_inventoryList.TabIndex = 3;
            this.tp_inventoryList.Text = "Inventory List";
            this.tp_inventoryList.UseVisualStyleBackColor = true;
            // 
            // tp_returnedItems
            // 
            this.tp_returnedItems.Location = new System.Drawing.Point(4, 22);
            this.tp_returnedItems.Name = "tp_returnedItems";
            this.tp_returnedItems.Padding = new System.Windows.Forms.Padding(3);
            this.tp_returnedItems.Size = new System.Drawing.Size(1056, 635);
            this.tp_returnedItems.TabIndex = 4;
            this.tp_returnedItems.Text = "Returned Items";
            this.tp_returnedItems.UseVisualStyleBackColor = true;
            // 
            // tp_cancelledOrders
            // 
            this.tp_cancelledOrders.BackColor = System.Drawing.Color.Black;
            this.tp_cancelledOrders.ForeColor = System.Drawing.Color.White;
            this.tp_cancelledOrders.Location = new System.Drawing.Point(4, 22);
            this.tp_cancelledOrders.Name = "tp_cancelledOrders";
            this.tp_cancelledOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cancelledOrders.Size = new System.Drawing.Size(1056, 635);
            this.tp_cancelledOrders.TabIndex = 5;
            this.tp_cancelledOrders.Text = "Cancelled Orders";
            // 
            // tp_stockHistory
            // 
            this.tp_stockHistory.BackColor = System.Drawing.Color.Black;
            this.tp_stockHistory.Controls.Add(this.panel_stockHistoryFoot);
            this.tp_stockHistory.Controls.Add(this.panel_stockHistoryHead);
            this.tp_stockHistory.Controls.Add(this.dgv_stockHistory);
            this.tp_stockHistory.Location = new System.Drawing.Point(4, 22);
            this.tp_stockHistory.Name = "tp_stockHistory";
            this.tp_stockHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tp_stockHistory.Size = new System.Drawing.Size(1056, 635);
            this.tp_stockHistory.TabIndex = 6;
            this.tp_stockHistory.Text = "Stocks History";
            // 
            // dgv_stockHistory
            // 
            this.dgv_stockHistory.AllowUserToAddRows = false;
            this.dgv_stockHistory.AllowUserToDeleteRows = false;
            this.dgv_stockHistory.AllowUserToResizeColumns = false;
            this.dgv_stockHistory.AllowUserToResizeRows = false;
            this.dgv_stockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stockHistory.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_stockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_stockHistory.ColumnHeadersHeight = 25;
            this.dgv_stockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockOverview_num,
            this.stockOverview_referenceNo,
            this.stockOverview_productID,
            this.stockOverview_productName,
            this.stockOverview_category,
            this.stockOverview_quantity,
            this.stockOverview_date,
            this.stockOverview_status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stockHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_stockHistory.EnableHeadersVisualStyles = false;
            this.dgv_stockHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_stockHistory.Location = new System.Drawing.Point(8, 84);
            this.dgv_stockHistory.Name = "dgv_stockHistory";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_stockHistory.RowHeadersVisible = false;
            this.dgv_stockHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stockHistory.Size = new System.Drawing.Size(1040, 440);
            this.dgv_stockHistory.TabIndex = 3;
            // 
            // stockOverview_num
            // 
            this.stockOverview_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stockOverview_num.HeaderText = "#";
            this.stockOverview_num.MinimumWidth = 25;
            this.stockOverview_num.Name = "stockOverview_num";
            this.stockOverview_num.Width = 25;
            // 
            // stockOverview_referenceNo
            // 
            this.stockOverview_referenceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_referenceNo.FillWeight = 90.14085F;
            this.stockOverview_referenceNo.HeaderText = "REFERENCE NO.";
            this.stockOverview_referenceNo.Name = "stockOverview_referenceNo";
            this.stockOverview_referenceNo.Width = 117;
            // 
            // stockOverview_productID
            // 
            this.stockOverview_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_productID.FillWeight = 90.14085F;
            this.stockOverview_productID.HeaderText = "PRODUCT ID";
            this.stockOverview_productID.Name = "stockOverview_productID";
            this.stockOverview_productID.Width = 97;
            // 
            // stockOverview_productName
            // 
            this.stockOverview_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockOverview_productName.FillWeight = 90.14085F;
            this.stockOverview_productName.HeaderText = "PRODUCT";
            this.stockOverview_productName.Name = "stockOverview_productName";
            // 
            // stockOverview_category
            // 
            this.stockOverview_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_category.FillWeight = 90.14085F;
            this.stockOverview_category.HeaderText = "CATEGORY";
            this.stockOverview_category.Name = "stockOverview_category";
            this.stockOverview_category.Width = 89;
            // 
            // stockOverview_quantity
            // 
            this.stockOverview_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_quantity.FillWeight = 90.14085F;
            this.stockOverview_quantity.HeaderText = "QUANTITY";
            this.stockOverview_quantity.Name = "stockOverview_quantity";
            this.stockOverview_quantity.Width = 85;
            // 
            // stockOverview_date
            // 
            this.stockOverview_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_date.FillWeight = 90.14085F;
            this.stockOverview_date.HeaderText = "DATE";
            this.stockOverview_date.Name = "stockOverview_date";
            this.stockOverview_date.Width = 59;
            // 
            // stockOverview_status
            // 
            this.stockOverview_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stockOverview_status.FillWeight = 90.14085F;
            this.stockOverview_status.HeaderText = "STATUS";
            this.stockOverview_status.Name = "stockOverview_status";
            this.stockOverview_status.Width = 73;
            // 
            // panel_stockHistoryHead
            // 
            this.panel_stockHistoryHead.Controls.Add(this.lbl_stockHistory);
            this.panel_stockHistoryHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stockHistoryHead.Location = new System.Drawing.Point(3, 3);
            this.panel_stockHistoryHead.Name = "panel_stockHistoryHead";
            this.panel_stockHistoryHead.Size = new System.Drawing.Size(1050, 75);
            this.panel_stockHistoryHead.TabIndex = 4;
            // 
            // lbl_stockHistory
            // 
            this.lbl_stockHistory.AutoSize = true;
            this.lbl_stockHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockHistory.ForeColor = System.Drawing.Color.White;
            this.lbl_stockHistory.Location = new System.Drawing.Point(18, 21);
            this.lbl_stockHistory.Name = "lbl_stockHistory";
            this.lbl_stockHistory.Size = new System.Drawing.Size(189, 31);
            this.lbl_stockHistory.TabIndex = 0;
            this.lbl_stockHistory.Text = "Stock History";
            // 
            // panel_stockHistoryFoot
            // 
            this.panel_stockHistoryFoot.Controls.Add(this.btn_printStockHistory);
            this.panel_stockHistoryFoot.Controls.Add(this.panel_dateFilter);
            this.panel_stockHistoryFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_stockHistoryFoot.Location = new System.Drawing.Point(3, 532);
            this.panel_stockHistoryFoot.Name = "panel_stockHistoryFoot";
            this.panel_stockHistoryFoot.Size = new System.Drawing.Size(1050, 100);
            this.panel_stockHistoryFoot.TabIndex = 5;
            // 
            // panel_dateFilter
            // 
            this.panel_dateFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_dateFilter.Controls.Add(this.dtp_to);
            this.panel_dateFilter.Controls.Add(this.dtp_from);
            this.panel_dateFilter.Controls.Add(this.lbl_from);
            this.panel_dateFilter.Controls.Add(this.lbl_to);
            this.panel_dateFilter.Controls.Add(this.lbl_dateFilter);
            this.panel_dateFilter.Controls.Add(this.btn_loadStocks);
            this.panel_dateFilter.Location = new System.Drawing.Point(9, 11);
            this.panel_dateFilter.Name = "panel_dateFilter";
            this.panel_dateFilter.Size = new System.Drawing.Size(765, 80);
            this.panel_dateFilter.TabIndex = 0;
            // 
            // btn_printStockHistory
            // 
            this.btn_printStockHistory.BackColor = System.Drawing.Color.Green;
            this.btn_printStockHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printStockHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printStockHistory.Location = new System.Drawing.Point(841, 30);
            this.btn_printStockHistory.Name = "btn_printStockHistory";
            this.btn_printStockHistory.Size = new System.Drawing.Size(150, 40);
            this.btn_printStockHistory.TabIndex = 1;
            this.btn_printStockHistory.Text = "Print";
            this.btn_printStockHistory.UseVisualStyleBackColor = false;
            // 
            // btn_loadStocks
            // 
            this.btn_loadStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_loadStocks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_loadStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadStocks.ForeColor = System.Drawing.Color.Black;
            this.btn_loadStocks.Location = new System.Drawing.Point(590, 19);
            this.btn_loadStocks.Name = "btn_loadStocks";
            this.btn_loadStocks.Size = new System.Drawing.Size(150, 40);
            this.btn_loadStocks.TabIndex = 1;
            this.btn_loadStocks.Text = "Load";
            this.btn_loadStocks.UseVisualStyleBackColor = false;
            // 
            // lbl_dateFilter
            // 
            this.lbl_dateFilter.AutoSize = true;
            this.lbl_dateFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateFilter.ForeColor = System.Drawing.Color.White;
            this.lbl_dateFilter.Location = new System.Drawing.Point(11, 9);
            this.lbl_dateFilter.Name = "lbl_dateFilter";
            this.lbl_dateFilter.Size = new System.Drawing.Size(111, 24);
            this.lbl_dateFilter.TabIndex = 0;
            this.lbl_dateFilter.Text = "Date Filter:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(222, 50);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 16);
            this.lbl_to.TabIndex = 0;
            this.lbl_to.Text = "To:";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.White;
            this.lbl_from.Location = new System.Drawing.Point(206, 17);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(46, 16);
            this.lbl_from.TabIndex = 0;
            this.lbl_from.Text = "From:";
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Location = new System.Drawing.Point(258, 13);
            this.dtp_from.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(300, 22);
            this.dtp_from.TabIndex = 2;
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Location = new System.Drawing.Point(258, 44);
            this.dtp_to.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(300, 22);
            this.dtp_to.TabIndex = 3;
            // 
            // module_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1064, 736);
            this.ControlBox = false;
            this.Controls.Add(this.tc_records);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_records";
            this.Text = "module_records";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tc_records.ResumeLayout(false);
            this.tp_stockHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockHistory)).EndInit();
            this.panel_stockHistoryHead.ResumeLayout(false);
            this.panel_stockHistoryHead.PerformLayout();
            this.panel_stockHistoryFoot.ResumeLayout(false);
            this.panel_dateFilter.ResumeLayout(false);
            this.panel_dateFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tc_records;
        private System.Windows.Forms.TabPage tp_topSelling;
        private System.Windows.Forms.TabPage tp_soldItems;
        private System.Windows.Forms.TabPage tp_criticalSotcks;
        private System.Windows.Forms.TabPage tp_inventoryList;
        private System.Windows.Forms.TabPage tp_returnedItems;
        private System.Windows.Forms.TabPage tp_cancelledOrders;
        private System.Windows.Forms.TabPage tp_stockHistory;
        private System.Windows.Forms.Panel panel_stockHistoryFoot;
        private System.Windows.Forms.Button btn_printStockHistory;
        private System.Windows.Forms.Panel panel_dateFilter;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_dateFilter;
        private System.Windows.Forms.Button btn_loadStocks;
        private System.Windows.Forms.Panel panel_stockHistoryHead;
        private System.Windows.Forms.Label lbl_stockHistory;
        private System.Windows.Forms.DataGridView dgv_stockHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_referenceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOverview_status;
    }
}