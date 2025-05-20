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
        string codigoProducto;
        Instrumento instrumento;
        public FRMELIMINARPRODUCTO()
        {
            InitializeComponent();
        }

        private void TB_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    codigoProducto=TB_codigoProducto.Text;
                    if (operacion.infoInstrumento(codigoProducto) == null)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto" +
                            $" con el código: {codigoProducto}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TB_codigoProducto.Clear();
                        return;
                    }
                    btnBuscar.PerformClick();

                }
            }
            catch
            {
                MessageBox.Show("Por favor, Ingrese un código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TB_codigoProducto.Clear();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            instrumento=operacion.infoInstrumento(codigoProducto);

            lblCodigo.Text = instrumento.codInstru.ToString();
            lblNombre.Text = instrumento.nombre.ToString();
            lblMarca.Text = instrumento.marca.ToString();
            lblModelo.Text = instrumento.modelo.ToString();
            lblPrecio.Text = instrumento.precio.ToString();
            lblaFab.Text = instrumento.anioFabrica.ToString();
            lblIdIva.Text = instrumento.idIva.ToString();
            lblCantidad.Text = instrumento.cantidad.ToString();
            lblCategoria.Text = instrumento.idCatego.ToString();
            lblProveedor.Text = instrumento.idProvee.ToString();
            lblColor.Text = instrumento.color.ToString();
            lblMaterial.Text = instrumento.material.ToString();
            lblDimension.Text = instrumento.dimension.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            operacion.eliminarProd(codigoProducto);
            MessageBox.Show("El instrumento se ha eliminado con exito" +
                " de la base de datos","Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }

        public void limpiar()
        {
            TB_codigoProducto.Clear();
        }
    }
}
