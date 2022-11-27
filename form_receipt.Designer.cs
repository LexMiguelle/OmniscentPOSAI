namespace OmniscentPOSAI
{
    partial class form_receipt
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
            this.panel_addQuantityHead = new System.Windows.Forms.Panel();
            this.lbl_printPreview = new System.Windows.Forms.Label();
            this.btn_closeAddQuantity = new System.Windows.Forms.Button();
            this.panel_addToCart = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_addQuantityHead.SuspendLayout();
            this.panel_addToCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_addQuantityHead
            // 
            this.panel_addQuantityHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addQuantityHead.Controls.Add(this.lbl_printPreview);
            this.panel_addQuantityHead.Controls.Add(this.btn_closeAddQuantity);
            this.panel_addQuantityHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_addQuantityHead.Location = new System.Drawing.Point(0, 0);
            this.panel_addQuantityHead.Name = "panel_addQuantityHead";
            this.panel_addQuantityHead.Size = new System.Drawing.Size(384, 30);
            this.panel_addQuantityHead.TabIndex = 4;
            // 
            // lbl_printPreview
            // 
            this.lbl_printPreview.AutoSize = true;
            this.lbl_printPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printPreview.ForeColor = System.Drawing.Color.White;
            this.lbl_printPreview.Location = new System.Drawing.Point(11, 6);
            this.lbl_printPreview.Name = "lbl_printPreview";
            this.lbl_printPreview.Size = new System.Drawing.Size(97, 16);
            this.lbl_printPreview.TabIndex = 6;
            this.lbl_printPreview.Text = "Print Preview";
            // 
            // btn_closeAddQuantity
            // 
            this.btn_closeAddQuantity.BackColor = System.Drawing.Color.Red;
            this.btn_closeAddQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeAddQuantity.ForeColor = System.Drawing.Color.White;
            this.btn_closeAddQuantity.Location = new System.Drawing.Point(354, 0);
            this.btn_closeAddQuantity.Name = "btn_closeAddQuantity";
            this.btn_closeAddQuantity.Size = new System.Drawing.Size(28, 28);
            this.btn_closeAddQuantity.TabIndex = 5;
            this.btn_closeAddQuantity.Text = "X";
            this.btn_closeAddQuantity.UseVisualStyleBackColor = false;
            // 
            // panel_addToCart
            // 
            this.panel_addToCart.Controls.Add(this.reportViewer1);
            this.panel_addToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_addToCart.Location = new System.Drawing.Point(0, 30);
            this.panel_addToCart.Name = "panel_addToCart";
            this.panel_addToCart.Size = new System.Drawing.Size(384, 554);
            this.panel_addToCart.TabIndex = 11;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(384, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // form_receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 584);
            this.ControlBox = false;
            this.Controls.Add(this.panel_addToCart);
            this.Controls.Add(this.panel_addQuantityHead);
            this.Name = "form_receipt";
            this.panel_addQuantityHead.ResumeLayout(false);
            this.panel_addQuantityHead.PerformLayout();
            this.panel_addToCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_addQuantityHead;
        private System.Windows.Forms.Button btn_closeAddQuantity;
        private System.Windows.Forms.Panel panel_addToCart;
        private System.Windows.Forms.Label lbl_printPreview;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}