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
            this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesReportToolStripMenuItem
            // 
            this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
            this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salesReportToolStripMenuItem.Text = "Sales Report";
            this.salesReportToolStripMenuItem.Click += new System.EventHandler(this.salesReportsFormBttn_Click);
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.errorLogToolStripMenuItem.Text = "Error Log";
            this.errorLogToolStripMenuItem.Click += new System.EventHandler(this.errorLogFormBttn_Click);
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
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(204, 48);
            this.mainMenuLabel.MaximumSize = new System.Drawing.Size(1000, 0);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(356, 37);
            this.mainMenuLabel.TabIndex = 1;
            this.mainMenuLabel.Text = "Bike Store — Main Menu";
            this.mainMenuLabel.Click += new System.EventHandler(this.mainMenuLabel_Click);
            // 
            // shoppingCartFormBttn
            // 
            this.shoppingCartFormBttn.Location = new System.Drawing.Point(129, 149);
            this.shoppingCartFormBttn.Name = "shoppingCartFormBttn";
            this.shoppingCartFormBttn.Size = new System.Drawing.Size(240, 23);
            this.shoppingCartFormBttn.TabIndex = 2;
            this.shoppingCartFormBttn.Text = "Shopping Cart ";
            this.shoppingCartFormBttn.UseVisualStyleBackColor = true;
            // 
            // customerMaintenanceFormBttn
            // 
            this.customerMaintenanceFormBttn.Location = new System.Drawing.Point(129, 194);
            this.customerMaintenanceFormBttn.Name = "customerMaintenanceFormBttn";
            this.customerMaintenanceFormBttn.Size = new System.Drawing.Size(240, 23);
            this.customerMaintenanceFormBttn.TabIndex = 3;
            this.customerMaintenanceFormBttn.Text = "Customer Maintenance";
            this.customerMaintenanceFormBttn.UseVisualStyleBackColor = true;
            this.customerMaintenanceFormBttn.Click += new System.EventHandler(this.customerMaintenanceFormBttn_Click);
            // 
            // errorLogFormBttn
            // 
            this.errorLogFormBttn.Location = new System.Drawing.Point(129, 250);
            this.errorLogFormBttn.Name = "errorLogFormBttn";
            this.errorLogFormBttn.Size = new System.Drawing.Size(240, 23);
            this.errorLogFormBttn.TabIndex = 4;
            this.errorLogFormBttn.Text = "Error Log";
            this.errorLogFormBttn.UseVisualStyleBackColor = true;
            this.errorLogFormBttn.Click += new System.EventHandler(this.errorLogFormBttn_Click);
            // 
            // productMaintenanceFormBttn
            // 
            this.productMaintenanceFormBttn.Location = new System.Drawing.Point(434, 149);
            this.productMaintenanceFormBttn.Name = "productMaintenanceFormBttn";
            this.productMaintenanceFormBttn.Size = new System.Drawing.Size(221, 23);
            this.productMaintenanceFormBttn.TabIndex = 5;
            this.productMaintenanceFormBttn.Text = "Product Maintenance";
            this.productMaintenanceFormBttn.UseVisualStyleBackColor = true;
            this.productMaintenanceFormBttn.Click += new System.EventHandler(this.productMaintenanceFormBttn_Click);
            // 
            // salesReportsFormBttn
            // 
            this.salesReportsFormBttn.Location = new System.Drawing.Point(434, 194);
            this.salesReportsFormBttn.Name = "salesReportsFormBttn";
            this.salesReportsFormBttn.Size = new System.Drawing.Size(221, 23);
            this.salesReportsFormBttn.TabIndex = 6;
            this.salesReportsFormBttn.Text = "Sales Reports";
            this.salesReportsFormBttn.UseVisualStyleBackColor = true;
            this.salesReportsFormBttn.Click += new System.EventHandler(this.salesReportsFormBttn_Click);
            // 
            // logoutBttn
            // 
            this.logoutBttn.AutoEllipsis = true;
            this.logoutBttn.Location = new System.Drawing.Point(434, 250);
            this.logoutBttn.Name = "logoutBttn";
            this.logoutBttn.Size = new System.Drawing.Size(221, 23);
            this.logoutBttn.TabIndex = 7;
            this.logoutBttn.Text = "Logout";
            this.logoutBttn.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
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

