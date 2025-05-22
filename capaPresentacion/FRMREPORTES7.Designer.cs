namespace capaPresentacion
{
    partial class FRMREPORTES7
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
            this.bDPRACTICALBDataSet8 = new capaPresentacion.BDPRACTICALBDataSet8();
            this.vistaProductosNoVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaProductosNoVendidosTableAdapter = new capaPresentacion.BDPRACTICALBDataSet8TableAdapters.VistaProductosNoVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosNoVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaProductosNoVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet8
            // 
            this.bDPRACTICALBDataSet8.DataSetName = "BDPRACTICALBDataSet8";
            this.bDPRACTICALBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaProductosNoVendidosBindingSource
            // 
            this.vistaProductosNoVendidosBindingSource.DataMember = "VistaProductosNoVendidos";
            this.vistaProductosNoVendidosBindingSource.DataSource = this.bDPRACTICALBDataSet8;
            // 
            // vistaProductosNoVendidosTableAdapter
            // 
            this.vistaProductosNoVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTES7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTES7";
            this.Text = "FRMREPORTES7";
            this.Load += new System.EventHandler(this.FRMREPORTES7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosNoVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet8 bDPRACTICALBDataSet8;
        private System.Windows.Forms.BindingSource vistaProductosNoVendidosBindingSource;
        private BDPRACTICALBDataSet8TableAdapters.VistaProductosNoVendidosTableAdapter vistaProductosNoVendidosTableAdapter;
    }
}