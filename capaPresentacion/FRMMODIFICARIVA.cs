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
    public partial class FRMMODIFICARIVA : Form
    {
        public FRMMODIFICARIVA()
        {
            InitializeComponent();
        }

        private void TB_codigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        public double getiva()
        {
            double ivac;
            ivac = double.Parse(TB_codigoProducto.Text);
            return ivac;
        }
    }
}
