namespace capaPresentacion
{
    partial class FRMREPORTE6
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
            this.bDPRACTICALBDataSet7 = new capaPresentacion.BDPRACTICALBDataSet7();
            this.bDPRACTICALBDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVentasPorCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVentasPorCategoriaTableAdapter = new capaPresentacion.BDPRACTICALBDataSet7TableAdapters.VistaVentasPorCategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasPorCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaVentasPorCategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet7
            // 
            this.bDPRACTICALBDataSet7.DataSetName = "BDPRACTICALBDataSet7";
            this.bDPRACTICALBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDPRACTICALBDataSet7BindingSource
            // 
            this.bDPRACTICALBDataSet7BindingSource.DataSource = this.bDPRACTICALBDataSet7;
            this.bDPRACTICALBDataSet7BindingSource.Position = 0;
            // 
            // vistaVentasPorCategoriaBindingSource
            // 
            this.vistaVentasPorCategoriaBindingSource.DataMember = "VistaVentasPorCategoria";
            this.vistaVentasPorCategoriaBindingSource.DataSource = this.bDPRACTICALBDataSet7BindingSource;
            // 
            // vistaVentasPorCategoriaTableAdapter
            // 
            this.vistaVentasPorCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTE6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE6";
            this.Text = "FRMREPORTE6";
            this.Load += new System.EventHandler(this.FRMREPORTE6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasPorCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet7 bDPRACTICALBDataSet7;
        private System.Windows.Forms.BindingSource bDPRACTICALBDataSet7BindingSource;
        private System.Windows.Forms.BindingSource vistaVentasPorCategoriaBindingSource;
        private BDPRACTICALBDataSet7TableAdapters.VistaVentasPorCategoriaTableAdapter vistaVentasPorCategoriaTableAdapter;
    }
}