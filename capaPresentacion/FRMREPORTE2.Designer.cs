namespace capaPresentacion
{
    partial class FRMREPORTE2
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
            this.bDPRACTICALBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPRACTICALBDataSet1 = new capaPresentacion.BDPRACTICALBDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vistaResumenComprasClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaResumenComprasClienteTableAdapter = new capaPresentacion.BDPRACTICALBDataSet1TableAdapters.VistaResumenComprasClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaResumenComprasClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDPRACTICALBDataSet1BindingSource
            // 
            this.bDPRACTICALBDataSet1BindingSource.DataSource = this.bDPRACTICALBDataSet1;
            this.bDPRACTICALBDataSet1BindingSource.Position = 0;
            // 
            // bDPRACTICALBDataSet1
            // 
            this.bDPRACTICALBDataSet1.DataSetName = "BDPRACTICALBDataSet1";
            this.bDPRACTICALBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.vistaResumenComprasClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vistaResumenComprasClienteBindingSource
            // 
            this.vistaResumenComprasClienteBindingSource.DataMember = "VistaResumenComprasCliente";
            this.vistaResumenComprasClienteBindingSource.DataSource = this.bDPRACTICALBDataSet1BindingSource;
            // 
            // vistaResumenComprasClienteTableAdapter
            // 
            this.vistaResumenComprasClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FRMREPORTE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMREPORTE2";
            this.Text = "FRMREPORTE2";
            this.Load += new System.EventHandler(this.FRMREPORTE2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPRACTICALBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaResumenComprasClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDPRACTICALBDataSet1BindingSource;
        private BDPRACTICALBDataSet1 bDPRACTICALBDataSet1;
        private System.Windows.Forms.BindingSource vistaResumenComprasClienteBindingSource;
        private BDPRACTICALBDataSet1TableAdapters.VistaResumenComprasClienteTableAdapter vistaResumenComprasClienteTableAdapter;
    }
}