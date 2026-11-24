using System;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Shopping_Cart : Form
    {
        public Shopping_Cart()
        {
            InitializeComponent();

            btnSearch.Click += Search_Click;
            btnAddToCart.Click += AddToCart_Click;
            btnUpdateQty.Click += UpdateQty_Click;
            btnRemoveSelected.Click += RemoveSelected_Click;
            btnCompleteOrder.Click += CompleteOrder_Click;
        }

        private bool ValidateCartInput()
        {
            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.");
                cboCustomer.Focus();
                return false;
            }

            if (cboProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                cboProduct.Focus();
                return false;
            }

            if (!Validation_Helper.Required(txtQuantity, "Quantity"))
                return false;

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity)
                || quantity <= 0 || quantity > 32767)
            {
                MessageBox.Show("Please enter a quantity between 1 and 32767.");
                txtQuantity.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateOrder()
        {
            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer.");
                cboCustomer.Focus();
                return false;
            }

            foreach (DataGridViewRow row in dgvShoppingCart.Rows)
            {
                if (!row.IsNewRow)
                    return true;
            }

            MessageBox.Show("The shopping cart is empty.");
            return false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!Validation_Helper.Required(
                txtProductSearch, "Product Name"))
                return;

            // Database search will be added in Phase 3.
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (!ValidateCartInput())
                return;

            // Add product processing for Phase 3.
        }

        private void UpdateQty_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity)
                || quantity <= 0 || quantity > 32767)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return;
            }

            // Update quantity processing for Phase 3.
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvShoppingCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            // Remove item processing for Phase 3.
        }

        private void CompleteOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder())
                return;

            // Save order processing for Phase 3.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}