using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void linkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obtener la ruta del directorio del proyecto (fuera de \bin\Debug)
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaCarpeta = Path.Combine(rutaProyecto, "AYUDAS");
            string rutaAyuda = Path.Combine(rutaCarpeta, "Manual de Administrador.pdf");

            // Si la carpeta AYUDAS no existe, se la crea
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            else
            {
                System.Diagnostics.Process.Start(rutaAyuda);
            }
        }

        private void lbl_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
