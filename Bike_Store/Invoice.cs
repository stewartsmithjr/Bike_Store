using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_Store
{
    public partial class Invoice : Form
    {

        private PrintDocument receiptDocument = new PrintDocument();


        public Invoice()
        {
            InitializeComponent();
        }

        private void dgvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            outOrderNumber.Text = "SO-000123";
            outOrderDate.Text = "11/16/2026";
            outCustomer.Text = "Jane Smith";

            dgvReceipt.Rows.Clear();

            dgvReceipt.Rows.Add("P-001","Mountain Bike",1,"$450.00","$450.00");

            dgvReceipt.Rows.Add("P-002","Helmet",2,"$35.00","$70.00");

            outSubtotal.Text = "$520.00";
            outTax.Text = "$31.20";
            outTotal.Text = "$551.20";
        }

        private void btnCloseReceipt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            ConfigureReceiptPaper();

            receiptDocument.PrintPage -= ReceiptDocument_PrintPage;
            receiptDocument.PrintPage += ReceiptDocument_PrintPage;

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = receiptDocument;
                preview.Width = 650;
                preview.Height = 800;
                preview.ShowDialog();
            }
        }


        private void ConfigureReceiptPaper()
        {

            receiptDocument.DefaultPageSettings.PaperSize =
                new PaperSize("80mm Receipt", 315, 700);

            receiptDocument.DefaultPageSettings.Margins =
                new Margins(12, 12, 15, 15);

        }


        private void ReceiptDocument_PrintPage(
            object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            float width = e.MarginBounds.Width;
            float right = e.MarginBounds.Right;

            using (Font titleFont = new Font(
                "Times New Roman", 16, FontStyle.Bold))
            using (Font headingFont = new Font(
                "Times New Roman", 10, FontStyle.Bold))
            using (Font bodyFont = new Font(
                "Times New Roman", 10, FontStyle.Regular))
            using (Font totalFont = new Font(
                "Times New Roman", 13, FontStyle.Bold))
            using (StringFormat center = new StringFormat())
            using (StringFormat rightAlign = new StringFormat())
            {
                center.Alignment = StringAlignment.Center;
                rightAlign.Alignment = StringAlignment.Far;

                g.DrawString(
                    "BIKE STORE",
                    titleFont, Brushes.Black,
                    new RectangleF(x, y, width, 30),
                    center);

                y += 30;

                g.DrawString(
                    "SALES RECEIPT",
                    headingFont, Brushes.Black,
                    new RectangleF(x, y, width, 25),
                    center);

                y += 35;

                g.DrawLine(Pens.Black, x, y, right, y);
                y += 12;

                g.DrawString(
                    "Order #: " + outOrderNumber.Text,
                    bodyFont, Brushes.Black, x, y);
                y += 22;

                g.DrawString(
                    "Date: " + outOrderDate.Text,
                    bodyFont, Brushes.Black, x, y);
                y += 22;

                g.DrawString(
                    "Customer: " + outCustomer.Text,
                    bodyFont, Brushes.Black, x, y);
                y += 30;

                float productX = x;
                float productWidth = width * 0.52f;

                float qtyX = x + width * 0.54f;
                float qtyWidth = width * 0.12f;

                float totalX = x + width * 0.68f;
                float totalWidth = right - totalX;

                g.DrawLine(Pens.Black, x, y, right, y);
                y += 10;

                g.DrawString(
                    "Product",
                    headingFont, Brushes.Black,
                    new RectangleF(
                        productX, y, productWidth, 22));

                g.DrawString(
                    "Qty",
                    headingFont, Brushes.Black,
                    new RectangleF(
                        qtyX, y, qtyWidth, 22),
                    center);

                g.DrawString(
                    "Total",
                    headingFont, Brushes.Black,
                    new RectangleF(
                        totalX, y, totalWidth, 22),
                    rightAlign);

                y += 25;

                g.DrawLine(Pens.Gray, x, y, right, y);
                y += 8;

                foreach (DataGridViewRow row in dgvReceipt.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string productName =
                        Convert.ToString(row.Cells[1].Value);

                    string quantity =
                        Convert.ToString(row.Cells[2].Value);

                    string lineTotal =
                        Convert.ToString(row.Cells[4].Value);

                    SizeF nameSize = g.MeasureString(
                        productName,
                        bodyFont,
                        new SizeF(productWidth, 1000));

                    float rowHeight = Math.Max(
                        28, nameSize.Height + 10);

                    g.DrawString(
                        productName,
                        bodyFont, Brushes.Black,
                        new RectangleF(
                            productX, y,
                            productWidth, rowHeight));

                    g.DrawString(
                        quantity,
                        bodyFont, Brushes.Black,
                        new RectangleF(
                            qtyX, y,
                            qtyWidth, rowHeight),
                        center);

                    g.DrawString(
                        lineTotal,
                        bodyFont, Brushes.Black,
                        new RectangleF(
                            totalX, y,
                            totalWidth, rowHeight),
                        rightAlign);

                    y += rowHeight;

                    g.DrawLine(
                        Pens.LightGray, x, y, right, y);

                    y += 6;
                }

                y += 12;

                g.DrawString(
                    "Subtotal",
                    bodyFont, Brushes.Black, x, y);

                g.DrawString(
                    outSubtotal.Text,
                    bodyFont, Brushes.Black,
                    new RectangleF(x, y, width, 22),
                    rightAlign);

                y += 25;

                g.DrawString(
                    "Tax",
                    bodyFont, Brushes.Black, x, y);

                g.DrawString(
                    outTax.Text,
                    bodyFont, Brushes.Black,
                    new RectangleF(x, y, width, 22),
                    rightAlign);

                y += 30;

                g.DrawLine(Pens.Black, x, y, right, y);
                y += 15;

                g.DrawString(
                    "TOTAL",
                    totalFont, Brushes.Black, x, y);

                g.DrawString(
                    outTotal.Text,
                    totalFont, Brushes.Black,
                    new RectangleF(x, y, width, 30),
                    rightAlign);

                y += 50;

                g.DrawLine(Pens.Gray, x, y, right, y);
                y += 15;

                g.DrawString(
                    "Thank you for shopping at our bike store!",
                    bodyFont, Brushes.Black,
                    new RectangleF(x, y, width, 45),
                    center);
            }

            e.HasMorePages = false;
        }


    }
}
