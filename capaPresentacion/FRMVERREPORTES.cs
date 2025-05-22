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
    public partial class FRMVERREPORTES : Form
    {
        public FRMVERREPORTES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMREPORTE1  objreporte1 = new FRMREPORTE1();
            objreporte1.ShowDialog();
        }

        private void FRMVERREPORTES_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Reporte2_Click(object sender, EventArgs e)
        {
            FRMREPORTE2 objreporte2 = new FRMREPORTE2();
            objreporte2.ShowDialog();
        }
    }
}
