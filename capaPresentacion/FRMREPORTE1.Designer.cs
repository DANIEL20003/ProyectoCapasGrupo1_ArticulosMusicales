namespace capaPresentacion
{
    partial class FRMREPORTE1
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
            this.bDPRACTICALBDataSet = new capaPresentacion.BDPRACTICALBDataSet();
            this.vistaCarritoClienteProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCarritoClienteProductoTableAdapter = new capaPresentacion.BDPRACTICALBDataSetTableAdapters.VistaCarritoClienteProductoTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.vistaCarritoClienteProductoTableAdapter1 = new capaPresentacion.BDPRACTICALBDataSetTableAdapters.VistaCarritoClienteProductoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCarritoClienteProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDPRACTICALBDataSet
            // 
            this.bDPRACTICALBDataSet.DataSetName = "BDPRACTICALBDataSet";
            this.bDPRACTICALBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCarritoClienteProductoBindingSource
            // 
            this.vistaCarritoClienteProductoBindingSource.DataMember = "VistaCarritoClienteProducto";
            this.vistaCarritoClienteProductoBindingSource.DataSource = this.bDPRACTICALBDataSet;
            // 
            // vistaCarritoClienteProductoTableAdapter
            // 
            this.vistaCarritoClienteProductoTableAdapter.ClearBeforeFill = true;
            // 
            // vistaCarritoClienteProductoTableAdapter1
            // 
            this.vistaCarritoClienteProductoTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaCarritoClienteProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(893, 487);
            this.reportViewer1.TabIndex = 0;
            // 
            // FRMREPORTE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 487);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE1";
            this.Text = "FRMREPORTE1";
            this.Load += new System.EventHandler(this.FRMREPORTE1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCarritoClienteProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDPRACTICALBDataSet bDPRACTICALBDataSet;
        private System.Windows.Forms.BindingSource vistaCarritoClienteProductoBindingSource;
        private BDPRACTICALBDataSetTableAdapters.VistaCarritoClienteProductoTableAdapter vistaCarritoClienteProductoTableAdapter;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private BDPRACTICALBDataSetTableAdapters.VistaCarritoClienteProductoTableAdapter vistaCarritoClienteProductoTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}