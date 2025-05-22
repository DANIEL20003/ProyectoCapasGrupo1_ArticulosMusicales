namespace capaPresentacion
{
    partial class FRMREPORTE3
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
            this.bDPRACTICALBDataSet2 = new capaPresentacion.BDPRACTICALBDataSet2();
            this.vistaProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaProductosTableAdapter = new capaPresentacion.BDPRACTICALBDataSet2TableAdapters.VistaProductosTableAdapter();
            this.vistaProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "productos";
            reportDataSource1.Value = this.vistaProductosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet2
            // 
            this.bDPRACTICALBDataSet2.DataSetName = "BDPRACTICALBDataSet2";
            this.bDPRACTICALBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaProductosBindingSource
            // 
            this.vistaProductosBindingSource.DataMember = "VistaProductos";
            this.vistaProductosBindingSource.DataSource = this.bDPRACTICALBDataSet2;
            // 
            // vistaProductosTableAdapter
            // 
            this.vistaProductosTableAdapter.ClearBeforeFill = true;
            // 
            // vistaProductosBindingSource1
            // 
            this.vistaProductosBindingSource1.DataMember = "VistaProductos";
            this.vistaProductosBindingSource1.DataSource = this.bDPRACTICALBDataSet2;
            // 
            // FRMREPORTE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE3";
            this.Text = "FRMREPORTE3";
            this.Load += new System.EventHandler(this.FRMREPORTE3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProductosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet2 bDPRACTICALBDataSet2;
        private System.Windows.Forms.BindingSource vistaProductosBindingSource;
        private BDPRACTICALBDataSet2TableAdapters.VistaProductosTableAdapter vistaProductosTableAdapter;
        private System.Windows.Forms.BindingSource vistaProductosBindingSource1;
    }
}