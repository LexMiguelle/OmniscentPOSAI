﻿namespace OmniscentPOSAI
{
    partial class form_inventoryListReport
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
            this.btn_closeinventoryListReport = new System.Windows.Forms.Button();
            this.panel_inventoryListReportHead = new System.Windows.Forms.Panel();
            this.lbl_printPreview = new System.Windows.Forms.Label();
            this.rv_inventoryList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel_inventoryListReportHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closeinventoryListReport
            // 
            this.btn_closeinventoryListReport.BackColor = System.Drawing.Color.Red;
            this.btn_closeinventoryListReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeinventoryListReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_closeinventoryListReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeinventoryListReport.ForeColor = System.Drawing.Color.White;
            this.btn_closeinventoryListReport.Location = new System.Drawing.Point(764, 0);
            this.btn_closeinventoryListReport.Name = "btn_closeinventoryListReport";
            this.btn_closeinventoryListReport.Size = new System.Drawing.Size(28, 28);
            this.btn_closeinventoryListReport.TabIndex = 5;
            this.btn_closeinventoryListReport.Text = "X";
            this.btn_closeinventoryListReport.UseVisualStyleBackColor = false;
            this.btn_closeinventoryListReport.Click += new System.EventHandler(this.btn_closeInventoryListReport_Click);
            // 
            // panel_inventoryListReportHead
            // 
            this.panel_inventoryListReportHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_inventoryListReportHead.Controls.Add(this.lbl_printPreview);
            this.panel_inventoryListReportHead.Controls.Add(this.btn_closeinventoryListReport);
            this.panel_inventoryListReportHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_inventoryListReportHead.Location = new System.Drawing.Point(0, 0);
            this.panel_inventoryListReportHead.Name = "panel_inventoryListReportHead";
            this.panel_inventoryListReportHead.Size = new System.Drawing.Size(794, 30);
            this.panel_inventoryListReportHead.TabIndex = 2;
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
            // rv_inventoryList
            // 
            this.rv_inventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_inventoryList.Location = new System.Drawing.Point(0, 30);
            this.rv_inventoryList.Name = "rv_inventoryList";
            this.rv_inventoryList.ServerReport.BearerToken = null;
            this.rv_inventoryList.Size = new System.Drawing.Size(794, 964);
            this.rv_inventoryList.TabIndex = 3;
            // 
            // form_inventoryListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 994);
            this.ControlBox = false;
            this.Controls.Add(this.rv_inventoryList);
            this.Controls.Add(this.panel_inventoryListReportHead);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "form_inventoryListReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.form_salesReport_Load);
            this.panel_inventoryListReportHead.ResumeLayout(false);
            this.panel_inventoryListReportHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_closeinventoryListReport;
        private System.Windows.Forms.Panel panel_inventoryListReportHead;
        private System.Windows.Forms.Label lbl_printPreview;
        private Microsoft.Reporting.WinForms.ReportViewer rv_inventoryList;
    }
}