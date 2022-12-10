namespace OmniscentPOSAI
{
    partial class form_cancelOrder
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
            this.panel_cancelOrderHead = new System.Windows.Forms.Panel();
            this.btn_closeCancelOrder = new System.Windows.Forms.Button();
            this.panel_cancelOrder = new System.Windows.Forms.Panel();
            this.tb_searchBox = new System.Windows.Forms.TextBox();
            this.lbl_cancelOrder = new System.Windows.Forms.Label();
            this.lbl_transactionNo = new System.Windows.Forms.Label();
            this.tb_transactionNo = new System.Windows.Forms.TextBox();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.tb_productID = new System.Windows.Forms.TextBox();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.lbl_cancelledBy = new System.Windows.Forms.Label();
            this.tb_cancelledBy = new System.Windows.Forms.TextBox();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.tb_remarks = new System.Windows.Forms.TextBox();
            this.lbl_action = new System.Windows.Forms.Label();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.cb_action = new System.Windows.Forms.ComboBox();
            this.lbl_cancelQuantity = new System.Windows.Forms.Label();
            this.tb_cancelQuantity = new System.Windows.Forms.TextBox();
            this.lbl_itemDetails = new System.Windows.Forms.Label();
            this.panel_itemDetails = new System.Windows.Forms.Panel();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.panel_cancelDetails = new System.Windows.Forms.Panel();
            this.lbl_cancelDetails = new System.Windows.Forms.Label();
            this.transactionID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel_cancelOrderHead.SuspendLayout();
            this.panel_cancelOrder.SuspendLayout();
            this.panel_itemDetails.SuspendLayout();
            this.panel_cancelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_cancelOrderHead
            // 
            this.panel_cancelOrderHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cancelOrderHead.Controls.Add(this.btn_closeCancelOrder);
            this.panel_cancelOrderHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cancelOrderHead.Location = new System.Drawing.Point(0, 0);
            this.panel_cancelOrderHead.Name = "panel_cancelOrderHead";
            this.panel_cancelOrderHead.Size = new System.Drawing.Size(770, 30);
            this.panel_cancelOrderHead.TabIndex = 5;
            // 
            // btn_closeCancelOrder
            // 
            this.btn_closeCancelOrder.BackColor = System.Drawing.Color.Red;
            this.btn_closeCancelOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btn_closeCancelOrder.Location = new System.Drawing.Point(740, 0);
            this.btn_closeCancelOrder.Name = "btn_closeCancelOrder";
            this.btn_closeCancelOrder.Size = new System.Drawing.Size(28, 28);
            this.btn_closeCancelOrder.TabIndex = 5;
            this.btn_closeCancelOrder.Text = "X";
            this.btn_closeCancelOrder.UseVisualStyleBackColor = false;
            this.btn_closeCancelOrder.Click += new System.EventHandler(this.btn_closeCancelOrder_Click);
            // 
            // panel_cancelOrder
            // 
            this.panel_cancelOrder.Controls.Add(this.tb_searchBox);
            this.panel_cancelOrder.Controls.Add(this.username);
            this.panel_cancelOrder.Controls.Add(this.lbl_cancelOrder);
            this.panel_cancelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cancelOrder.Location = new System.Drawing.Point(0, 30);
            this.panel_cancelOrder.Name = "panel_cancelOrder";
            this.panel_cancelOrder.Size = new System.Drawing.Size(770, 75);
            this.panel_cancelOrder.TabIndex = 12;
            // 
            // tb_searchBox
            // 
            this.tb_searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchBox.Location = new System.Drawing.Point(628, 20);
            this.tb_searchBox.Name = "tb_searchBox";
            this.tb_searchBox.Size = new System.Drawing.Size(0, 29);
            this.tb_searchBox.TabIndex = 5;
            // 
            // lbl_cancelOrder
            // 
            this.lbl_cancelOrder.AutoSize = true;
            this.lbl_cancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelOrder.ForeColor = System.Drawing.Color.White;
            this.lbl_cancelOrder.Location = new System.Drawing.Point(22, 20);
            this.lbl_cancelOrder.Name = "lbl_cancelOrder";
            this.lbl_cancelOrder.Size = new System.Drawing.Size(187, 31);
            this.lbl_cancelOrder.TabIndex = 4;
            this.lbl_cancelOrder.Text = "Cancel Order";
            // 
            // lbl_transactionNo
            // 
            this.lbl_transactionNo.AutoSize = true;
            this.lbl_transactionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transactionNo.ForeColor = System.Drawing.Color.White;
            this.lbl_transactionNo.Location = new System.Drawing.Point(14, 18);
            this.lbl_transactionNo.Name = "lbl_transactionNo";
            this.lbl_transactionNo.Size = new System.Drawing.Size(140, 20);
            this.lbl_transactionNo.TabIndex = 4;
            this.lbl_transactionNo.Text = "Transaction No.:";
            // 
            // tb_transactionNo
            // 
            this.tb_transactionNo.Location = new System.Drawing.Point(160, 18);
            this.tb_transactionNo.Name = "tb_transactionNo";
            this.tb_transactionNo.ReadOnly = true;
            this.tb_transactionNo.Size = new System.Drawing.Size(262, 20);
            this.tb_transactionNo.TabIndex = 13;
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.ForeColor = System.Drawing.Color.White;
            this.lbl_productID.Location = new System.Drawing.Point(54, 53);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(100, 20);
            this.lbl_productID.TabIndex = 4;
            this.lbl_productID.Text = "Product ID:";
            // 
            // tb_productID
            // 
            this.tb_productID.Location = new System.Drawing.Point(160, 53);
            this.tb_productID.Name = "tb_productID";
            this.tb_productID.ReadOnly = true;
            this.tb_productID.Size = new System.Drawing.Size(150, 20);
            this.tb_productID.TabIndex = 13;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.ForeColor = System.Drawing.Color.White;
            this.lbl_productName.Location = new System.Drawing.Point(78, 80);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(76, 20);
            this.lbl_productName.TabIndex = 4;
            this.lbl_productName.Text = "Product:";
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(160, 79);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.ReadOnly = true;
            this.tb_productName.Size = new System.Drawing.Size(261, 20);
            this.tb_productName.TabIndex = 13;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(529, 10);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(54, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price:";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(589, 10);
            this.tb_price.Name = "tb_price";
            this.tb_price.ReadOnly = true;
            this.tb_price.Size = new System.Drawing.Size(100, 20);
            this.tb_price.TabIndex = 13;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_quantity.Location = new System.Drawing.Point(502, 35);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(81, 20);
            this.lbl_quantity.TabIndex = 4;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(589, 35);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.ReadOnly = true;
            this.tb_quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_quantity.TabIndex = 13;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.White;
            this.lbl_total.Location = new System.Drawing.Point(529, 85);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(54, 20);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "Total:";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(589, 87);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(100, 20);
            this.tb_total.TabIndex = 13;
            // 
            // lbl_cancelledBy
            // 
            this.lbl_cancelledBy.AutoSize = true;
            this.lbl_cancelledBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelledBy.ForeColor = System.Drawing.Color.White;
            this.lbl_cancelledBy.Location = new System.Drawing.Point(36, 19);
            this.lbl_cancelledBy.Name = "lbl_cancelledBy";
            this.lbl_cancelledBy.Size = new System.Drawing.Size(118, 20);
            this.lbl_cancelledBy.TabIndex = 4;
            this.lbl_cancelledBy.Text = "Cancelled By:";
            // 
            // tb_cancelledBy
            // 
            this.tb_cancelledBy.Location = new System.Drawing.Point(160, 19);
            this.tb_cancelledBy.Name = "tb_cancelledBy";
            this.tb_cancelledBy.ReadOnly = true;
            this.tb_cancelledBy.Size = new System.Drawing.Size(150, 20);
            this.tb_cancelledBy.TabIndex = 13;
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.AutoSize = true;
            this.lbl_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.ForeColor = System.Drawing.Color.White;
            this.lbl_remarks.Location = new System.Drawing.Point(337, 21);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(85, 20);
            this.lbl_remarks.TabIndex = 4;
            this.lbl_remarks.Text = "Remarks:";
            // 
            // tb_remarks
            // 
            this.tb_remarks.Location = new System.Drawing.Point(428, 21);
            this.tb_remarks.Multiline = true;
            this.tb_remarks.Name = "tb_remarks";
            this.tb_remarks.Size = new System.Drawing.Size(261, 71);
            this.tb_remarks.TabIndex = 13;
            this.tb_remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_remarks_KeyPress);
            // 
            // lbl_action
            // 
            this.lbl_action.AutoSize = true;
            this.lbl_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_action.ForeColor = System.Drawing.Color.White;
            this.lbl_action.Location = new System.Drawing.Point(89, 46);
            this.lbl_action.Name = "lbl_action";
            this.lbl_action.Size = new System.Drawing.Size(65, 20);
            this.lbl_action.TabIndex = 4;
            this.lbl_action.Text = "Action:";
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelOrder.Location = new System.Drawing.Point(594, 426);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(150, 30);
            this.btn_cancelOrder.TabIndex = 14;
            this.btn_cancelOrder.Text = "Cancel Order";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // cb_action
            // 
            this.cb_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_action.FormattingEnabled = true;
            this.cb_action.Items.AddRange(new object[] {
            "Return to Inventory",
            "Remove from Inventory"});
            this.cb_action.Location = new System.Drawing.Point(160, 45);
            this.cb_action.Name = "cb_action";
            this.cb_action.Size = new System.Drawing.Size(150, 21);
            this.cb_action.TabIndex = 15;
            // 
            // lbl_cancelQuantity
            // 
            this.lbl_cancelQuantity.AutoSize = true;
            this.lbl_cancelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_cancelQuantity.Location = new System.Drawing.Point(13, 70);
            this.lbl_cancelQuantity.Name = "lbl_cancelQuantity";
            this.lbl_cancelQuantity.Size = new System.Drawing.Size(141, 20);
            this.lbl_cancelQuantity.TabIndex = 4;
            this.lbl_cancelQuantity.Text = "Cancel Quantity:";
            // 
            // tb_cancelQuantity
            // 
            this.tb_cancelQuantity.Location = new System.Drawing.Point(160, 72);
            this.tb_cancelQuantity.Name = "tb_cancelQuantity";
            this.tb_cancelQuantity.Size = new System.Drawing.Size(100, 20);
            this.tb_cancelQuantity.TabIndex = 13;
            this.tb_cancelQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cancelQuantity_KeyPress);
            // 
            // lbl_itemDetails
            // 
            this.lbl_itemDetails.AutoSize = true;
            this.lbl_itemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDetails.ForeColor = System.Drawing.Color.White;
            this.lbl_itemDetails.Location = new System.Drawing.Point(24, 117);
            this.lbl_itemDetails.Name = "lbl_itemDetails";
            this.lbl_itemDetails.Size = new System.Drawing.Size(117, 24);
            this.lbl_itemDetails.TabIndex = 4;
            this.lbl_itemDetails.Text = "Item Details";
            // 
            // panel_itemDetails
            // 
            this.panel_itemDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_itemDetails.Controls.Add(this.tb_total);
            this.panel_itemDetails.Controls.Add(this.lbl_transactionNo);
            this.panel_itemDetails.Controls.Add(this.lbl_productID);
            this.panel_itemDetails.Controls.Add(this.tb_transactionNo);
            this.panel_itemDetails.Controls.Add(this.lbl_productName);
            this.panel_itemDetails.Controls.Add(this.tb_productID);
            this.panel_itemDetails.Controls.Add(this.lbl_discount);
            this.panel_itemDetails.Controls.Add(this.lbl_price);
            this.panel_itemDetails.Controls.Add(this.tb_productName);
            this.panel_itemDetails.Controls.Add(this.lbl_quantity);
            this.panel_itemDetails.Controls.Add(this.tb_discount);
            this.panel_itemDetails.Controls.Add(this.tb_price);
            this.panel_itemDetails.Controls.Add(this.tb_quantity);
            this.panel_itemDetails.Controls.Add(this.lbl_total);
            this.panel_itemDetails.Location = new System.Drawing.Point(28, 144);
            this.panel_itemDetails.Name = "panel_itemDetails";
            this.panel_itemDetails.Size = new System.Drawing.Size(716, 116);
            this.panel_itemDetails.TabIndex = 16;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.Color.White;
            this.lbl_discount.Location = new System.Drawing.Point(498, 61);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(85, 20);
            this.lbl_discount.TabIndex = 4;
            this.lbl_discount.Text = "Discount:";
            // 
            // tb_discount
            // 
            this.tb_discount.Location = new System.Drawing.Point(589, 61);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.ReadOnly = true;
            this.tb_discount.Size = new System.Drawing.Size(100, 20);
            this.tb_discount.TabIndex = 13;
            // 
            // panel_cancelDetails
            // 
            this.panel_cancelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_cancelDetails.Controls.Add(this.tb_remarks);
            this.panel_cancelDetails.Controls.Add(this.lbl_cancelQuantity);
            this.panel_cancelDetails.Controls.Add(this.cb_action);
            this.panel_cancelDetails.Controls.Add(this.tb_cancelQuantity);
            this.panel_cancelDetails.Controls.Add(this.lbl_cancelledBy);
            this.panel_cancelDetails.Controls.Add(this.lbl_action);
            this.panel_cancelDetails.Controls.Add(this.tb_cancelledBy);
            this.panel_cancelDetails.Controls.Add(this.lbl_remarks);
            this.panel_cancelDetails.Location = new System.Drawing.Point(28, 303);
            this.panel_cancelDetails.Name = "panel_cancelDetails";
            this.panel_cancelDetails.Size = new System.Drawing.Size(716, 108);
            this.panel_cancelDetails.TabIndex = 17;
            // 
            // lbl_cancelDetails
            // 
            this.lbl_cancelDetails.AutoSize = true;
            this.lbl_cancelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cancelDetails.ForeColor = System.Drawing.Color.White;
            this.lbl_cancelDetails.Location = new System.Drawing.Point(24, 276);
            this.lbl_cancelDetails.Name = "lbl_cancelDetails";
            this.lbl_cancelDetails.Size = new System.Drawing.Size(143, 24);
            this.lbl_cancelDetails.TabIndex = 4;
            this.lbl_cancelDetails.Text = "Cancel Details";
            // 
            // transactionID
            // 
            this.transactionID.AutoSize = true;
            this.transactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionID.ForeColor = System.Drawing.Color.White;
            this.transactionID.Location = new System.Drawing.Point(147, 121);
            this.transactionID.Name = "transactionID";
            this.transactionID.Size = new System.Drawing.Size(19, 20);
            this.transactionID.TabIndex = 4;
            this.transactionID.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(725, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "#";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(233, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(19, 20);
            this.username.TabIndex = 4;
            this.username.Text = "#";
            // 
            // form_cancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(770, 472);
            this.ControlBox = false;
            this.Controls.Add(this.panel_cancelDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionID);
            this.Controls.Add(this.panel_itemDetails);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.panel_cancelOrder);
            this.Controls.Add(this.lbl_cancelDetails);
            this.Controls.Add(this.lbl_itemDetails);
            this.Controls.Add(this.panel_cancelOrderHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_cancelOrder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_cancelOrderHead.ResumeLayout(false);
            this.panel_cancelOrder.ResumeLayout(false);
            this.panel_cancelOrder.PerformLayout();
            this.panel_itemDetails.ResumeLayout(false);
            this.panel_itemDetails.PerformLayout();
            this.panel_cancelDetails.ResumeLayout(false);
            this.panel_cancelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_cancelOrderHead;
        private System.Windows.Forms.Button btn_closeCancelOrder;
        private System.Windows.Forms.Panel panel_cancelOrder;
        private System.Windows.Forms.TextBox tb_searchBox;
        private System.Windows.Forms.Label lbl_cancelOrder;
        private System.Windows.Forms.Label lbl_transactionNo;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_cancelledBy;
        private System.Windows.Forms.Label lbl_remarks;
        private System.Windows.Forms.Label lbl_action;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Label lbl_cancelQuantity;
        private System.Windows.Forms.Label lbl_itemDetails;
        private System.Windows.Forms.Panel panel_itemDetails;
        private System.Windows.Forms.Panel panel_cancelDetails;
        private System.Windows.Forms.Label lbl_cancelDetails;
        public System.Windows.Forms.Label transactionID;
        public System.Windows.Forms.TextBox tb_transactionNo;
        public System.Windows.Forms.TextBox tb_productID;
        public System.Windows.Forms.TextBox tb_productName;
        public System.Windows.Forms.TextBox tb_price;
        public System.Windows.Forms.TextBox tb_quantity;
        public System.Windows.Forms.TextBox tb_total;
        public System.Windows.Forms.TextBox tb_cancelledBy;
        public System.Windows.Forms.TextBox tb_remarks;
        public System.Windows.Forms.ComboBox cb_action;
        public System.Windows.Forms.TextBox tb_cancelQuantity;
        private System.Windows.Forms.Label lbl_discount;
        public System.Windows.Forms.TextBox tb_discount;
        public System.Windows.Forms.Label username;
        public System.Windows.Forms.Label label1;
    }
}