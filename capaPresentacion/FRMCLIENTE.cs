using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using capaEntidades;
using capaLogica;
using capaPresentacion.Properties;


namespace capaPresentacion
{
    public partial class FRMCLIENTE : Form
    {
        Instrumento objInstru = new Instrumento();
        Carrito objCar = new Carrito();

        clasePuente objP = new clasePuente();

        public FRMCLIENTE()
        {
            InitializeComponent();
            cargar_categoria();
        }

        public void cargar_categoria()
        {
            List<string> listaCategorias = objP.listarCategoria();
            foreach (string item in listaCategorias)
            {
                cmb_categoria.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMCLIENTE_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_categoria.SelectedItem != null)
            {
                string categoria = cmb_categoria.SelectedItem.ToString();
                List<string> listaInstrumentos = objP.listarInstruCatego(categoria);
                foreach (string item in listaInstrumentos)
                {
                    cmb_instrumento.Items.Add(item);
                }

                switch (categoria)
                {
                    case "Cuerda":
                        pcb_categoria.Image = Resources.Instru_Cuerda;
                        break;
                    case "Viento":
                        pcb_categoria.Image = Resources.Instru_Viento;
                        break;
                    case "Percusión":
                        pcb_categoria.Image = Resources.Instru_Percus;
                        break;
                    case "Teclado":
                        pcb_categoria.Image = Resources.Instru_Teclado;
                        break;
                    case "Electrónico":
                        pcb_categoria.Image = Resources.Instru_Electro;
                        break;
                }

                cmb_instrumento.Enabled = true;
            }
            else
            {
                cmb_instrumento.Items.Clear();
                cmb_instrumento.Enabled = false;
                cmb_codigos.Items.Clear();
                cmb_categoria.Enabled = false;
            }
        }

        private void cmb_instrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_instrumento.SelectedItem != null)
            {
                string instru = cmb_instrumento.SelectedItem.ToString();
                List<string> listaCodigos =  objP.listarCodInstrumento(instru);
                foreach (string item in listaCodigos)
                {
                    cmb_codigos.Items.Add(item);
                }
                cmb_codigos.Enabled = true;
            }
            else
            {
                cmb_codigos.Items.Clear();
                cmb_categoria.Enabled = false;
            }
        }

        private void cmb_codigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_codigos.SelectedItem != null)
            {
                string idInstru = cmb_codigos.SelectedItem.ToString();
                objInstru = objP.infoInstrumento(idInstru);

                lbl_stock.Text = objInstru.cantidad.ToString();
                lbl_precio_unidad.Text = "$ " + objInstru.precio.ToString("F2");
                lbl_marca.Text = objInstru.marca;
                lbl_modelo.Text = objInstru.modelo;
                lbl_aniofabrica.Text = objInstru.anioFabrica.ToString();

            }
            else
            {
                
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir de la ventana actual? Los instrumentos seleccionados se perderán.",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Salida cancelada.", "Información", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea cancelar la selección de instrumentos?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (respuesta == DialogResult.Yes)
            {
                
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("La cancelación no se ha llevado a cabo.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
