namespace capaPresentacion
{
    partial class FRMREPORTE5
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
            this.bDPRACTICALBDataSet6 = new capaPresentacion.BDPRACTICALBDataSet6();
            this.vistaVentasPorProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVentasPorProveedorTableAdapter = new capaPresentacion.BDPRACTICALBDataSet6TableAdapters.VistaVentasPorProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasPorProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaVentasPorProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet6
            // 
            this.bDPRACTICALBDataSet6.DataSetName = "BDPRACTICALBDataSet6";
            this.bDPRACTICALBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVentasPorProveedorBindingSource
            // 
            this.vistaVentasPorProveedorBindingSource.DataMember = "VistaVentasPorProveedor";
            this.vistaVentasPorProveedorBindingSource.DataSource = this.bDPRACTICALBDataSet6;
            // 
            // vistaVentasPorProveedorTableAdapter
            // 
            this.vistaVentasPorProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTE5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE5";
            this.Text = "FRMREPORTE5";
            this.Load += new System.EventHandler(this.FRMREPORTE5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasPorProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet6 bDPRACTICALBDataSet6;
        private System.Windows.Forms.BindingSource vistaVentasPorProveedorBindingSource;
        private BDPRACTICALBDataSet6TableAdapters.VistaVentasPorProveedorTableAdapter vistaVentasPorProveedorTableAdapter;
    }
}