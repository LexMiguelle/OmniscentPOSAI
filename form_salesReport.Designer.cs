namespace OmniscentPOSAI
{
    partial class form_salesReport
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
            this.btn_closeCheckPrice = new System.Windows.Forms.Button();
            this.panel_checkPriceHead = new System.Windows.Forms.Panel();
            this.lbl_printPreview = new System.Windows.Forms.Label();
            this.rv_sales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_checkPriceHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closeCheckPrice
            // 
            this.btn_closeCheckPrice.BackColor = System.Drawing.Color.Red;
            this.btn_closeCheckPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeCheckPrice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeCheckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeCheckPrice.ForeColor = System.Drawing.Color.White;
            this.btn_closeCheckPrice.Location = new System.Drawing.Point(764, 0);
            this.btn_closeCheckPrice.Name = "btn_closeCheckPrice";
            this.btn_closeCheckPrice.Size = new System.Drawing.Size(28, 28);
            this.btn_closeCheckPrice.TabIndex = 5;
            this.btn_closeCheckPrice.Text = "X";
            this.btn_closeCheckPrice.UseVisualStyleBackColor = false;
            this.btn_closeCheckPrice.Click += new System.EventHandler(this.btn_closeCheckPrice_Click);
            // 
            // panel_checkPriceHead
            // 
            this.panel_checkPriceHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_checkPriceHead.Controls.Add(this.lbl_printPreview);
            this.panel_checkPriceHead.Controls.Add(this.btn_closeCheckPrice);
            this.panel_checkPriceHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_checkPriceHead.Location = new System.Drawing.Point(0, 0);
            this.panel_checkPriceHead.Name = "panel_checkPriceHead";
            this.panel_checkPriceHead.Size = new System.Drawing.Size(794, 30);
            this.panel_checkPriceHead.TabIndex = 2;
            // 
            // lbl_printPreview
            // 
            this.lbl_printPreview.AutoSize = true;
            this.lbl_printPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_printPreview.ForeColor = System.Drawing.Color.White;
            this.lbl_printPreview.Location = new System.Drawing.Point(3, 6);
            this.lbl_printPreview.Name = "lbl_printPreview";
            this.lbl_printPreview.Size = new System.Drawing.Size(84, 16);
            this.lbl_printPreview.TabIndex = 6;
            this.lbl_printPreview.Text = "Print Preview";
            // 
            // rv_sales
            // 
            this.rv_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_sales.Location = new System.Drawing.Point(0, 30);
            this.rv_sales.Name = "rv_sales";
            this.rv_sales.ServerReport.BearerToken = null;
            this.rv_sales.Size = new System.Drawing.Size(794, 964);
            this.rv_sales.TabIndex = 3;
            // 
            // form_salesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 994);
            this.ControlBox = false;
            this.Controls.Add(this.rv_sales);
            this.Controls.Add(this.panel_checkPriceHead);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_salesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.form_salesReport_Load);
            this.panel_checkPriceHead.ResumeLayout(false);
            this.panel_checkPriceHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_closeCheckPrice;
        private System.Windows.Forms.Panel panel_checkPriceHead;
        private System.Windows.Forms.Label lbl_printPreview;
        private Microsoft.Reporting.WinForms.ReportViewer rv_sales;
    }
}