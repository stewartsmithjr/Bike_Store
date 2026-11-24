namespace Bike_Store
{
    partial class Sales_Report
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
            this.grpReportRange = new System.Windows.Forms.GroupBox();
            this.btnExportReport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblSalesHeading = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalSold = new System.Windows.Forms.Label();
            this.outTotalSold = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpReportRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            //
            // grpReportRange
            //
            this.grpReportRange.Controls.Add(this.btnExportReport);
            this.grpReportRange.Controls.Add(this.btnGenerateReport);
            this.grpReportRange.Controls.Add(this.dtpEndTime);
            this.grpReportRange.Controls.Add(this.lblEndTime);
            this.grpReportRange.Controls.Add(this.dtpEndDate);
            this.grpReportRange.Controls.Add(this.lblEndDate);
            this.grpReportRange.Controls.Add(this.dtpStartTime);
            this.grpReportRange.Controls.Add(this.lblStartTime);
            this.grpReportRange.Controls.Add(this.dtpStartDate);
            this.grpReportRange.Controls.Add(this.lblStartDate);
            this.grpReportRange.Location = new System.Drawing.Point(12, 12);
            this.grpReportRange.Name = "grpReportRange";
            this.grpReportRange.Size = new System.Drawing.Size(760, 80);
            this.grpReportRange.TabIndex = 0;
            this.grpReportRange.TabStop = false;
            this.grpReportRange.Text = "Report Range";
            //
            // lblStartDate
            //
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(15, 24);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            //
            // dtpStartDate
            //
            this.dtpStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(18, 42);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtpStartDate.TabIndex = 1;
            //
            // lblStartTime
            //
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(132, 24);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "Start Time:";
            //
            // dtpStartTime
            //
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(135, 42);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(70, 20);
            this.dtpStartTime.TabIndex = 3;
            //
            // lblEndDate
            //
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(226, 24);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date:";
            //
            // dtpEndDate
            //
            this.dtpEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(229, 42);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(100, 20);
            this.dtpEndDate.TabIndex = 5;
            //
            // lblEndTime
            //
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(343, 24);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End Time:";
            //
            // dtpEndTime
            //
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(346, 42);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(70, 20);
            this.dtpEndTime.TabIndex = 7;
            //
            // btnGenerateReport
            //
            this.btnGenerateReport.Location = new System.Drawing.Point(500, 40);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 25);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "&Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            //
            // btnExportReport
            //
            this.btnExportReport.Location = new System.Drawing.Point(626, 40);
            this.btnExportReport.Name = "btnExportReport";
            this.btnExportReport.Size = new System.Drawing.Size(120, 25);
            this.btnExportReport.TabIndex = 9;
            this.btnExportReport.Text = "&Export Report";
            this.btnExportReport.UseVisualStyleBackColor = true;
            this.btnExportReport.Click += new System.EventHandler(this.btnExportReport_Click);
            //
            // lblSalesHeading
            //
            this.lblSalesHeading.AutoSize = true;
            this.lblSalesHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesHeading.Location = new System.Drawing.Point(12, 104);
            this.lblSalesHeading.Name = "lblSalesHeading";
            this.lblSalesHeading.Size = new System.Drawing.Size(225, 13);
            this.lblSalesHeading.TabIndex = 1;
            this.lblSalesHeading.Text = "Sales Within Selected Date/Time Range";
            //
            // dgvSalesReport
            //
            this.dgvSalesReport.AllowUserToAddRows = false;
            this.dgvSalesReport.AllowUserToDeleteRows = false;
            this.dgvSalesReport.AllowUserToResizeRows = false;
            this.dgvSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesReport.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderNumber,
            this.colProductNumber,
            this.colProductName,
            this.colQty,
            this.colOrderDate,
            this.colTotalValue});
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 122);
            this.dgvSalesReport.MultiSelect = false;
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersVisible = false;
            this.dgvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReport.Size = new System.Drawing.Size(760, 360);
            this.dgvSalesReport.TabIndex = 2;
            //
            // colOrderNumber
            //
            this.colOrderNumber.FillWeight = 70F;
            this.colOrderNumber.HeaderText = "Order Number";
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.ReadOnly = true;
            //
            // colProductNumber
            //
            this.colProductNumber.FillWeight = 80F;
            this.colProductNumber.HeaderText = "Product Number";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.ReadOnly = true;
            //
            // colProductName
            //
            this.colProductName.FillWeight = 150F;
            this.colProductName.HeaderText = "Product Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            //
            // colQty
            //
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.colQty.FillWeight = 35F;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            //
            // colOrderDate
            //
            dataGridViewCellStyle2.Format = "MM/dd/yyyy HH:mm";
            this.colOrderDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colOrderDate.FillWeight = 80F;
            this.colOrderDate.HeaderText = "Order Date";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            //
            // colTotalValue
            //
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            this.colTotalValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTotalValue.FillWeight = 70F;
            this.colTotalValue.HeaderText = "Total Value";
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.ReadOnly = true;
            //
            // lblTotalSold
            //
            this.lblTotalSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSold.Location = new System.Drawing.Point(522, 493);
            this.lblTotalSold.Name = "lblTotalSold";
            this.lblTotalSold.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSold.TabIndex = 3;
            this.lblTotalSold.Text = "Total Sold:";
            this.lblTotalSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // outTotalSold
            //
            this.outTotalSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outTotalSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outTotalSold.Location = new System.Drawing.Point(628, 493);
            this.outTotalSold.Name = "outTotalSold";
            this.outTotalSold.Size = new System.Drawing.Size(144, 23);
            this.outTotalSold.TabIndex = 4;
            this.outTotalSold.Text = "$0.00";
            this.outTotalSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(12, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // Sales_Report
            //
            this.AcceptButton = this.btnGenerateReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 529);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.outTotalSold);
            this.Controls.Add(this.lblTotalSold);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.lblSalesHeading);
            this.Controls.Add(this.grpReportRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sales_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            this.grpReportRange.ResumeLayout(false);
            this.grpReportRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReportRange;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportReport;
        private System.Windows.Forms.Label lblSalesHeading;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalValue;
        private System.Windows.Forms.Label lblTotalSold;
        private System.Windows.Forms.Label outTotalSold;
        private System.Windows.Forms.Button btnClose;
    }
}
