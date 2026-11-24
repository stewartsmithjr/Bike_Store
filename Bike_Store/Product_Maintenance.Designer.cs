namespace Bike_Store
{
    partial class Product_Maintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductNumber = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblListPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblExistingProducts = new System.Windows.Forms.Label();

            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtListPrice = new System.Windows.Forms.TextBox();

            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // Product ID Label
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(25, 25);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Text = "Product ID:";

            // Product ID TextBox
            this.txtProductID.Location = new System.Drawing.Point(25, 48);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(175, 25);
            this.txtProductID.ReadOnly = true;

            // Product Number Label
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(240, 25);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Text = "Product Number:";

            // Product Number TextBox
            this.txtProductNumber.Location = new System.Drawing.Point(240, 48);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(210, 25);
            this.txtProductNumber.MaxLength = 25;

            // Product Name Label
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(485, 25);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Text = "Product Name:";

            // Product Name TextBox
            this.txtProductName.Location = new System.Drawing.Point(485, 48);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(270, 25);
            this.txtProductName.MaxLength = 50;

            // List Price Label
            this.lblListPrice.AutoSize = true;
            this.lblListPrice.Location = new System.Drawing.Point(25, 100);
            this.lblListPrice.Name = "lblListPrice";
            this.lblListPrice.Text = "List Price:";

            // List Price TextBox
            this.txtListPrice.Location = new System.Drawing.Point(25, 123);
            this.txtListPrice.Name = "txtListPrice";
            this.txtListPrice.Size = new System.Drawing.Size(175, 25);

            // Product Category Label
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(240, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Product Category:";

            // Product Category ComboBox
            this.cboCategory.Location = new System.Drawing.Point(240, 123);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(210, 25);
            this.cboCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Product Model Label
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(485, 100);
            this.lblModel.Name = "lblModel";
            this.lblModel.Text = "Product Model:";

            // Product Model ComboBox
            this.cboModel.Location = new System.Drawing.Point(485, 123);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(270, 25);
            this.cboModel.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Search Button
            this.btnSearch.Location = new System.Drawing.Point(25, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 32);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;

            // Add Product Button
            this.btnAddProduct.Location = new System.Drawing.Point(175, 175);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 32);
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;

            // Update Product Button
            this.btnUpdateProduct.Location = new System.Drawing.Point(325, 175);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(140, 32);
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;

            // Clear Button
            this.btnClear.Location = new System.Drawing.Point(485, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 32);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;

            // Existing Products Label
            this.lblExistingProducts.AutoSize = true;
            this.lblExistingProducts.Location = new System.Drawing.Point(25, 230);
            this.lblExistingProducts.Name = "lblExistingProducts";
            this.lblExistingProducts.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExistingProducts.Text = "Existing Products";

            // DataGridView Columns
            this.colProductID.HeaderText = "Product ID";
            this.colProductID.Name = "colProductID";

            this.colProductNumber.HeaderText = "Product Number";
            this.colProductNumber.Name = "colProductNumber";

            this.colProductName.HeaderText = "Name";
            this.colProductName.Name = "colProductName";

            this.colListPrice.HeaderText = "List Price";
            this.colListPrice.Name = "colListPrice";
            this.colListPrice.DefaultCellStyle.Format = "C2";

            // Existing Products DataGridView
            this.dgvProducts.Location = new System.Drawing.Point(25, 260);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(730, 210);
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvProducts.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.colProductID,
                    this.colProductNumber,
                    this.colProductName,
                    this.colListPrice
                });

            // Product Maintenance Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Product_Maintenance";
            this.Text = "Product Maintenance";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductNumber);
            this.Controls.Add(this.txtProductNumber);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblListPrice);
            this.Controls.Add(this.txtListPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblExistingProducts);
            this.Controls.Add(this.dgvProducts);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductNumber;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblListPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblExistingProducts;

        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtListPrice;

        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboModel;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListPrice;
    }
}