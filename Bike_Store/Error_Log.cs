using System;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Error_Log : Form
    {
        public Error_Log()
        {
            InitializeComponent();
        }

        private void Error_Log_Load(object sender, EventArgs e)
        {
            Validation_Helper.ResetDateTimeRange(dtpStartDate, dtpStartTime, dtpEndDate, dtpEndTime);

            // Sample rows from the screen design so the layout can be reviewed.
            DateTime today = DateTime.Today;
            dgvErrorLog.Rows.Clear();
            dgvErrorLog.Rows.Add(1002, today.AddHours(10.25), "BIKESTORE\\clerk2", 50000, "Order save failed.");
            dgvErrorLog.Rows.Add(1001, today.AddHours(9.5), "BIKESTORE\\clerk1", 50000, "Unable to retrieve product record.");
        }

        private void btnFilterErrors_Click(object sender, EventArgs e)
        {
            if (!Validation_Helper.ValidDateTimeRange(dtpStartDate, dtpStartTime, dtpEndDate, dtpEndTime))
                return;

            MessageBox.Show(
                "Error filter date and time range passed validation.",
                "Validation Successful!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Clears the screen back to the default filter range.
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Validation_Helper.ResetDateTimeRange(dtpStartDate, dtpStartTime, dtpEndDate, dtpEndTime);
            dgvErrorLog.ClearSelection();
            txtErrorDetails.Clear();
            dtpStartDate.Focus();
        }

        private void dgvErrorLog_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvErrorLog.SelectedRows.Count == 0)
            {
                txtErrorDetails.Clear();
                return;
            }

            DataGridViewRow row = dgvErrorLog.SelectedRows[0];
            txtErrorDetails.Text =
                "Error ID:      " + row.Cells[colErrorLogID.Index].FormattedValue + Environment.NewLine +
                "Error Time:    " + row.Cells[colErrorTime.Index].FormattedValue + Environment.NewLine +
                "User Name:     " + row.Cells[colUserName.Index].FormattedValue + Environment.NewLine +
                "Error Number:  " + row.Cells[colErrorNumber.Index].FormattedValue + Environment.NewLine +
                "Message:       " + row.Cells[colErrorMessage.Index].FormattedValue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
