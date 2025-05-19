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
        Categoria objCate = new Categoria();
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
            /*List<Categoria> listaCategorias = objP.listCategoria();
            foreach (Categoria item in listaCategorias)
            {
                cmb_categoria.Items.Add(item);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMCLIENTE_Load(object sender, EventArgs e)
        {
            
        }
    }
}
