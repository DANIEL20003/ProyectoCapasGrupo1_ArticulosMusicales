namespace capaPresentacion
{
    partial class FRMREPORTE8
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
            this.bDPRACTICALBDataSet9 = new capaPresentacion.BDPRACTICALBDataSet9();
            this.vistaResumenVentasDiariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaResumenVentasDiariasTableAdapter = new capaPresentacion.BDPRACTICALBDataSet9TableAdapters.VistaResumenVentasDiariasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaResumenVentasDiariasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaResumenVentasDiariasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDPRACTICALBDataSet9
            // 
            this.bDPRACTICALBDataSet9.DataSetName = "BDPRACTICALBDataSet9";
            this.bDPRACTICALBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaResumenVentasDiariasBindingSource
            // 
            this.vistaResumenVentasDiariasBindingSource.DataMember = "VistaResumenVentasDiarias";
            this.vistaResumenVentasDiariasBindingSource.DataSource = this.bDPRACTICALBDataSet9;
            // 
            // vistaResumenVentasDiariasTableAdapter
            // 
            this.vistaResumenVentasDiariasTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTE8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE8";
            this.Text = "FRMREPORTE8";
            this.Load += new System.EventHandler(this.FRMREPORTE8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaResumenVentasDiariasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDPRACTICALBDataSet9 bDPRACTICALBDataSet9;
        private System.Windows.Forms.BindingSource vistaResumenVentasDiariasBindingSource;
        private BDPRACTICALBDataSet9TableAdapters.VistaResumenVentasDiariasTableAdapter vistaResumenVentasDiariasTableAdapter;
    }
}