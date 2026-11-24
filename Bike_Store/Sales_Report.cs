using System;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            Validation_Helper.ResetDateTimeRange(dtpStartDate, dtpStartTime, dtpEndDate, dtpEndTime);

            // Sample rows from the screen design so the layout can be reviewed.
            DateTime today = DateTime.Today;
            dgvSalesReport.Rows.Clear();
            dgvSalesReport.Rows.Add("SO71780", "BK-R50R-44", "Road-650 Red, 44", 1, today.AddHours(9.25), 419.46m);
            dgvSalesReport.Rows.Add("SO71780", "BC-R205", "Road Bottle Cage", 2, today.AddHours(9.25), 10.79m);
            dgvSalesReport.Rows.Add("SO71782", "HL-U509", "Sport-100 Helmet, Black", 3, today.AddHours(16.75), 62.99m);

            outTotalSold.Text = "$493.24";
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (!Validation_Helper.ValidDateTimeRange(dtpStartDate, dtpStartTime, dtpEndDate, dtpEndTime))
                return;

            MessageBox.Show(
                "Report date and time range passed validation.",
                "Validation Successful!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report export is not implemented yet.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
