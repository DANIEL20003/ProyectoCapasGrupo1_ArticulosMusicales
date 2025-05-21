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
            FRMREPORTE1 fRMREPORTE1 = new FRMREPORTE1();
            fRMREPORTE1.Show();
        }
    }
}
