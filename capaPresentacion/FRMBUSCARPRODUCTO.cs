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
    public partial class FRMBUSCARPRODUCTO : Form
    {
        clasePuente operacion=new clasePuente();
        string codigoProducto;

        public FRMBUSCARPRODUCTO()
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
                        MessageBox.Show("El código ingresado no existe" +
                                        " en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        TB_codigoProducto.Clear();
                        return;
                    }

                    btnBuscar.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    MessageBox.Show("El código ingresado no existe" +
                                    " en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TB_codigoProducto.Clear();
                    return;
                }
                Instrumento producto = operacion.infoInstrumento(codigoProducto);

                lblCodigo.Text = producto.codInstru.ToString();
                lblNombre.Text = producto.nombre.ToString();
                lblMarca.Text = producto.marca.ToString();
                lblModelo.Text = producto.modelo.ToString();
                lblPrecio.Text = producto.precio.ToString();
                lblaFab.Text = producto.anioFabrica.ToString();
                lblIdIva.Text = producto.idIva.ToString();
                lblCantidad.Text = producto.cantidad.ToString();
                lblCategoria.Text = producto.idCatego.ToString();
                lblProveedor.Text = producto.idProvee.ToString();
                lblColor.Text = producto.color.ToString();
                lblMaterial.Text = producto.material.ToString();
                lblDimension.Text = producto.dimension.ToString();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TB_codigoProducto.Clear();
            }
           
        }
    }
}
