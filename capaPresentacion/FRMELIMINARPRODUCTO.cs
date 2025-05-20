using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidades;
using capaLogica;


namespace capaPresentacion
{
    public partial class FRMELIMINARPRODUCTO : Form
    {
        clasePuente operacion=new clasePuente();

        public FRMELIMINARPRODUCTO()
        {
            InitializeComponent();
        }

        private void TB_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
