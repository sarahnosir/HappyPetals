
namespace HappyPetals
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveredOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonDeliveredOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productQuantitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::HappyPetals.Properties.Resources._3b7beefaca8fbdd69a558a874d6535e4;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainEntitiesToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1886, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainEntitiesToolStripMenuItem
            // 
            this.mainEntitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.vendorToolStripMenuItem,
            this.productToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.mainEntitiesToolStripMenuItem.Name = "mainEntitiesToolStripMenuItem";
            this.mainEntitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.mainEntitiesToolStripMenuItem.Text = "Main";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderDetailsToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deliveriesToolStripMenuItem});
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // deliveriesToolStripMenuItem
            // 
            this.deliveriesToolStripMenuItem.Name = "deliveriesToolStripMenuItem";
            this.deliveriesToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
            this.deliveriesToolStripMenuItem.Text = "Deliveries";
            this.deliveriesToolStripMenuItem.Click += new System.EventHandler(this.deliveriesToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryDetailsToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // inventoryDetailsToolStripMenuItem
            // 
            this.inventoryDetailsToolStripMenuItem.Name = "inventoryDetailsToolStripMenuItem";
            this.inventoryDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.inventoryDetailsToolStripMenuItem.Text = "Inventory Details";
            this.inventoryDetailsToolStripMenuItem.Click += new System.EventHandler(this.inventoryDetailsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerOrdersToolStripMenuItem,
            this.deliveredOrdersToolStripMenuItem,
            this.nonDeliveredOrdersToolStripMenuItem,
            this.productQuantitiesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // customerOrdersToolStripMenuItem
            // 
            this.customerOrdersToolStripMenuItem.Name = "customerOrdersToolStripMenuItem";
            this.customerOrdersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.customerOrdersToolStripMenuItem.Text = "Customer orders";
            this.customerOrdersToolStripMenuItem.Click += new System.EventHandler(this.customerOrdersToolStripMenuItem_Click);
            // 
            // deliveredOrdersToolStripMenuItem
            // 
            this.deliveredOrdersToolStripMenuItem.Name = "deliveredOrdersToolStripMenuItem";
            this.deliveredOrdersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.deliveredOrdersToolStripMenuItem.Text = "Delivered orders";
            this.deliveredOrdersToolStripMenuItem.Click += new System.EventHandler(this.deliveredOrdersToolStripMenuItem_Click);
            // 
            // nonDeliveredOrdersToolStripMenuItem
            // 
            this.nonDeliveredOrdersToolStripMenuItem.Name = "nonDeliveredOrdersToolStripMenuItem";
            this.nonDeliveredOrdersToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.nonDeliveredOrdersToolStripMenuItem.Text = "Non delivered orders";
            this.nonDeliveredOrdersToolStripMenuItem.Click += new System.EventHandler(this.nonDeliveredOrdersToolStripMenuItem_Click);
            // 
            // productQuantitiesToolStripMenuItem
            // 
            this.productQuantitiesToolStripMenuItem.Name = "productQuantitiesToolStripMenuItem";
            this.productQuantitiesToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.productQuantitiesToolStripMenuItem.Text = "Product quantities";
            this.productQuantitiesToolStripMenuItem.Click += new System.EventHandler(this.productQuantitiesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(652, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 116);
            this.label1.TabIndex = 1;
            this.label1.Text = "Happy Petals Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::HappyPetals.Properties.Resources._3b7beefaca8fbdd69a558a874d6535e4;
            this.button1.Location = new System.Drawing.Point(1615, 921);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 97);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetals.Properties.Resources._2f70d5fdb3eb79a514ff017ae396771e;
            this.ClientSize = new System.Drawing.Size(1886, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveredOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonDeliveredOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productQuantitiesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

