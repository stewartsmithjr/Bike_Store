using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Customer_Maintenance : Form
    {
        public Customer_Maintenance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!Validation_Helper.Required(
                txtFirstName, "First Name"))
                return;

            if (!Validation_Helper.Required(
                txtLastName, "Last Name"))
                return;

            if (!Validation_Helper.ValidEmail(txtEmail))
                return;
            if (maskedtxtPhone.MaskedTextProvider.AssignedEditPositionCount > 0
                && !maskedtxtPhone.MaskCompleted)
            {
                MessageBox.Show(
                    "Please enter a complete phone number.",
                    "# Validation Error #");

                maskedtxtPhone.Focus();
                return;
            }

            MessageBox.Show(
                "Customer information passed validation.",
                "Validation Successful!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Validation_Helper.ClearControls(this);
            txtFirstName.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database operations are not implemented yet.");
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Database operations are not implemented yet.");
        }
    }
    
}
