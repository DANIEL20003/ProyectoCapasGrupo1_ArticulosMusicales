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
    public partial class FRMREPORTE3 : Form
    {
        public FRMREPORTE3()
        {
            InitializeComponent();
        }

        private void FRMREPORTE3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDPRACTICALBDataSet2.VistaProductos' Puede moverla o quitarla según sea necesario.
            this.vistaProductosTableAdapter.Fill(this.bDPRACTICALBDataSet2.VistaProductos);

            this.reportViewer1.RefreshReport();
        }
    }
}
