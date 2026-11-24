namespace Bike_Store
{
    partial class Error_Log
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
            this.grpFilterRange = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilterErrors = new System.Windows.Forms.Button();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblErrorsHeading = new System.Windows.Forms.Label();
            this.dgvErrorLog = new System.Windows.Forms.DataGridView();
            this.colErrorLogID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblErrorDetails = new System.Windows.Forms.Label();
            this.txtErrorDetails = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFilterRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).BeginInit();
            this.SuspendLayout();
            //
            // grpFilterRange
            //
            this.grpFilterRange.Controls.Add(this.btnRefresh);
            this.grpFilterRange.Controls.Add(this.btnFilterErrors);
            this.grpFilterRange.Controls.Add(this.dtpEndTime);
            this.grpFilterRange.Controls.Add(this.lblEndTime);
            this.grpFilterRange.Controls.Add(this.dtpEndDate);
            this.grpFilterRange.Controls.Add(this.lblEndDate);
            this.grpFilterRange.Controls.Add(this.dtpStartTime);
            this.grpFilterRange.Controls.Add(this.lblStartTime);
            this.grpFilterRange.Controls.Add(this.dtpStartDate);
            this.grpFilterRange.Controls.Add(this.lblStartDate);
            this.grpFilterRange.Location = new System.Drawing.Point(12, 12);
            this.grpFilterRange.Name = "grpFilterRange";
            this.grpFilterRange.Size = new System.Drawing.Size(760, 80);
            this.grpFilterRange.TabIndex = 0;
            this.grpFilterRange.TabStop = false;
            this.grpFilterRange.Text = "Filter Range";
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
            // btnFilterErrors
            //
            this.btnFilterErrors.Location = new System.Drawing.Point(500, 40);
            this.btnFilterErrors.Name = "btnFilterErrors";
            this.btnFilterErrors.Size = new System.Drawing.Size(120, 25);
            this.btnFilterErrors.TabIndex = 8;
            this.btnFilterErrors.Text = "&Filter Errors";
            this.btnFilterErrors.UseVisualStyleBackColor = true;
            this.btnFilterErrors.Click += new System.EventHandler(this.btnFilterErrors_Click);
            //
            // btnRefresh
            //
            this.btnRefresh.Location = new System.Drawing.Point(626, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 25);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // lblErrorsHeading
            //
            this.lblErrorsHeading.AutoSize = true;
            this.lblErrorsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorsHeading.Location = new System.Drawing.Point(12, 104);
            this.lblErrorsHeading.Name = "lblErrorsHeading";
            this.lblErrorsHeading.Size = new System.Drawing.Size(160, 13);
            this.lblErrorsHeading.TabIndex = 1;
            this.lblErrorsHeading.Text = "Logged Application Errors";
            //
            // dgvErrorLog
            //
            this.dgvErrorLog.AllowUserToAddRows = false;
            this.dgvErrorLog.AllowUserToDeleteRows = false;
            this.dgvErrorLog.AllowUserToResizeRows = false;
            this.dgvErrorLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrorLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvErrorLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colErrorLogID,
            this.colErrorTime,
            this.colUserName,
            this.colErrorNumber,
            this.colErrorMessage});
            this.dgvErrorLog.Location = new System.Drawing.Point(12, 122);
            this.dgvErrorLog.MultiSelect = false;
            this.dgvErrorLog.Name = "dgvErrorLog";
            this.dgvErrorLog.ReadOnly = true;
            this.dgvErrorLog.RowHeadersVisible = false;
            this.dgvErrorLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrorLog.Size = new System.Drawing.Size(760, 210);
            this.dgvErrorLog.TabIndex = 2;
            this.dgvErrorLog.SelectionChanged += new System.EventHandler(this.dgvErrorLog_SelectionChanged);
            //
            // colErrorLogID
            //
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colErrorLogID.DefaultCellStyle = dataGridViewCellStyle1;
            this.colErrorLogID.FillWeight = 40F;
            this.colErrorLogID.HeaderText = "Error ID";
            this.colErrorLogID.Name = "colErrorLogID";
            this.colErrorLogID.ReadOnly = true;
            //
            // colErrorTime
            //
            dataGridViewCellStyle2.Format = "MM/dd/yyyy HH:mm";
            this.colErrorTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.colErrorTime.FillWeight = 75F;
            this.colErrorTime.HeaderText = "Error Date / Time";
            this.colErrorTime.Name = "colErrorTime";
            this.colErrorTime.ReadOnly = true;
            //
            // colUserName
            //
            this.colUserName.FillWeight = 75F;
            this.colUserName.HeaderText = "User Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            //
            // colErrorNumber
            //
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colErrorNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.colErrorNumber.FillWeight = 65F;
            this.colErrorNumber.HeaderText = "Error Number";
            this.colErrorNumber.Name = "colErrorNumber";
            this.colErrorNumber.ReadOnly = true;
            //
            // colErrorMessage
            //
            this.colErrorMessage.FillWeight = 200F;
            this.colErrorMessage.HeaderText = "Error Message";
            this.colErrorMessage.Name = "colErrorMessage";
            this.colErrorMessage.ReadOnly = true;
            //
            // lblErrorDetails
            //
            this.lblErrorDetails.AutoSize = true;
            this.lblErrorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDetails.Location = new System.Drawing.Point(12, 344);
            this.lblErrorDetails.Name = "lblErrorDetails";
            this.lblErrorDetails.Size = new System.Drawing.Size(145, 13);
            this.lblErrorDetails.TabIndex = 3;
            this.lblErrorDetails.Text = "Selected Error Details:";
            //
            // txtErrorDetails
            //
            this.txtErrorDetails.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorDetails.Location = new System.Drawing.Point(12, 362);
            this.txtErrorDetails.Multiline = true;
            this.txtErrorDetails.Name = "txtErrorDetails";
            this.txtErrorDetails.ReadOnly = true;
            this.txtErrorDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErrorDetails.Size = new System.Drawing.Size(760, 165);
            this.txtErrorDetails.TabIndex = 4;
            //
            // btnClose
            //
            this.btnClose.Location = new System.Drawing.Point(672, 537);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            //
            // Error_Log
            //
            this.AcceptButton = this.btnFilterErrors;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(784, 574);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtErrorDetails);
            this.Controls.Add(this.lblErrorDetails);
            this.Controls.Add(this.dgvErrorLog);
            this.Controls.Add(this.lblErrorsHeading);
            this.Controls.Add(this.grpFilterRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Error_Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Log";
            this.Load += new System.EventHandler(this.Error_Log_Load);
            this.grpFilterRange.ResumeLayout(false);
            this.grpFilterRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilterRange;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnFilterErrors;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblErrorsHeading;
        private System.Windows.Forms.DataGridView dgvErrorLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorLogID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorMessage;
        private System.Windows.Forms.Label lblErrorDetails;
        private System.Windows.Forms.TextBox txtErrorDetails;
        private System.Windows.Forms.Button btnClose;
    }
}
