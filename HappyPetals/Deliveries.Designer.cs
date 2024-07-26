
namespace HappyPetals
{
    partial class Deliveries
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deliveries));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_shopDataSet = new HappyPetals.flower_shopDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.deliveriesTableAdapter = new HappyPetals.flower_shopDataSetTableAdapters.DeliveriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIdDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveriesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(374, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 573);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vendorIdDataGridViewTextBoxColumn
            // 
            this.vendorIdDataGridViewTextBoxColumn.DataPropertyName = "vendorId";
            this.vendorIdDataGridViewTextBoxColumn.HeaderText = "vendorId";
            this.vendorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vendorIdDataGridViewTextBoxColumn.Name = "vendorIdDataGridViewTextBoxColumn";
            this.vendorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "productCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "productCode";
            this.productCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            this.productCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "deliverydate";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "deliverydate";
            this.deliverydateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.Width = 150;
            // 
            // deliveriesBindingSource
            // 
            this.deliveriesBindingSource.DataMember = "Deliveries";
            this.deliveriesBindingSource.DataSource = this.flower_shopDataSet;
            // 
            // flower_shopDataSet
            // 
            this.flower_shopDataSet.DataSetName = "flower_shopDataSet";
            this.flower_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HappyPetals.Properties.Resources._3b7beefaca8fbdd69a558a874d6535e4;
            this.button1.Location = new System.Drawing.Point(851, 834);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deliveriesTableAdapter
            // 
            this.deliveriesTableAdapter.ClearBeforeFill = true;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetals.Properties.Resources._8c7a0e3f34be5caae4aa3766cc477735;
            this.ClientSize = new System.Drawing.Size(1886, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deliveries";
            this.Text = "Deliveries";
            this.Load += new System.EventHandler(this.Deliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private flower_shopDataSet flower_shopDataSet;
        private System.Windows.Forms.BindingSource deliveriesBindingSource;
        private flower_shopDataSetTableAdapters.DeliveriesTableAdapter deliveriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
    }
}