namespace OmniscentPOSAI
{
    partial class module_cashier
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_cashierHead = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_cashierInfo = new System.Windows.Forms.Panel();
            this.panel_dateTime = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_buttonMenu = new System.Windows.Forms.Panel();
            this.btn_settleTransaction = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_cashierSales = new System.Windows.Forms.Button();
            this.btn_checkPrice = new System.Windows.Forms.Button();
            this.btn_scanProductCode = new System.Windows.Forms.Button();
            this.btn_clearTransaction = new System.Windows.Forms.Button();
            this.btn_newTransaction = new System.Windows.Forms.Button();
            this.panel_invoice = new System.Windows.Forms.Panel();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.rv_invoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_compute = new System.Windows.Forms.Panel();
            this.subTotal = new System.Windows.Forms.Label();
            this.totalDiscount = new System.Windows.Forms.Label();
            this.totalVAT = new System.Windows.Forms.Label();
            this.totalVATable = new System.Windows.Forms.Label();
            this.lbl_totalVATable = new System.Windows.Forms.Label();
            this.lbl_totalVAT = new System.Windows.Forms.Label();
            this.lbl_totalDiscount = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addDiscount = new System.Windows.Forms.LinkLabel();
            this.btn_addProduct = new System.Windows.Forms.LinkLabel();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_transactionDate = new System.Windows.Forms.Label();
            this.transactionDate = new System.Windows.Forms.Label();
            this.transactionNo = new System.Windows.Forms.Label();
            this.lbl_transactionNo = new System.Windows.Forms.Label();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.cart_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_subtract = new System.Windows.Forms.DataGridViewImageColumn();
            this.cart_add = new System.Windows.Forms.DataGridViewImageColumn();
            this.cart_remove = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer_clock = new System.Windows.Forms.Timer(this.components);
            this.panel_cashierHead.SuspendLayout();
            this.panel_cashierInfo.SuspendLayout();
            this.panel_dateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_buttonMenu.SuspendLayout();
            this.panel_invoice.SuspendLayout();
            this.panel_preview.SuspendLayout();
            this.panel_compute.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cashierHead
            // 
            this.panel_cashierHead.Controls.Add(this.btn_close);
            this.panel_cashierHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cashierHead.Location = new System.Drawing.Point(0, 0);
            this.panel_cashierHead.Name = "panel_cashierHead";
            this.panel_cashierHead.Size = new System.Drawing.Size(1366, 30);
            this.panel_cashierHead.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1336, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_cashierInfo
            // 
            this.panel_cashierInfo.Controls.Add(this.panel_dateTime);
            this.panel_cashierInfo.Controls.Add(this.tb_username);
            this.panel_cashierInfo.Controls.Add(this.tb_role);
            this.panel_cashierInfo.Controls.Add(this.tb_name);
            this.panel_cashierInfo.Controls.Add(this.pictureBox1);
            this.panel_cashierInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cashierInfo.Location = new System.Drawing.Point(0, 30);
            this.panel_cashierInfo.Name = "panel_cashierInfo";
            this.panel_cashierInfo.Size = new System.Drawing.Size(1366, 100);
            this.panel_cashierInfo.TabIndex = 2;
            // 
            // panel_dateTime
            // 
            this.panel_dateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_dateTime.Controls.Add(this.lbl_date);
            this.panel_dateTime.Controls.Add(this.lbl_time);
            this.panel_dateTime.Location = new System.Drawing.Point(554, 12);
            this.panel_dateTime.Name = "panel_dateTime";
            this.panel_dateTime.Size = new System.Drawing.Size(800, 75);
            this.panel_dateTime.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(337, 28);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(445, 31);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "Wednesday, September 30, 2022";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(13, 10);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(303, 55);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "00:00:00 am";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Black;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tb_username.Location = new System.Drawing.Point(99, 46);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(227, 19);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "@username";
            this.tb_username.TextChanged += new System.EventHandler(this.tb_searchBox_TextChanged);
            // 
            // tb_role
            // 
            this.tb_role.BackColor = System.Drawing.Color.Black;
            this.tb_role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb_role.Location = new System.Drawing.Point(99, 71);
            this.tb_role.Name = "tb_role";
            this.tb_role.Size = new System.Drawing.Size(219, 19);
            this.tb_role.TabIndex = 2;
            this.tb_role.Text = "cashier";
            this.tb_role.TextChanged += new System.EventHandler(this.tb_searchBox_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.Black;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(99, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(310, 28);
            this.tb_name.TabIndex = 2;
            this.tb_name.Text = "Last name, First name ";
            this.tb_name.TextChanged += new System.EventHandler(this.tb_searchBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OmniscentPOSAI.Properties.Resources.omniscent_128;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_buttonMenu
            // 
            this.panel_buttonMenu.Controls.Add(this.btn_settleTransaction);
            this.panel_buttonMenu.Controls.Add(this.btn_settings);
            this.panel_buttonMenu.Controls.Add(this.btn_cashierSales);
            this.panel_buttonMenu.Controls.Add(this.btn_checkPrice);
            this.panel_buttonMenu.Controls.Add(this.btn_scanProductCode);
            this.panel_buttonMenu.Controls.Add(this.btn_clearTransaction);
            this.panel_buttonMenu.Controls.Add(this.btn_newTransaction);
            this.panel_buttonMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_buttonMenu.Location = new System.Drawing.Point(0, 668);
            this.panel_buttonMenu.Name = "panel_buttonMenu";
            this.panel_buttonMenu.Size = new System.Drawing.Size(1366, 100);
            this.panel_buttonMenu.TabIndex = 3;
            // 
            // btn_settleTransaction
            // 
            this.btn_settleTransaction.BackColor = System.Drawing.Color.Green;
            this.btn_settleTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_settleTransaction.Enabled = false;
            this.btn_settleTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_settleTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settleTransaction.Location = new System.Drawing.Point(966, 0);
            this.btn_settleTransaction.Name = "btn_settleTransaction";
            this.btn_settleTransaction.Size = new System.Drawing.Size(400, 100);
            this.btn_settleTransaction.TabIndex = 0;
            this.btn_settleTransaction.Text = "Settle Transaction";
            this.btn_settleTransaction.UseVisualStyleBackColor = false;
            this.btn_settleTransaction.Click += new System.EventHandler(this.btn_settleTransaction_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_settings.ForeColor = System.Drawing.Color.Black;
            this.btn_settings.Location = new System.Drawing.Point(792, 23);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(150, 50);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_cashierSales
            // 
            this.btn_cashierSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_cashierSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cashierSales.ForeColor = System.Drawing.Color.Black;
            this.btn_cashierSales.Location = new System.Drawing.Point(636, 23);
            this.btn_cashierSales.Name = "btn_cashierSales";
            this.btn_cashierSales.Size = new System.Drawing.Size(150, 50);
            this.btn_cashierSales.TabIndex = 0;
            this.btn_cashierSales.Text = "Sales";
            this.btn_cashierSales.UseVisualStyleBackColor = false;
            this.btn_cashierSales.Click += new System.EventHandler(this.btn_cashierSales_Click);
            // 
            // btn_checkPrice
            // 
            this.btn_checkPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_checkPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkPrice.ForeColor = System.Drawing.Color.Black;
            this.btn_checkPrice.Location = new System.Drawing.Point(480, 23);
            this.btn_checkPrice.Name = "btn_checkPrice";
            this.btn_checkPrice.Size = new System.Drawing.Size(150, 50);
            this.btn_checkPrice.TabIndex = 0;
            this.btn_checkPrice.Text = "Check Price";
            this.btn_checkPrice.UseVisualStyleBackColor = false;
            this.btn_checkPrice.Click += new System.EventHandler(this.btn_checkPrice_Click);
            // 
            // btn_scanProductCode
            // 
            this.btn_scanProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_scanProductCode.Enabled = false;
            this.btn_scanProductCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_scanProductCode.ForeColor = System.Drawing.Color.Black;
            this.btn_scanProductCode.Location = new System.Drawing.Point(324, 23);
            this.btn_scanProductCode.Name = "btn_scanProductCode";
            this.btn_scanProductCode.Size = new System.Drawing.Size(150, 50);
            this.btn_scanProductCode.TabIndex = 0;
            this.btn_scanProductCode.Text = "Scan Product Code";
            this.btn_scanProductCode.UseVisualStyleBackColor = false;
            this.btn_scanProductCode.Click += new System.EventHandler(this.btn_scanBarcode_Click);
            // 
            // btn_clearTransaction
            // 
            this.btn_clearTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_clearTransaction.Enabled = false;
            this.btn_clearTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearTransaction.ForeColor = System.Drawing.Color.Black;
            this.btn_clearTransaction.Location = new System.Drawing.Point(168, 23);
            this.btn_clearTransaction.Name = "btn_clearTransaction";
            this.btn_clearTransaction.Size = new System.Drawing.Size(150, 50);
            this.btn_clearTransaction.TabIndex = 0;
            this.btn_clearTransaction.Text = "Clear Transaction";
            this.btn_clearTransaction.UseVisualStyleBackColor = false;
            this.btn_clearTransaction.Click += new System.EventHandler(this.btn_clearTransaction_Click);
            // 
            // btn_newTransaction
            // 
            this.btn_newTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_newTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newTransaction.ForeColor = System.Drawing.Color.Black;
            this.btn_newTransaction.Location = new System.Drawing.Point(12, 23);
            this.btn_newTransaction.Name = "btn_newTransaction";
            this.btn_newTransaction.Size = new System.Drawing.Size(150, 50);
            this.btn_newTransaction.TabIndex = 0;
            this.btn_newTransaction.Text = "New Transaction";
            this.btn_newTransaction.UseVisualStyleBackColor = false;
            this.btn_newTransaction.Click += new System.EventHandler(this.btn_newTransaction_Click);
            // 
            // panel_invoice
            // 
            this.panel_invoice.Controls.Add(this.totalAmount);
            this.panel_invoice.Controls.Add(this.panel_preview);
            this.panel_invoice.Controls.Add(this.panel_compute);
            this.panel_invoice.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_invoice.Location = new System.Drawing.Point(966, 130);
            this.panel_invoice.Name = "panel_invoice";
            this.panel_invoice.Size = new System.Drawing.Size(400, 538);
            this.panel_invoice.TabIndex = 4;
            // 
            // totalAmount
            // 
            this.totalAmount.BackColor = System.Drawing.Color.Black;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.Lime;
            this.totalAmount.Location = new System.Drawing.Point(6, 457);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.ReadOnly = true;
            this.totalAmount.Size = new System.Drawing.Size(386, 75);
            this.totalAmount.TabIndex = 2;
            this.totalAmount.Text = "0.00";
            this.totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalAmount.TextChanged += new System.EventHandler(this.totalAmount_TextChanged);
            // 
            // panel_preview
            // 
            this.panel_preview.Controls.Add(this.rv_invoice);
            this.panel_preview.Location = new System.Drawing.Point(7, 6);
            this.panel_preview.Name = "panel_preview";
            this.panel_preview.Size = new System.Drawing.Size(385, 339);
            this.panel_preview.TabIndex = 2;
            // 
            // rv_invoice
            // 
            this.rv_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_invoice.Location = new System.Drawing.Point(0, 0);
            this.rv_invoice.Name = "rv_invoice";
            this.rv_invoice.ServerReport.BearerToken = null;
            this.rv_invoice.Size = new System.Drawing.Size(385, 339);
            this.rv_invoice.TabIndex = 0;
            // 
            // panel_compute
            // 
            this.panel_compute.BackColor = System.Drawing.Color.White;
            this.panel_compute.Controls.Add(this.subTotal);
            this.panel_compute.Controls.Add(this.totalDiscount);
            this.panel_compute.Controls.Add(this.totalVAT);
            this.panel_compute.Controls.Add(this.totalVATable);
            this.panel_compute.Controls.Add(this.lbl_totalVATable);
            this.panel_compute.Controls.Add(this.lbl_totalVAT);
            this.panel_compute.Controls.Add(this.lbl_totalDiscount);
            this.panel_compute.Controls.Add(this.lbl_subTotal);
            this.panel_compute.ForeColor = System.Drawing.Color.Black;
            this.panel_compute.Location = new System.Drawing.Point(7, 351);
            this.panel_compute.Name = "panel_compute";
            this.panel_compute.Size = new System.Drawing.Size(385, 100);
            this.panel_compute.TabIndex = 1;
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(279, 6);
            this.subTotal.Name = "subTotal";
            this.subTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subTotal.Size = new System.Drawing.Size(40, 20);
            this.subTotal.TabIndex = 1;
            this.subTotal.Text = "0.00";
            this.subTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalDiscount
            // 
            this.totalDiscount.AutoSize = true;
            this.totalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDiscount.Location = new System.Drawing.Point(279, 27);
            this.totalDiscount.Name = "totalDiscount";
            this.totalDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalDiscount.Size = new System.Drawing.Size(40, 20);
            this.totalDiscount.TabIndex = 1;
            this.totalDiscount.Text = "0.00";
            this.totalDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalVAT
            // 
            this.totalVAT.AutoSize = true;
            this.totalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVAT.Location = new System.Drawing.Point(279, 47);
            this.totalVAT.Name = "totalVAT";
            this.totalVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalVAT.Size = new System.Drawing.Size(40, 20);
            this.totalVAT.TabIndex = 1;
            this.totalVAT.Text = "0.00";
            this.totalVAT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalVATable
            // 
            this.totalVATable.AutoSize = true;
            this.totalVATable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVATable.Location = new System.Drawing.Point(279, 69);
            this.totalVATable.Name = "totalVATable";
            this.totalVATable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalVATable.Size = new System.Drawing.Size(40, 20);
            this.totalVATable.TabIndex = 1;
            this.totalVATable.Text = "0.00";
            this.totalVATable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_totalVATable
            // 
            this.lbl_totalVATable.AutoSize = true;
            this.lbl_totalVATable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalVATable.Location = new System.Drawing.Point(14, 69);
            this.lbl_totalVATable.Name = "lbl_totalVATable";
            this.lbl_totalVATable.Size = new System.Drawing.Size(86, 20);
            this.lbl_totalVATable.TabIndex = 1;
            this.lbl_totalVATable.Text = "VATABLE:";
            // 
            // lbl_totalVAT
            // 
            this.lbl_totalVAT.AutoSize = true;
            this.lbl_totalVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalVAT.Location = new System.Drawing.Point(14, 49);
            this.lbl_totalVAT.Name = "lbl_totalVAT";
            this.lbl_totalVAT.Size = new System.Drawing.Size(44, 20);
            this.lbl_totalVAT.TabIndex = 1;
            this.lbl_totalVAT.Text = "VAT:";
            // 
            // lbl_totalDiscount
            // 
            this.lbl_totalDiscount.AutoSize = true;
            this.lbl_totalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalDiscount.Location = new System.Drawing.Point(14, 29);
            this.lbl_totalDiscount.Name = "lbl_totalDiscount";
            this.lbl_totalDiscount.Size = new System.Drawing.Size(150, 20);
            this.lbl_totalDiscount.TabIndex = 1;
            this.lbl_totalDiscount.Text = "TOTAL DISCOUNT:";
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTotal.Location = new System.Drawing.Point(14, 8);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(102, 20);
            this.lbl_subTotal.TabIndex = 1;
            this.lbl_subTotal.Text = "SUB-TOTAL:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_addDiscount);
            this.panel2.Controls.Add(this.btn_addProduct);
            this.panel2.Controls.Add(this.tb_quantity);
            this.panel2.Controls.Add(this.tb_searchBox);
            this.panel2.Controls.Add(this.lbl_transactionDate);
            this.panel2.Controls.Add(this.transactionDate);
            this.panel2.Controls.Add(this.transactionNo);
            this.panel2.Controls.Add(this.lbl_transactionNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 100);
            this.panel2.TabIndex = 5;
            // 
            // btn_addDiscount
            // 
            this.btn_addDiscount.AutoSize = true;
            this.btn_addDiscount.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addDiscount.Enabled = false;
            this.btn_addDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDiscount.LinkColor = System.Drawing.Color.White;
            this.btn_addDiscount.Location = new System.Drawing.Point(784, 53);
            this.btn_addDiscount.Name = "btn_addDiscount";
            this.btn_addDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addDiscount.Size = new System.Drawing.Size(159, 24);
            this.btn_addDiscount.TabIndex = 3;
            this.btn_addDiscount.TabStop = true;
            this.btn_addDiscount.Text = "[ Add Discount ]";
            this.btn_addDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_addDiscount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_addDiscount_LinkClicked);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.AutoSize = true;
            this.btn_addProduct.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_addProduct.Enabled = false;
            this.btn_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.LinkColor = System.Drawing.Color.White;
            this.btn_addProduct.Location = new System.Drawing.Point(633, 53);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addProduct.Size = new System.Drawing.Size(150, 24);
            this.btn_addProduct.TabIndex = 3;
            this.btn_addProduct.TabStop = true;
            this.btn_addProduct.Text = "[ Add Product ]";
            this.btn_addProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_addProduct_LinkClicked);
            // 
            // tb_quantity
            // 
            this.tb_quantity.Enabled = false;
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(577, 19);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(50, 26);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.Text = "1";
            this.tb_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(633, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(310, 26);
            this.tb_searchBox.TabIndex = 2;
            this.tb_searchBox.TextChanged += new System.EventHandler(this.tb_searchBox_TextChanged);
            this.tb_searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_searchBox_KeyPress);
            // 
            // lbl_transactionDate
            // 
            this.lbl_transactionDate.AutoSize = true;
            this.lbl_transactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionDate.Location = new System.Drawing.Point(20, 53);
            this.lbl_transactionDate.Name = "lbl_transactionDate";
            this.lbl_transactionDate.Size = new System.Drawing.Size(156, 24);
            this.lbl_transactionDate.TabIndex = 1;
            this.lbl_transactionDate.Text = "Transaction Date:";
            // 
            // transactionDate
            // 
            this.transactionDate.AutoSize = true;
            this.transactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDate.Location = new System.Drawing.Point(182, 53);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(289, 24);
            this.transactionDate.TabIndex = 1;
            this.transactionDate.Text = "Wednesday, September 30, 2022";
            // 
            // transactionNo
            // 
            this.transactionNo.AutoSize = true;
            this.transactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.transactionNo.Location = new System.Drawing.Point(182, 20);
            this.transactionNo.Name = "transactionNo";
            this.transactionNo.Size = new System.Drawing.Size(130, 24);
            this.transactionNo.TabIndex = 1;
            this.transactionNo.Text = "000000000000";
            // 
            // lbl_transactionNo
            // 
            this.lbl_transactionNo.AutoSize = true;
            this.lbl_transactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionNo.Location = new System.Drawing.Point(28, 20);
            this.lbl_transactionNo.Name = "lbl_transactionNo";
            this.lbl_transactionNo.Size = new System.Drawing.Size(148, 24);
            this.lbl_transactionNo.TabIndex = 1;
            this.lbl_transactionNo.Text = "Transaction No.:";
            // 
            // dgv_cart
            // 
            this.dgv_cart.AllowUserToAddRows = false;
            this.dgv_cart.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_cart.ColumnHeadersHeight = 25;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cart_num,
            this.cart_ID,
            this.cart_productCode,
            this.cart_productID,
            this.cart_productName,
            this.cart_category,
            this.cart_price,
            this.cart_quantity,
            this.cart_discount,
            this.cart_total,
            this.cart_subtract,
            this.cart_add,
            this.cart_remove});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_cart.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cart.EnableHeadersVisualStyles = false;
            this.dgv_cart.GridColor = System.Drawing.Color.Black;
            this.dgv_cart.Location = new System.Drawing.Point(0, 230);
            this.dgv_cart.MultiSelect = false;
            this.dgv_cart.Name = "dgv_cart";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_cart.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_cart.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_cart.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_cart.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_cart.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cart.Size = new System.Drawing.Size(966, 438);
            this.dgv_cart.TabIndex = 6;
            this.dgv_cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cart_CellContentClick);
            this.dgv_cart.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_cart_RowsAdded);
            this.dgv_cart.SelectionChanged += new System.EventHandler(this.dgv_cart_SelectionChanged);
            // 
            // cart_num
            // 
            this.cart_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_num.HeaderText = "#";
            this.cart_num.MinimumWidth = 25;
            this.cart_num.Name = "cart_num";
            this.cart_num.ReadOnly = true;
            this.cart_num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_num.Width = 25;
            // 
            // cart_ID
            // 
            this.cart_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_ID.HeaderText = "ID";
            this.cart_ID.MinimumWidth = 30;
            this.cart_ID.Name = "cart_ID";
            this.cart_ID.ReadOnly = true;
            this.cart_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_ID.Visible = false;
            this.cart_ID.Width = 30;
            // 
            // cart_productCode
            // 
            this.cart_productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_productCode.HeaderText = "PRODUCT CODE";
            this.cart_productCode.Name = "cart_productCode";
            this.cart_productCode.ReadOnly = true;
            this.cart_productCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_productCode.Width = 116;
            // 
            // cart_productID
            // 
            this.cart_productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_productID.HeaderText = "PRODUCT ID";
            this.cart_productID.Name = "cart_productID";
            this.cart_productID.ReadOnly = true;
            this.cart_productID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_productID.Width = 97;
            // 
            // cart_productName
            // 
            this.cart_productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cart_productName.HeaderText = "PRODUCT";
            this.cart_productName.Name = "cart_productName";
            this.cart_productName.ReadOnly = true;
            this.cart_productName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cart_category
            // 
            this.cart_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_category.HeaderText = "CATEGORY";
            this.cart_category.Name = "cart_category";
            this.cart_category.ReadOnly = true;
            this.cart_category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_category.Width = 89;
            // 
            // cart_price
            // 
            this.cart_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_price.HeaderText = "PRICE";
            this.cart_price.Name = "cart_price";
            this.cart_price.ReadOnly = true;
            this.cart_price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_price.Width = 62;
            // 
            // cart_quantity
            // 
            this.cart_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_quantity.HeaderText = "QUANTITY";
            this.cart_quantity.Name = "cart_quantity";
            this.cart_quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_quantity.Width = 85;
            // 
            // cart_discount
            // 
            this.cart_discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_discount.HeaderText = "DISCOUNT";
            this.cart_discount.Name = "cart_discount";
            this.cart_discount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_discount.Width = 86;
            // 
            // cart_total
            // 
            this.cart_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cart_total.HeaderText = "TOTAL";
            this.cart_total.Name = "cart_total";
            this.cart_total.ReadOnly = true;
            this.cart_total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_total.Width = 65;
            // 
            // cart_subtract
            // 
            this.cart_subtract.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_subtract.HeaderText = "";
            this.cart_subtract.Image = global::OmniscentPOSAI.Properties.Resources.minus_16;
            this.cart_subtract.MinimumWidth = 25;
            this.cart_subtract.Name = "cart_subtract";
            this.cart_subtract.ReadOnly = true;
            this.cart_subtract.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_subtract.Width = 25;
            // 
            // cart_add
            // 
            this.cart_add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_add.HeaderText = "";
            this.cart_add.Image = global::OmniscentPOSAI.Properties.Resources.plus_16;
            this.cart_add.MinimumWidth = 25;
            this.cart_add.Name = "cart_add";
            this.cart_add.ReadOnly = true;
            this.cart_add.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_add.Width = 25;
            // 
            // cart_remove
            // 
            this.cart_remove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cart_remove.HeaderText = "";
            this.cart_remove.Image = global::OmniscentPOSAI.Properties.Resources.cross_small_16;
            this.cart_remove.MinimumWidth = 25;
            this.cart_remove.Name = "cart_remove";
            this.cart_remove.ReadOnly = true;
            this.cart_remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cart_remove.Width = 25;
            // 
            // timer_clock
            // 
            this.timer_clock.Enabled = true;
            this.timer_clock.Tick += new System.EventHandler(this.timer_clock_Tick);
            // 
            // module_cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_cart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_invoice);
            this.Controls.Add(this.panel_buttonMenu);
            this.Controls.Add(this.panel_cashierInfo);
            this.Controls.Add(this.panel_cashierHead);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "module_cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "module_cashier";
            this.panel_cashierHead.ResumeLayout(false);
            this.panel_cashierInfo.ResumeLayout(false);
            this.panel_cashierInfo.PerformLayout();
            this.panel_dateTime.ResumeLayout(false);
            this.panel_dateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_buttonMenu.ResumeLayout(false);
            this.panel_invoice.ResumeLayout(false);
            this.panel_invoice.PerformLayout();
            this.panel_preview.ResumeLayout(false);
            this.panel_compute.ResumeLayout(false);
            this.panel_compute.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_cashierHead;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_cashierInfo;
        private System.Windows.Forms.Panel panel_dateTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_buttonMenu;
        private System.Windows.Forms.Button btn_settleTransaction;
        public System.Windows.Forms.Button btn_settings;
        public System.Windows.Forms.Button btn_cashierSales;
        public System.Windows.Forms.Button btn_checkPrice;
        public System.Windows.Forms.Button btn_scanProductCode;
        public System.Windows.Forms.Button btn_clearTransaction;
        public System.Windows.Forms.Button btn_newTransaction;
        private System.Windows.Forms.Panel panel_invoice;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Panel panel_compute;
        private System.Windows.Forms.Label lbl_totalVATable;
        private System.Windows.Forms.Label lbl_totalVAT;
        private System.Windows.Forms.Label lbl_totalDiscount;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel btn_addProduct;
        private System.Windows.Forms.Label lbl_transactionDate;
        private System.Windows.Forms.Label lbl_transactionNo;
        public System.Windows.Forms.DataGridView dgv_cart;
        public System.Windows.Forms.TextBox tb_searchBox;
        public System.Windows.Forms.Label transactionDate;
        public System.Windows.Forms.Label transactionNo;
        private System.Windows.Forms.LinkLabel btn_addDiscount;
        private System.Windows.Forms.Timer timer_clock;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox tb_role;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.TextBox tb_username;
        public System.Windows.Forms.Label lbl_date;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.Label subTotal;
        public System.Windows.Forms.Label totalDiscount;
        public System.Windows.Forms.Label totalVAT;
        public System.Windows.Forms.Label totalVATable;
        public System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cart_total;
        private System.Windows.Forms.DataGridViewImageColumn cart_subtract;
        private System.Windows.Forms.DataGridViewImageColumn cart_add;
        private System.Windows.Forms.DataGridViewImageColumn cart_remove;
        public System.Windows.Forms.TextBox totalAmount;
        private Microsoft.Reporting.WinForms.ReportViewer rv_invoice;
    }
}