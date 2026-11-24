using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bike_Store
{
    public static class Validation_Helper
    {
        public static bool Required(TextBox textBox, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(fieldName + " is required.", "# Validation Error #", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;

            }
            return true;
        }
        public static bool ValidEmail(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return true;

            bool valid = Regex.IsMatch(textBox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!valid)
            {
                MessageBox.Show("Please enter a valid email address.", "# Validation Error #", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
            }
            return valid;
        }
        public static void ClearControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                if (control.HasChildren)
                    ClearControls(control);
            }
        }
    }
}
