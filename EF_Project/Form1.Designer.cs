namespace EF_Project
{
    partial class Form1
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
            this.containerPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transfareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTransferReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expireProductReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAfterPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.menuStrip1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1872, 791);
            this.containerPanel.TabIndex = 2;
            this.containerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPanel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.newTransactionToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1872, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "&Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.suppliersToolStripMenuItem.Text = "&Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "&Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // newTransactionToolStripMenuItem
            // 
            this.newTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inTransactionToolStripMenuItem,
            this.outTransactionToolStripMenuItem,
            this.transfareToolStripMenuItem});
            this.newTransactionToolStripMenuItem.Name = "newTransactionToolStripMenuItem";
            this.newTransactionToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.newTransactionToolStripMenuItem.Text = "&New Transaction";
            // 
            // inTransactionToolStripMenuItem
            // 
            this.inTransactionToolStripMenuItem.Name = "inTransactionToolStripMenuItem";
            this.inTransactionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inTransactionToolStripMenuItem.Text = "In Transaction";
            this.inTransactionToolStripMenuItem.Click += new System.EventHandler(this.inTransactionToolStripMenuItem_Click);
            // 
            // outTransactionToolStripMenuItem
            // 
            this.outTransactionToolStripMenuItem.Name = "outTransactionToolStripMenuItem";
            this.outTransactionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outTransactionToolStripMenuItem.Text = "Out Transaction";
            this.outTransactionToolStripMenuItem.Click += new System.EventHandler(this.outTransactionToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wareHouseToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // wareHouseToolStripMenuItem
            // 
            this.wareHouseToolStripMenuItem.Name = "wareHouseToolStripMenuItem";
            this.wareHouseToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.wareHouseToolStripMenuItem.Text = "WareHouse";
            this.wareHouseToolStripMenuItem.Click += new System.EventHandler(this.wareHouseToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseReportToolStripMenuItem,
            this.productReportToolStripMenuItem,
            this.productTransferReportToolStripMenuItem,
            this.expireProductReportToolStripMenuItem,
            this.productAfterPeriodToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // transfareToolStripMenuItem
            // 
            this.transfareToolStripMenuItem.Name = "transfareToolStripMenuItem";
            this.transfareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transfareToolStripMenuItem.Text = "Transfare";
            this.transfareToolStripMenuItem.Click += new System.EventHandler(this.transfareToolStripMenuItem_Click);
            // 
            // warehouseReportToolStripMenuItem
            // 
            this.warehouseReportToolStripMenuItem.Name = "warehouseReportToolStripMenuItem";
            this.warehouseReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.warehouseReportToolStripMenuItem.Text = "Warehouse Report";
            this.warehouseReportToolStripMenuItem.Click += new System.EventHandler(this.warehouseReportToolStripMenuItem_Click);
            // 
            // productReportToolStripMenuItem
            // 
            this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
            this.productReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productReportToolStripMenuItem.Text = "Product Report";
            this.productReportToolStripMenuItem.Click += new System.EventHandler(this.productReportToolStripMenuItem_Click);
            // 
            // productTransferReportToolStripMenuItem
            // 
            this.productTransferReportToolStripMenuItem.Name = "productTransferReportToolStripMenuItem";
            this.productTransferReportToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.productTransferReportToolStripMenuItem.Text = "Product Transfer Report";
            this.productTransferReportToolStripMenuItem.Click += new System.EventHandler(this.productTransferReportToolStripMenuItem_Click);
            // 
            // expireProductReportToolStripMenuItem
            // 
            this.expireProductReportToolStripMenuItem.Name = "expireProductReportToolStripMenuItem";
            this.expireProductReportToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.expireProductReportToolStripMenuItem.Text = "Expire Product Report";
            this.expireProductReportToolStripMenuItem.Click += new System.EventHandler(this.expireProductReportToolStripMenuItem_Click);
            // 
            // productAfterPeriodToolStripMenuItem
            // 
            this.productAfterPeriodToolStripMenuItem.Name = "productAfterPeriodToolStripMenuItem";
            this.productAfterPeriodToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.productAfterPeriodToolStripMenuItem.Text = "Product After Period";
            this.productAfterPeriodToolStripMenuItem.Click += new System.EventHandler(this.productAfterPeriodToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 791);
            this.Controls.Add(this.containerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transfareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTransferReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expireProductReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAfterPeriodToolStripMenuItem;
    }
}

