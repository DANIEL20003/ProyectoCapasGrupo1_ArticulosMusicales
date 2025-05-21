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
                        MessageBox.Show($"No se ha encontrado ningún producto con el código: '{codigoProducto}'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            try
            {
                codigoProducto = TB_codigoProducto.Text;

                if (operacion.infoInstrumento(codigoProducto) == null)
                {
                    MessageBox.Show($"No se ha encontrado ningún producto con el código: '{codigoProducto}'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TB_codigoProducto.Clear();
                    return;
                }
                Instrumento instrumentoA = operacion.infoInstrumento(codigoProducto);

                lblCodigo.Text = instrumentoA.codInstru.ToString();
                lblNombre.Text = instrumentoA.nombre.ToString();
                lblMarca.Text = instrumentoA.marca.ToString();
                lblModelo.Text = instrumentoA.modelo.ToString();
                lblPrecio.Text = instrumentoA.precio.ToString();
                lblaFab.Text = instrumentoA.anioFabrica.ToString();
                lblIdIva.Text = instrumentoA.idIva.ToString();
                lblCantidad.Text = instrumentoA.cantidad.ToString();
                lblCategoria.Text = instrumentoA.idCatego.ToString();
                lblProveedor.Text = instrumentoA.idProvee.ToString();
                lblColor.Text = instrumentoA.color.ToString();
                lblMaterial.Text = instrumentoA.material.ToString();
                lblDimension.Text = instrumentoA.dimension.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor, Ingrese un código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TB_codigoProducto.Clear();
            }
            
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
