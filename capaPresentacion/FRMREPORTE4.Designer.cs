namespace capaPresentacion
{
    partial class FRMREPORTE4
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDPRACTICALBDataSet5 = new capaPresentacion.BDPRACTICALBDataSet5();
            this.vistaProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaProductosMasVendidosTableAdapter = new capaPresentacion.BDPRACTICALBDataSet5TableAdapters.VistaProductosMasVendidosTableAdapter();
            this.bDPRACTICALBDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaProductosMasVendidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosMasVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosMasVendidosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.vistaProductosMasVendidosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet5
            // 
            this.bDPRACTICALBDataSet5.DataSetName = "BDPRACTICALBDataSet5";
            this.bDPRACTICALBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaProductosMasVendidosBindingSource
            // 
            this.vistaProductosMasVendidosBindingSource.DataMember = "VistaProductosMasVendidos";
            this.vistaProductosMasVendidosBindingSource.DataSource = this.bDPRACTICALBDataSet5;
            // 
            // vistaProductosMasVendidosTableAdapter
            // 
            this.vistaProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // bDPRACTICALBDataSet5BindingSource
            // 
            this.bDPRACTICALBDataSet5BindingSource.DataSource = this.bDPRACTICALBDataSet5;
            this.bDPRACTICALBDataSet5BindingSource.Position = 0;
            // 
            // vistaProductosMasVendidosBindingSource1
            // 
            this.vistaProductosMasVendidosBindingSource1.DataMember = "VistaProductosMasVendidos";
            this.vistaProductosMasVendidosBindingSource1.DataSource = this.bDPRACTICALBDataSet5;
            // 
            // FRMREPORTE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE4";
            this.Text = "FRMREPORTE4";
            this.Load += new System.EventHandler(this.FRMREPORTE4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosMasVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosMasVendidosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet5 bDPRACTICALBDataSet5;
        private System.Windows.Forms.BindingSource vistaProductosMasVendidosBindingSource;
        private BDPRACTICALBDataSet5TableAdapters.VistaProductosMasVendidosTableAdapter vistaProductosMasVendidosTableAdapter;
        private System.Windows.Forms.BindingSource vistaProductosMasVendidosBindingSource1;
        private System.Windows.Forms.BindingSource bDPRACTICALBDataSet5BindingSource;
    }
}