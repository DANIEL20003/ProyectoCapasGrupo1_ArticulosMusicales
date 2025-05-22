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
    public partial class FRMREPORTE1 : Form
    {
        public FRMREPORTE1()
        {
            InitializeComponent();
        }

        private void FRMREPORTE1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPRACTICALBDataSet.VistaCarritoClienteProducto' Puede moverla o quitarla según sea necesario.
            this.vistaCarritoClienteProductoTableAdapter.Fill(this.bDPRACTICALBDataSet.VistaCarritoClienteProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
