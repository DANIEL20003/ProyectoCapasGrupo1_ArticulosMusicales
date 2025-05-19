using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using capaEntidades;
using capaLogica;


namespace capaPresentacion
{
    public partial class FRMCLIENTE : Form
    {
        public FRMCLIENTE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMCLIENTE_Load(object sender, EventArgs e)
        {
            nud_cantidad.Maximum = 200;
        }
    }
}
