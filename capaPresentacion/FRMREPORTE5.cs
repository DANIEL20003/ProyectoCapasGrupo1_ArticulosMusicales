﻿using System;
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
    public partial class FRMREPORTE5 : Form
    {
        public FRMREPORTE5()
        {
            InitializeComponent();
        }

        private void FRMREPORTE5_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPRACTICALBDataSet6.VistaVentasPorProveedor' Puede moverla o quitarla según sea necesario.
            this.vistaVentasPorProveedorTableAdapter.Fill(this.bDPRACTICALBDataSet6.VistaVentasPorProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
