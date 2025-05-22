using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FRMMENUCLIENTE : Form
    {
        public FRMMENUCLIENTE()
        {
            InitializeComponent();
        }

        private void pcb_catalogo_Click(object sender, EventArgs e)
        {
            FRMCLIENTE objCli = new FRMCLIENTE();
            objCli.ShowDialog();
        }

        private void pcb_carrito_Click(object sender, EventArgs e)
        {
            FRMCARRITO objtcarrito = new FRMCARRITO();
           objtcarrito.ShowDialog();
        }

        private void lbl_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_ayuda_Click(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio del proyecto (fuera de \bin\Debug)
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaCarpeta = Path.Combine(rutaProyecto, "AYUDAS");
            string rutaAyuda = Path.Combine(rutaCarpeta, "Manual de Usuario.pdf");

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

        private void lblAcercaDe_Click(object sender, EventArgs e)
        {
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string rutaResources = Path.Combine(rutaProyecto, "ACERCA DE");
            string rutaArchivo = Path.Combine(rutaResources, "Acerca de. Grupo 1.htm");

            System.Diagnostics.Process.Start(rutaArchivo);
        }
    }
}
