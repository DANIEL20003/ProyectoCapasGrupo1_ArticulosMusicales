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
    public partial class FRMREPORTE6 : Form
    {
        public FRMREPORTE6()
        {
            InitializeComponent();
        }

        private void FRMREPORTE6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPRACTICALBDataSet7.VistaVentasPorCategoria' Puede moverla o quitarla según sea necesario.
            this.vistaVentasPorCategoriaTableAdapter.Fill(this.bDPRACTICALBDataSet7.VistaVentasPorCategoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
