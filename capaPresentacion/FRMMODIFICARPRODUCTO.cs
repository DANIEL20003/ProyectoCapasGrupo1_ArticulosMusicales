using capaEntidades;
using capaLogica;
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
    public partial class FRMMODIFICARPRODUCTO : Form
    {
        clasePuente objP = new clasePuente();
        Instrumento objI = new Instrumento();
        public FRMMODIFICARPRODUCTO()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
