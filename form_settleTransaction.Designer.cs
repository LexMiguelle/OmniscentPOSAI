namespace OmniscentPOSAI
{
    partial class form_settleTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_settleTransaction));
            this.panel_settleTransactionHead = new System.Windows.Forms.Panel();
            this.btn_settleTransaction = new System.Windows.Forms.Button();
            this.lbl_settleTransaction = new System.Windows.Forms.Label();
            this.panel_settleTransaction = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.lbl_amountPaid = new System.Windows.Forms.Label();
            this.tb_totalAmount = new System.Windows.Forms.TextBox();
            this.lbl_change = new System.Windows.Forms.Label();
            this.tb_amountPaid = new System.Windows.Forms.TextBox();
            this.tb_change = new System.Windows.Forms.TextBox();
            this.btn_enterSettleTransaction = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_deleteLast = new System.Windows.Forms.Button();
            this.btn_clearAmountPaid = new System.Windows.Forms.Button();
            this.transactionNo = new System.Windows.Forms.Label();
            this.lbl_transactionNo = new System.Windows.Forms.Label();
            this.panel_settleTransactionHead.SuspendLayout();
            this.panel_settleTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_settleTransactionHead
            // 
            this.panel_settleTransactionHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_settleTransactionHead.Controls.Add(this.btn_settleTransaction);
            this.panel_settleTransactionHead.Controls.Add(this.transactionNo);
            this.panel_settleTransactionHead.Controls.Add(this.lbl_transactionNo);
            this.panel_settleTransactionHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_settleTransactionHead.Location = new System.Drawing.Point(0, 0);
            this.panel_settleTransactionHead.Name = "panel_settleTransactionHead";
            this.panel_settleTransactionHead.Size = new System.Drawing.Size(394, 30);
            this.panel_settleTransactionHead.TabIndex = 4;
            // 
            // btn_settleTransaction
            // 
            this.btn_settleTransaction.BackColor = System.Drawing.Color.Red;
            this.btn_settleTransaction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_settleTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_settleTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settleTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_settleTransaction.Location = new System.Drawing.Point(364, 0);
            this.btn_settleTransaction.Name = "btn_settleTransaction";
            this.btn_settleTransaction.Size = new System.Drawing.Size(28, 28);
            this.btn_settleTransaction.TabIndex = 5;
            this.btn_settleTransaction.Text = "X";
            this.btn_settleTransaction.UseVisualStyleBackColor = false;
            this.btn_settleTransaction.Click += new System.EventHandler(this.btn_exitSettleTransaction_Click);
            // 
            // lbl_settleTransaction
            // 
            this.lbl_settleTransaction.AutoSize = true;
            this.lbl_settleTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settleTransaction.ForeColor = System.Drawing.Color.White;
            this.lbl_settleTransaction.Location = new System.Drawing.Point(22, 20);
            this.lbl_settleTransaction.Name = "lbl_settleTransaction";
            this.lbl_settleTransaction.Size = new System.Drawing.Size(252, 31);
            this.lbl_settleTransaction.TabIndex = 4;
            this.lbl_settleTransaction.Text = "Settle Transaction";
            // 
            // panel_settleTransaction
            // 
            this.panel_settleTransaction.Controls.Add(this.tb_searchBox);
            this.panel_settleTransaction.Controls.Add(this.lbl_settleTransaction);
            this.panel_settleTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_settleTransaction.Location = new System.Drawing.Point(0, 30);
            this.panel_settleTransaction.Name = "panel_settleTransaction";
            this.panel_settleTransaction.Size = new System.Drawing.Size(394, 75);
            this.panel_settleTransaction.TabIndex = 11;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalAmount.ForeColor = System.Drawing.Color.White;
            this.lbl_totalAmount.Location = new System.Drawing.Point(24, 121);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(140, 24);
            this.lbl_totalAmount.TabIndex = 4;
            this.lbl_totalAmount.Text = "Total Amount:";
            // 
            // lbl_amountPaid
            // 
            this.lbl_amountPaid.AutoSize = true;
            this.lbl_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amountPaid.ForeColor = System.Drawing.Color.White;
            this.lbl_amountPaid.Location = new System.Drawing.Point(24, 180);
            this.lbl_amountPaid.Name = "lbl_amountPaid";
            this.lbl_amountPaid.Size = new System.Drawing.Size(135, 24);
            this.lbl_amountPaid.TabIndex = 4;
            this.lbl_amountPaid.Text = "Amount Paid:";
            // 
            // tb_totalAmount
            // 
            this.tb_totalAmount.BackColor = System.Drawing.Color.Black;
            this.tb_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalAmount.ForeColor = System.Drawing.Color.Lime;
            this.tb_totalAmount.Location = new System.Drawing.Point(12, 148);
            this.tb_totalAmount.Name = "tb_totalAmount";
            this.tb_totalAmount.Size = new System.Drawing.Size(370, 29);
            this.tb_totalAmount.TabIndex = 12;
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.Color.White;
            this.lbl_change.Location = new System.Drawing.Point(24, 239);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(89, 24);
            this.lbl_change.TabIndex = 4;
            this.lbl_change.Text = "Change:";
            // 
            // tb_amountPaid
            // 
            this.tb_amountPaid.BackColor = System.Drawing.Color.Black;
            this.tb_amountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amountPaid.ForeColor = System.Drawing.Color.Lime;
            this.tb_amountPaid.Location = new System.Drawing.Point(12, 207);
            this.tb_amountPaid.Name = "tb_amountPaid";
            this.tb_amountPaid.Size = new System.Drawing.Size(370, 29);
            this.tb_amountPaid.TabIndex = 12;
            this.tb_amountPaid.TextChanged += new System.EventHandler(this.tb_amountPaid_TextChanged);
            this.tb_amountPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_amountPaid_KeyPress);
            // 
            // tb_change
            // 
            this.tb_change.BackColor = System.Drawing.Color.Black;
            this.tb_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_change.ForeColor = System.Drawing.Color.Lime;
            this.tb_change.Location = new System.Drawing.Point(12, 266);
            this.tb_change.Name = "tb_change";
            this.tb_change.Size = new System.Drawing.Size(370, 29);
            this.tb_change.TabIndex = 12;
            // 
            // btn_enterSettleTransaction
            // 
            this.btn_enterSettleTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_enterSettleTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enterSettleTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterSettleTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_enterSettleTransaction.Location = new System.Drawing.Point(12, 532);
            this.btn_enterSettleTransaction.Name = "btn_enterSettleTransaction";
            this.btn_enterSettleTransaction.Size = new System.Drawing.Size(370, 50);
            this.btn_enterSettleTransaction.TabIndex = 13;
            this.btn_enterSettleTransaction.Text = "ENTER";
            this.btn_enterSettleTransaction.UseVisualStyleBackColor = false;
            this.btn_enterSettleTransaction.Click += new System.EventHandler(this.btn_enterSettleTransaction_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Black;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(12, 462);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(65, 65);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Black;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(78, 462);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(65, 65);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Black;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(144, 462);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(65, 65);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Black;
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(215, 462);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(65, 65);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_00
            // 
            this.btn_00.BackColor = System.Drawing.Color.Black;
            this.btn_00.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_00.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_00.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_00.ForeColor = System.Drawing.Color.White;
            this.btn_00.Location = new System.Drawing.Point(281, 462);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(101, 65);
            this.btn_00.TabIndex = 13;
            this.btn_00.Text = "00";
            this.btn_00.UseVisualStyleBackColor = false;
            this.btn_00.Click += new System.EventHandler(this.btn_00_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Black;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(12, 396);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(65, 65);
            this.btn_4.TabIndex = 13;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Black;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(12, 330);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(65, 65);
            this.btn_7.TabIndex = 13;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Black;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(78, 396);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(65, 65);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Black;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(78, 330);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(65, 65);
            this.btn_8.TabIndex = 13;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Black;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(144, 330);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(65, 65);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Black;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(144, 396);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(65, 65);
            this.btn_6.TabIndex = 13;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.BackColor = System.Drawing.Color.Black;
            this.btn_dot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.ForeColor = System.Drawing.Color.White;
            this.btn_dot.Location = new System.Drawing.Point(215, 396);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(65, 65);
            this.btn_dot.TabIndex = 13;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = false;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_deleteLast
            // 
            this.btn_deleteLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_deleteLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deleteLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteLast.ForeColor = System.Drawing.Color.White;
            this.btn_deleteLast.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteLast.Image")));
            this.btn_deleteLast.Location = new System.Drawing.Point(215, 330);
            this.btn_deleteLast.Name = "btn_deleteLast";
            this.btn_deleteLast.Size = new System.Drawing.Size(167, 65);
            this.btn_deleteLast.TabIndex = 13;
            this.btn_deleteLast.UseVisualStyleBackColor = false;
            this.btn_deleteLast.Click += new System.EventHandler(this.btn_deleteLast_Click);
            // 
            // btn_clearAmountPaid
            // 
            this.btn_clearAmountPaid.BackColor = System.Drawing.Color.Red;
            this.btn_clearAmountPaid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearAmountPaid.ForeColor = System.Drawing.Color.White;
            this.btn_clearAmountPaid.Location = new System.Drawing.Point(281, 396);
            this.btn_clearAmountPaid.Name = "btn_clearAmountPaid";
            this.btn_clearAmountPaid.Size = new System.Drawing.Size(101, 65);
            this.btn_clearAmountPaid.TabIndex = 13;
            this.btn_clearAmountPaid.Text = "C";
            this.btn_clearAmountPaid.UseVisualStyleBackColor = false;
            this.btn_clearAmountPaid.Click += new System.EventHandler(this.btn_clearAmountPaid_Click);
            // 
            // transactionNo
            // 
            this.transactionNo.AutoSize = true;
            this.transactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionNo.ForeColor = System.Drawing.Color.White;
            this.transactionNo.Location = new System.Drawing.Point(117, 6);
            this.transactionNo.Name = "transactionNo";
            this.transactionNo.Size = new System.Drawing.Size(91, 16);
            this.transactionNo.TabIndex = 4;
            this.transactionNo.Text = "000000000000";
            // 
            // lbl_transactionNo
            // 
            this.lbl_transactionNo.AutoSize = true;
            this.lbl_transactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionNo.ForeColor = System.Drawing.Color.White;
            this.lbl_transactionNo.Location = new System.Drawing.Point(5, 6);
            this.lbl_transactionNo.Name = "lbl_transactionNo";
            this.lbl_transactionNo.Size = new System.Drawing.Size(106, 16);
            this.lbl_transactionNo.TabIndex = 4;
            this.lbl_transactionNo.Text = "Tramsaction No.";
            // 
            // form_settleTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(394, 594);
            this.ControlBox = false;
            this.Controls.Add(this.btn_clearAmountPaid);
            this.Controls.Add(this.btn_00);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_deleteLast);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_enterSettleTransaction);
            this.Controls.Add(this.tb_change);
            this.Controls.Add(this.tb_amountPaid);
            this.Controls.Add(this.tb_totalAmount);
            this.Controls.Add(this.panel_settleTransaction);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lbl_amountPaid);
            this.Controls.Add(this.lbl_totalAmount);
            this.Controls.Add(this.panel_settleTransactionHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_settleTransaction";
            this.panel_settleTransactionHead.ResumeLayout(false);
            this.panel_settleTransactionHead.PerformLayout();
            this.panel_settleTransaction.ResumeLayout(false);
            this.panel_settleTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_settleTransactionHead;
        private System.Windows.Forms.Button btn_settleTransaction;
        private System.Windows.Forms.Label lbl_settleTransaction;
        private System.Windows.Forms.Panel panel_settleTransaction;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_totalAmount;
        private System.Windows.Forms.Label lbl_amountPaid;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Button btn_enterSettleTransaction;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_00;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_deleteLast;
        private System.Windows.Forms.Button btn_clearAmountPaid;
        public System.Windows.Forms.TextBox tb_totalAmount;
        public System.Windows.Forms.TextBox tb_amountPaid;
        public System.Windows.Forms.TextBox tb_change;
        private System.Windows.Forms.Label lbl_transactionNo;
        public System.Windows.Forms.Label transactionNo;
    }
}