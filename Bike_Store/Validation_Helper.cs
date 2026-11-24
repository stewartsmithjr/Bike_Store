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
        public static DateTime CombineDateAndTime(DateTimePicker datePicker, DateTimePicker timePicker)
        {
            return datePicker.Value.Date
                .AddHours(timePicker.Value.Hour)
                .AddMinutes(timePicker.Value.Minute);
        }

        public static bool ValidDateTimeRange(
            DateTimePicker startDate, DateTimePicker startTime,
            DateTimePicker endDate, DateTimePicker endTime)
        {
            DateTime start = CombineDateAndTime(startDate, startTime);
            DateTime end = CombineDateAndTime(endDate, endTime);

            if (start > DateTime.Now)
            {
                MessageBox.Show("The start date and time cannot be in the future.", "# Validation Error #", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (startDate.Value.Date == DateTime.Today ? startTime : startDate).Focus();
                return false;
            }

            if (start > end)
            {
                MessageBox.Show("The start date and time must be on or before the end date and time.", "# Validation Error #", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                (startDate.Value.Date == endDate.Value.Date ? endTime : endDate).Focus();
                return false;
            }
            return true;
        }

        public static void ResetDateTimeRange(
            DateTimePicker startDate, DateTimePicker startTime,
            DateTimePicker endDate, DateTimePicker endTime)
        {
            DateTime today = DateTime.Today;

            startDate.MaxDate = today;
            endDate.MaxDate = today;

            startDate.Value = new DateTime(today.Year, today.Month, 1);
            startTime.Value = today;
            endDate.Value = today;
            endTime.Value = today.AddHours(23).AddMinutes(59);
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
