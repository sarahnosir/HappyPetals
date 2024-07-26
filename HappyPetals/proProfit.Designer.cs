
namespace HappyPetals
{
    partial class proProfit
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proProfit));
            this.Pro_profitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flower_shopDataSet = new HappyPetals.flower_shopDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Pro_profitTableAdapter = new HappyPetals.flower_shopDataSetTableAdapters.Pro_profitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Pro_profitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_shopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Pro_profitBindingSource
            // 
            this.Pro_profitBindingSource.DataMember = "Pro_profit";
            this.Pro_profitBindingSource.DataSource = this.flower_shopDataSet;
            // 
            // flower_shopDataSet
            // 
            this.flower_shopDataSet.DataSetName = "flower_shopDataSet";
            this.flower_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Pro_profitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HappyPetals.profit of products.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(529, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(986, 963);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Pro_profitTableAdapter
            // 
            this.Pro_profitTableAdapter.ClearBeforeFill = true;
            // 
            // proProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HappyPetals.Properties.Resources._8c7a0e3f34be5caae4aa3766cc477735;
            this.ClientSize = new System.Drawing.Size(1886, 1050);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proProfit";
            this.Text = "proProfit";
            this.Load += new System.EventHandler(this.proProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pro_profitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flower_shopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Pro_profitBindingSource;
        private flower_shopDataSet flower_shopDataSet;
        private flower_shopDataSetTableAdapters.Pro_profitTableAdapter Pro_profitTableAdapter;
    }
}