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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_stockHistory = new System.Windows.Forms.TabPage();
            this.panel_stockHistoryFoot = new System.Windows.Forms.Panel();
            this.btn_printStockHistory = new System.Windows.Forms.Button();
            this.panel_dateFilter = new System.Windows.Forms.Panel();
            this.dtp_stockHistoryTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_stockHistoryFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_dateFilter = new System.Windows.Forms.Label();
            this.panel_stockHistoryHead = new System.Windows.Forms.Panel();
            this.lbl_stockHistory = new System.Windows.Forms.Label();
            this.dgv_stockHistory = new System.Windows.Forms.DataGridView();
            this.stockOverview_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_referenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOverview_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_cancelledOrders = new System.Windows.Forms.TabPage();
            this.tp_returnedItems = new System.Windows.Forms.TabPage();
            this.tp_inventoryList = new System.Windows.Forms.TabPage();
            this.tp_criticalSotcks = new System.Windows.Forms.TabPage();
            this.tp_topSelling = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tc_records = new System.Windows.Forms.TabControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_topSelling = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtp_topTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_topFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.top_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tp_stockHistory.SuspendLayout();
            this.panel_stockHistoryFoot.SuspendLayout();
            this.panel_dateFilter.SuspendLayout();
            this.panel_stockHistoryHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockHistory)).BeginInit();
            this.tp_topSelling.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tc_records.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topSelling)).BeginInit();
            this.panel5.SuspendLayout();
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
            // btn_printStockHistory
            // 
            this.btn_printStockHistory.BackColor = System.Drawing.Color.Green;
            this.btn_printStockHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_printStockHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printStockHistory.Location = new System.Drawing.Point(838, 26);
            this.btn_printStockHistory.Name = "btn_printStockHistory";
            this.btn_printStockHistory.Size = new System.Drawing.Size(150, 40);
            this.btn_printStockHistory.TabIndex = 1;
            this.btn_printStockHistory.Text = "Print";
            this.btn_printStockHistory.UseVisualStyleBackColor = false;
            this.btn_printStockHistory.Click += new System.EventHandler(this.btn_printStockHistory_Click);
            // 
            // panel_dateFilter
            // 
            this.panel_dateFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_dateFilter.Controls.Add(this.dtp_stockHistoryTo);
            this.panel_dateFilter.Controls.Add(this.dtp_stockHistoryFrom);
            this.panel_dateFilter.Controls.Add(this.lbl_from);
            this.panel_dateFilter.Controls.Add(this.lbl_to);
            this.panel_dateFilter.Controls.Add(this.lbl_dateFilter);
            this.panel_dateFilter.Location = new System.Drawing.Point(9, 11);
            this.panel_dateFilter.Name = "panel_dateFilter";
            this.panel_dateFilter.Size = new System.Drawing.Size(513, 80);
            this.panel_dateFilter.TabIndex = 0;
            // 
            // dtp_stockHistoryTo
            // 
            this.dtp_stockHistoryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stockHistoryTo.Location = new System.Drawing.Point(196, 46);
            this.dtp_stockHistoryTo.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_stockHistoryTo.Name = "dtp_stockHistoryTo";
            this.dtp_stockHistoryTo.Size = new System.Drawing.Size(300, 22);
            this.dtp_stockHistoryTo.TabIndex = 3;
            this.dtp_stockHistoryTo.ValueChanged += new System.EventHandler(this.dtp_stockHistoryTo_ValueChanged);
            // 
            // dtp_stockHistoryFrom
            // 
            this.dtp_stockHistoryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_stockHistoryFrom.Location = new System.Drawing.Point(196, 15);
            this.dtp_stockHistoryFrom.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_stockHistoryFrom.Name = "dtp_stockHistoryFrom";
            this.dtp_stockHistoryFrom.Size = new System.Drawing.Size(300, 22);
            this.dtp_stockHistoryFrom.TabIndex = 2;
            this.dtp_stockHistoryFrom.ValueChanged += new System.EventHandler(this.dtp_stockHistoryFrom_ValueChanged);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.Color.White;
            this.lbl_from.Location = new System.Drawing.Point(144, 19);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(46, 16);
            this.lbl_from.TabIndex = 0;
            this.lbl_from.Text = "From:";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.Color.White;
            this.lbl_to.Location = new System.Drawing.Point(160, 52);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(30, 16);
            this.lbl_to.TabIndex = 0;
            this.lbl_to.Text = "To:";
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
            // dgv_stockHistory
            // 
            this.dgv_stockHistory.AllowUserToAddRows = false;
            this.dgv_stockHistory.AllowUserToDeleteRows = false;
            this.dgv_stockHistory.AllowUserToResizeColumns = false;
            this.dgv_stockHistory.AllowUserToResizeRows = false;
            this.dgv_stockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stockHistory.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_stockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stockHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stockHistory.EnableHeadersVisualStyles = false;
            this.dgv_stockHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_stockHistory.Location = new System.Drawing.Point(8, 84);
            this.dgv_stockHistory.Name = "dgv_stockHistory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stockHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // tp_topSelling
            // 
            this.tp_topSelling.BackColor = System.Drawing.Color.Black;
            this.tp_topSelling.Controls.Add(this.dgv_topSelling);
            this.tp_topSelling.Controls.Add(this.panel4);
            this.tp_topSelling.Controls.Add(this.panel3);
            this.tp_topSelling.Controls.Add(this.panel2);
            this.tp_topSelling.ForeColor = System.Drawing.Color.White;
            this.tp_topSelling.Location = new System.Drawing.Point(4, 22);
            this.tp_topSelling.Name = "tp_topSelling";
            this.tp_topSelling.Padding = new System.Windows.Forms.Padding(3);
            this.tp_topSelling.Size = new System.Drawing.Size(1056, 635);
            this.tp_topSelling.TabIndex = 0;
            this.tp_topSelling.Text = "Top Selling";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 75);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Top Selling";
            // 
            // tc_records
            // 
            this.tc_records.Controls.Add(this.tp_topSelling);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 532);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(599, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 454);
            this.panel4.TabIndex = 7;
            // 
            // dgv_topSelling
            // 
            this.dgv_topSelling.AllowUserToAddRows = false;
            this.dgv_topSelling.AllowUserToDeleteRows = false;
            this.dgv_topSelling.AllowUserToResizeColumns = false;
            this.dgv_topSelling.AllowUserToResizeRows = false;
            this.dgv_topSelling.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_topSelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_topSelling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_topSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_topSelling.ColumnHeadersHeight = 25;
            this.dgv_topSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_topSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.top_num,
            this.top_ID,
            this.top_productName,
            this.top_quantity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_topSelling.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_topSelling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_topSelling.EnableHeadersVisualStyles = false;
            this.dgv_topSelling.Location = new System.Drawing.Point(3, 78);
            this.dgv_topSelling.Name = "dgv_topSelling";
            this.dgv_topSelling.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_topSelling.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_topSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_topSelling.Size = new System.Drawing.Size(596, 454);
            this.dgv_topSelling.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.dtp_topTo);
            this.panel5.Controls.Add(this.dtp_topFrom);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(11, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(513, 80);
            this.panel5.TabIndex = 1;
            // 
            // dtp_topTo
            // 
            this.dtp_topTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_topTo.Location = new System.Drawing.Point(196, 46);
            this.dtp_topTo.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_topTo.Name = "dtp_topTo";
            this.dtp_topTo.Size = new System.Drawing.Size(300, 22);
            this.dtp_topTo.TabIndex = 3;
            this.dtp_topTo.ValueChanged += new System.EventHandler(this.dtp_topTo_ValueChanged);
            // 
            // dtp_topFrom
            // 
            this.dtp_topFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_topFrom.Location = new System.Drawing.Point(196, 15);
            this.dtp_topFrom.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_topFrom.Name = "dtp_topFrom";
            this.dtp_topFrom.Size = new System.Drawing.Size(300, 22);
            this.dtp_topFrom.TabIndex = 2;
            this.dtp_topFrom.ValueChanged += new System.EventHandler(this.dtp_topFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(144, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(160, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Filter:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // top_num
            // 
            this.top_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.top_num.HeaderText = "#";
            this.top_num.MinimumWidth = 30;
            this.top_num.Name = "top_num";
            this.top_num.ReadOnly = true;
            this.top_num.Width = 30;
            // 
            // top_ID
            // 
            this.top_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.top_ID.HeaderText = "PRODUCT ID";
            this.top_ID.Name = "top_ID";
            this.top_ID.ReadOnly = true;
            this.top_ID.Width = 98;
            // 
            // top_productName
            // 
            this.top_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.top_productName.HeaderText = "PRODUCT";
            this.top_productName.Name = "top_productName";
            this.top_productName.ReadOnly = true;
            // 
            // top_quantity
            // 
            this.top_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.top_quantity.HeaderText = "QUANTITY";
            this.top_quantity.Name = "top_quantity";
            this.top_quantity.ReadOnly = true;
            this.top_quantity.Width = 86;
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
            this.tp_stockHistory.ResumeLayout(false);
            this.panel_stockHistoryFoot.ResumeLayout(false);
            this.panel_dateFilter.ResumeLayout(false);
            this.panel_dateFilter.PerformLayout();
            this.panel_stockHistoryHead.ResumeLayout(false);
            this.panel_stockHistoryHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockHistory)).EndInit();
            this.tp_topSelling.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tc_records.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_topSelling)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_stockHistory;
        private System.Windows.Forms.Panel panel_stockHistoryFoot;
        private System.Windows.Forms.Button btn_printStockHistory;
        private System.Windows.Forms.Panel panel_dateFilter;
        private System.Windows.Forms.DateTimePicker dtp_stockHistoryTo;
        private System.Windows.Forms.DateTimePicker dtp_stockHistoryFrom;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_dateFilter;
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
        private System.Windows.Forms.TabPage tp_cancelledOrders;
        private System.Windows.Forms.TabPage tp_returnedItems;
        private System.Windows.Forms.TabPage tp_inventoryList;
        private System.Windows.Forms.TabPage tp_criticalSotcks;
        private System.Windows.Forms.TabPage tp_topSelling;
        private System.Windows.Forms.TabControl tc_records;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_topSelling;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtp_topTo;
        private System.Windows.Forms.DateTimePicker dtp_topFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn top_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn top_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn top_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn top_quantity;
    }
}