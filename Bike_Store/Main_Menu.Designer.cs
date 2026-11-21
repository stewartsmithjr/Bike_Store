namespace Bike_Store
{
    partial class Main_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintencanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.shoppingCartFormBttn = new System.Windows.Forms.Button();
            this.customerMaintenanceFormBttn = new System.Windows.Forms.Button();
            this.errorLogFormBttn = new System.Windows.Forms.Button();
            this.productMaintenanceFormBttn = new System.Windows.Forms.Button();
            this.salesReportsFormBttn = new System.Windows.Forms.Button();
            this.logoutBttn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.maintencanceToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.errorLogToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // maintencanceToolStripMenuItem
            // 
            this.maintencanceToolStripMenuItem.Name = "maintencanceToolStripMenuItem";
            this.maintencanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintencanceToolStripMenuItem.Text = "Maintenance";
            this.maintencanceToolStripMenuItem.Click += new System.EventHandler(this.maintencanceToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.errorLogToolStripMenuItem.Text = "Error Log";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(247, 76);
            this.mainMenuLabel.MaximumSize = new System.Drawing.Size(1000, 0);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(318, 32);
            this.mainMenuLabel.TabIndex = 1;
            this.mainMenuLabel.Text = "Bike Store — Main Menu";
            this.mainMenuLabel.Click += new System.EventHandler(this.mainMenuLabel_Click);
            // 
            // shoppingCartFormBttn
            // 
            this.shoppingCartFormBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.shoppingCartFormBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.shoppingCartFormBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoppingCartFormBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartFormBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shoppingCartFormBttn.Location = new System.Drawing.Point(133, 159);
            this.shoppingCartFormBttn.Name = "shoppingCartFormBttn";
            this.shoppingCartFormBttn.Size = new System.Drawing.Size(240, 39);
            this.shoppingCartFormBttn.TabIndex = 2;
            this.shoppingCartFormBttn.Text = "Shopping Cart ";
            this.shoppingCartFormBttn.UseVisualStyleBackColor = false;
            this.shoppingCartFormBttn.Click += new System.EventHandler(this.shoppingCartFormBttn_Click);
            // 
            // customerMaintenanceFormBttn
            // 
            this.customerMaintenanceFormBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.customerMaintenanceFormBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.customerMaintenanceFormBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerMaintenanceFormBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerMaintenanceFormBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customerMaintenanceFormBttn.Location = new System.Drawing.Point(133, 215);
            this.customerMaintenanceFormBttn.Name = "customerMaintenanceFormBttn";
            this.customerMaintenanceFormBttn.Size = new System.Drawing.Size(240, 39);
            this.customerMaintenanceFormBttn.TabIndex = 3;
            this.customerMaintenanceFormBttn.Text = "Customer Maintenance";
            this.customerMaintenanceFormBttn.UseVisualStyleBackColor = false;
            this.customerMaintenanceFormBttn.Click += new System.EventHandler(this.customerMaintenanceFormBttn_Click);
            // 
            // errorLogFormBttn
            // 
            this.errorLogFormBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.errorLogFormBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.errorLogFormBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLogFormBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLogFormBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorLogFormBttn.Location = new System.Drawing.Point(133, 271);
            this.errorLogFormBttn.Name = "errorLogFormBttn";
            this.errorLogFormBttn.Size = new System.Drawing.Size(240, 39);
            this.errorLogFormBttn.TabIndex = 4;
            this.errorLogFormBttn.Text = "Error Log";
            this.errorLogFormBttn.UseVisualStyleBackColor = false;
            this.errorLogFormBttn.Click += new System.EventHandler(this.errorLogFormBttn_Click);
            // 
            // productMaintenanceFormBttn
            // 
            this.productMaintenanceFormBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.productMaintenanceFormBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.productMaintenanceFormBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productMaintenanceFormBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaintenanceFormBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productMaintenanceFormBttn.Location = new System.Drawing.Point(438, 159);
            this.productMaintenanceFormBttn.Name = "productMaintenanceFormBttn";
            this.productMaintenanceFormBttn.Size = new System.Drawing.Size(221, 39);
            this.productMaintenanceFormBttn.TabIndex = 5;
            this.productMaintenanceFormBttn.Text = "Product Maintenance";
            this.productMaintenanceFormBttn.UseVisualStyleBackColor = false;
            this.productMaintenanceFormBttn.Click += new System.EventHandler(this.productMaintenanceFormBttn_Click);
            // 
            // salesReportsFormBttn
            // 
            this.salesReportsFormBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.salesReportsFormBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.salesReportsFormBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesReportsFormBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReportsFormBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salesReportsFormBttn.Location = new System.Drawing.Point(438, 215);
            this.salesReportsFormBttn.Name = "salesReportsFormBttn";
            this.salesReportsFormBttn.Size = new System.Drawing.Size(221, 39);
            this.salesReportsFormBttn.TabIndex = 6;
            this.salesReportsFormBttn.Text = "Sales Reports";
            this.salesReportsFormBttn.UseVisualStyleBackColor = false;
            this.salesReportsFormBttn.Click += new System.EventHandler(this.salesReportsFormBttn_Click);
            // 
            // logoutBttn
            // 
            this.logoutBttn.AutoEllipsis = true;
            this.logoutBttn.BackColor = System.Drawing.Color.Gainsboro;
            this.logoutBttn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.logoutBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBttn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBttn.Location = new System.Drawing.Point(438, 271);
            this.logoutBttn.Name = "logoutBttn";
            this.logoutBttn.Size = new System.Drawing.Size(221, 39);
            this.logoutBttn.TabIndex = 7;
            this.logoutBttn.Text = "Logout";
            this.logoutBttn.UseVisualStyleBackColor = false;
            this.logoutBttn.Click += new System.EventHandler(this.logoutBttn_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutBttn);
            this.Controls.Add(this.salesReportsFormBttn);
            this.Controls.Add(this.productMaintenanceFormBttn);
            this.Controls.Add(this.errorLogFormBttn);
            this.Controls.Add(this.customerMaintenanceFormBttn);
            this.Controls.Add(this.shoppingCartFormBttn);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintencanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button shoppingCartFormBttn;
        private System.Windows.Forms.Button customerMaintenanceFormBttn;
        private System.Windows.Forms.Button errorLogFormBttn;
        private System.Windows.Forms.Button productMaintenanceFormBttn;
        private System.Windows.Forms.Button salesReportsFormBttn;
        private System.Windows.Forms.Button logoutBttn;
    }
}

