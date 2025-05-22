using capaEntidades;
using capaLogica;
using capaPresentacion.Properties;
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
            /*try
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
            }*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                codigoProducto = TB_codigoProducto.Text;

                if (string.IsNullOrWhiteSpace(codigoProducto))
                {
                    MessageBox.Show("Por favor, ingrese un código de producto.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_codigoProducto.Clear();
                    TB_codigoProducto.Focus();
                    return;
                }

                if (operacion.infoInstrumento(codigoProducto) == null)
                {
                    MessageBox.Show($"No se encontró ningún producto con el código: '{codigoProducto}'", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TB_codigoProducto.Clear();
                    TB_codigoProducto.Clear();
                    return;
                }

                groupBox1.Visible = true;

                Instrumento producto = operacion.infoInstrumento(codigoProducto);

                claseIva iva = operacion.showIvaActual();
                string cat = operacion.getC(producto.idCatego);

                lblCodigo.Text = producto.codInstru.ToString();
                lblNombre.Text = producto.nombre.ToString();
                lblMarca.Text = producto.marca.ToString();
                lblModelo.Text = producto.modelo.ToString();
                lblPrecio.Text = producto.precio.ToString();
                lblaFab.Text = producto.anioFabrica.ToString();
                lblIdIva.Text = iva.valor_iva.ToString() + "%";
                lblCantidad.Text = producto.cantidad.ToString();
                lblCategoria.Text = cat;
                lblProveedor.Text = producto.proveedor.ToString();
                lblColor.Text = producto.color.ToString();
                lblMaterial.Text = producto.material.ToString();
                lblDimension.Text = producto.dimension.ToString();

                if (producto.foto != null)
                {
                    //Para comvertir de byte[] a Image
                    MemoryStream ms = new MemoryStream(producto.foto);
                    Image imgInstru = Image.FromStream(ms);

                    // Mostrar en un pcb_instrumento
                    ptbImagenInstrumento.Image = imgInstru;
                }
                else
                {
                    ptbImagenInstrumento.Image = Resources.NoImagen;
                }

            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TB_codigoProducto.Clear();
            }
           
        }

        private void FRMBUSCARPRODUCTO_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
    }
}
