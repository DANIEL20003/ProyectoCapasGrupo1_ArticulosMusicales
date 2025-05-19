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

            }
            else
            {
                cmb_categoria.Items.Clear();
                cmb_categoria.Enabled = false;
            }
        }
    }
}
