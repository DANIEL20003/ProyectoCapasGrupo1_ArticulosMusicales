using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FRMMENUADMINISTRADOR : Form
    {
        string bienvenida = "Bienvenido";
        string espacio = "  ";
        public FRMMENUADMINISTRADOR()
        {
            InitializeComponent();
        }

        public void RecibirInformacion(string informacion)
        {
            string nombre = informacion;
            lblsaludo.Text = bienvenida + espacio + nombre;
        }

        private void FRMMENUADMINISTRADOR_Load(object sender, EventArgs e)
        {

        }
    }
}
