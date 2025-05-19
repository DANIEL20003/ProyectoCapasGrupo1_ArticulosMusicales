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
            //lblsaludo.Text = bienvenida + espacio + nombre;
        }

        private void FRMMENUADMINISTRADOR_Load(object sender, EventArgs e)
        {

        }

        private void lblsaludo_Click(object sender, EventArgs e)
        {

        }

        private void ptbAgregar_Click(object sender, EventArgs e)
        {
            FRMAGREGARPRODUCTO objAgregar = new FRMAGREGARPRODUCTO();
            objAgregar.ShowDialog();
        }

        private void ptbModificar_Click(object sender, EventArgs e)
        {
            FRMMODIFICARPRODUCTO objModificar = new FRMMODIFICARPRODUCTO();
            objModificar.ShowDialog();
        }

        private void ptbEliminar_Click(object sender, EventArgs e)
        {
            FRMELIMINARPRODUCTO objEliminar = new FRMELIMINARPRODUCTO();
            objEliminar.ShowDialog();
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            FRMBUSCARPRODUCTO objBuscar = new FRMBUSCARPRODUCTO();
            objBuscar.ShowDialog();
        }

        private void ptbModificarIVA_Click(object sender, EventArgs e)
        {
            FRMMODIFICARIVA objIVA = new FRMMODIFICARIVA();
            objIVA.ShowDialog();
        }

        private void ptbVerReportes_Click(object sender, EventArgs e)
        {
            FRMVERREPORTES objReportes = new FRMVERREPORTES();
            objReportes.ShowDialog();
        }
    }
}
