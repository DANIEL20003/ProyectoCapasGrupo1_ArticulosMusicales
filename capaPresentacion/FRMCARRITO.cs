using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;
using capaEntidades;




namespace capaPresentacion
{
    public partial class FRMCARRITO : Form
    {
        clasePuente objtpuente = new clasePuente();
        Carrito objtc = new Carrito();
        
        public FRMCARRITO()
        {
            InitializeComponent();
            
        }

        private void FRMCARRITO_Load(object sender, EventArgs e)
        {
            DGVcarrito.DataSource = objtpuente.objetenercarrito();
            lbl_iva.Text = objtpuente.obtneriva().ToString("F2") + " %";
            lbl_precio_total.Text = "$ " + objtpuente.obtenerpreciototal().ToString("F2");
        }

        private void lbl_iva_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
