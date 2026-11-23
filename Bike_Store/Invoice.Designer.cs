namespace Bike_Store
{
    partial class Invoice
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
            this.lblSalesReceipt = new System.Windows.Forms.Label();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.outOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.outOrderDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.outCustomer = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.outSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.outTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.outTotal = new System.Windows.Forms.Label();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.colProdNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnCloseReceipt = new System.Windows.Forms.Button();
            this.grpReceiptDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            this.grpReceiptDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalesReceipt
            // 
            this.lblSalesReceipt.AutoSize = true;
            this.lblSalesReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReceipt.Location = new System.Drawing.Point(223, 30);
            this.lblSalesReceipt.Name = "lblSalesReceipt";
            this.lblSalesReceipt.Size = new System.Drawing.Size(376, 32);
            this.lblSalesReceipt.TabIndex = 0;
            this.lblSalesReceipt.Text = "Bike Store || Sales Receipt";
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Location = new System.Drawing.Point(237, 45);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(133, 16);
            this.lblSalesOrder.TabIndex = 1;
            this.lblSalesOrder.Text = "Sales Order Number:";
            // 
            // outOrderNumber
            // 
            this.outOrderNumber.AutoSize = true;
            this.outOrderNumber.Location = new System.Drawing.Point(480, 45);
            this.outOrderNumber.Name = "outOrderNumber";
            this.outOrderNumber.Size = new System.Drawing.Size(72, 16);
            this.outOrderNumber.TabIndex = 2;
            this.outOrderNumber.Text = "SO-000123";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(237, 84);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(76, 16);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // outOrderDate
            // 
            this.outOrderDate.AutoSize = true;
            this.outOrderDate.Location = new System.Drawing.Point(480, 84);
            this.outOrderDate.Name = "outOrderDate";
            this.outOrderDate.Size = new System.Drawing.Size(71, 16);
            this.outOrderDate.TabIndex = 4;
            this.outOrderDate.Text = "11/16/2026";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(237, 125);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(67, 16);
            this.lblCustomer.TabIndex = 5;
            this.lblCustomer.Text = "Customer:";
            // 
            // outCustomer
            // 
            this.outCustomer.AutoSize = true;
            this.outCustomer.Location = new System.Drawing.Point(480, 125);
            this.outCustomer.Name = "outCustomer";
            this.outCustomer.Size = new System.Drawing.Size(73, 16);
            this.outCustomer.TabIndex = 6;
            this.outCustomer.Text = "Jane Smith";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(611, 440);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(59, 16);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // outSubtotal
            // 
            this.outSubtotal.AutoSize = true;
            this.outSubtotal.Location = new System.Drawing.Point(677, 440);
            this.outSubtotal.Name = "outSubtotal";
            this.outSubtotal.Size = new System.Drawing.Size(52, 16);
            this.outSubtotal.TabIndex = 8;
            this.outSubtotal.Text = "$520.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(611, 472);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 16);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // outTax
            // 
            this.outTax.AutoSize = true;
            this.outTax.Location = new System.Drawing.Point(677, 472);
            this.outTax.Name = "outTax";
            this.outTax.Size = new System.Drawing.Size(45, 16);
            this.outTax.TabIndex = 10;
            this.outTax.Text = "$31.20";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(611, 505);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "TOTAL:";
            // 
            // outTotal
            // 
            this.outTotal.AutoSize = true;
            this.outTotal.Location = new System.Drawing.Point(677, 505);
            this.outTotal.Name = "outTotal";
            this.outTotal.Size = new System.Drawing.Size(52, 16);
            this.outTotal.TabIndex = 12;
            this.outTotal.Text = "$551.20";
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdNum,
            this.colProdName,
            this.colQuantity,
            this.colUnitPrice,
            this.colLineTotal});
            this.dgvReceipt.Location = new System.Drawing.Point(27, 263);
            this.dgvReceipt.MultiSelect = false;
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersVisible = false;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.RowTemplate.Height = 24;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(780, 150);
            this.dgvReceipt.TabIndex = 13;
            this.dgvReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellContentClick);
            // 
            // colProdNum
            // 
            this.colProdNum.HeaderText = "Product Number";
            this.colProdNum.MinimumWidth = 6;
            this.colProdNum.Name = "colProdNum";
            this.colProdNum.ReadOnly = true;
            // 
            // colProdName
            // 
            this.colProdName.HeaderText = "Product Name";
            this.colProdName.MinimumWidth = 6;
            this.colProdName.Name = "colProdName";
            this.colProdName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.MinimumWidth = 6;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colLineTotal
            // 
            this.colLineTotal.HeaderText = "Total";
            this.colLineTotal.MinimumWidth = 6;
            this.colLineTotal.Name = "colLineTotal";
            this.colLineTotal.ReadOnly = true;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(327, 449);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(165, 62);
            this.btnPrintReceipt.TabIndex = 14;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnCloseReceipt
            // 
            this.btnCloseReceipt.Location = new System.Drawing.Point(115, 449);
            this.btnCloseReceipt.Name = "btnCloseReceipt";
            this.btnCloseReceipt.Size = new System.Drawing.Size(165, 62);
            this.btnCloseReceipt.TabIndex = 15;
            this.btnCloseReceipt.Text = "Close";
            this.btnCloseReceipt.UseVisualStyleBackColor = true;
            this.btnCloseReceipt.Click += new System.EventHandler(this.btnCloseReceipt_Click);
            // 
            // grpReceiptDetails
            // 
            this.grpReceiptDetails.Controls.Add(this.outOrderDate);
            this.grpReceiptDetails.Controls.Add(this.lblSalesOrder);
            this.grpReceiptDetails.Controls.Add(this.outOrderNumber);
            this.grpReceiptDetails.Controls.Add(this.lblOrderDate);
            this.grpReceiptDetails.Controls.Add(this.lblCustomer);
            this.grpReceiptDetails.Controls.Add(this.outCustomer);
            this.grpReceiptDetails.Location = new System.Drawing.Point(12, 78);
            this.grpReceiptDetails.Name = "grpReceiptDetails";
            this.grpReceiptDetails.Size = new System.Drawing.Size(808, 463);
            this.grpReceiptDetails.TabIndex = 16;
            this.grpReceiptDetails.TabStop = false;
            this.grpReceiptDetails.Text = "Details";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.btnCloseReceipt);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.dgvReceipt);
            this.Controls.Add(this.outTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.outTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.outSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSalesReceipt);
            this.Controls.Add(this.grpReceiptDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice / Receipt";
            this.Load += new System.EventHandler(this.Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            this.grpReceiptDetails.ResumeLayout(false);
            this.grpReceiptDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReceipt;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Label outOrderNumber;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label outOrderDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label outCustomer;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label outSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label outTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label outTotal;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineTotal;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnCloseReceipt;
        private System.Windows.Forms.GroupBox grpReceiptDetails;
    }
}