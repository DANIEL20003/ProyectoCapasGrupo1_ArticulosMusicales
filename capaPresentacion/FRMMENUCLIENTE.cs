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
    public partial class FRMMENUCLIENTE : Form
    {
        public FRMMENUCLIENTE()
        {
            InitializeComponent();
        }

        private void pcb_catalogo_Click(object sender, EventArgs e)
        {
            FRMCLIENTE objCli = new FRMCLIENTE();
            objCli.ShowDialog();
        }

        private void pcb_carrito_Click(object sender, EventArgs e)
        {
            FRMCARRITO objtcarrito = new FRMCARRITO();
           objtcarrito.ShowDialog();
        }

        private void lbl_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
