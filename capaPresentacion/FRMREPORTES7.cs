using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FRMREPORTES7 : Form
    {
        public FRMREPORTES7()
        {
            InitializeComponent();
        }

        private void FRMREPORTES7_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPRACTICALBDataSet8.VistaProductosNoVendidos' Puede moverla o quitarla según sea necesario.
            this.vistaProductosNoVendidosTableAdapter.Fill(this.bDPRACTICALBDataSet8.VistaProductosNoVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
