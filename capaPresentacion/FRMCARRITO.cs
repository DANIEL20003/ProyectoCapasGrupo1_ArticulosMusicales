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




namespace capaPresentacion
{
    public partial class FRMCARRITO : Form
    {
        clasePuente objtpuente = new clasePuente();
        public FRMCARRITO()
        {
            InitializeComponent();
            DGVcarrito.DataSource = objtpuente.objetenercarrito();
        }

        private void FRMCARRITO_Load(object sender, EventArgs e)
        {

        }
    }
}
