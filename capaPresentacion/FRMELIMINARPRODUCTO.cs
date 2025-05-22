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
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            codigoProducto = TB_codigoProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoProducto))
            {
                MessageBox.Show("Por favor, ingrese un código de producto.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_codigoProducto.Clear();
                TB_codigoProducto.Focus();
                return;
            }

            Instrumento instrumentoA = operacion.infoInstrumento(codigoProducto);

            if (instrumentoA == null)
            {
                MessageBox.Show($"No se encontró ningún producto con el código: '{codigoProducto}'", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_codigoProducto.Clear();
                TB_codigoProducto.Focus();
                return;
            }

            claseIva iva = operacion.showIvaActual();
            string cat = operacion.getC(instrumentoA.idCatego);

            lblCodigo.Text = instrumentoA.codInstru;
            lblNombre.Text = instrumentoA.nombre;
            lblMarca.Text = instrumentoA.marca;
            lblModelo.Text = instrumentoA.modelo;
            lblPrecio.Text = instrumentoA.precio.ToString("F2");
            lblaFab.Text = instrumentoA.anioFabrica.ToString();
            lblIdIva.Text = iva != null ? iva.valor_iva.ToString() + "%" : "IVA no disponible";
            lblCantidad.Text = instrumentoA.cantidad.ToString();
            lblCategoria.Text = cat;
            lblProveedor.Text = instrumentoA.proveedor;
            lblColor.Text = instrumentoA.color;
            lblMaterial.Text = instrumentoA.material;
            lblDimension.Text = instrumentoA.dimension;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            codigoProducto = TB_codigoProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoProducto))
            {
                MessageBox.Show("Por favor, ingrese un código antes de eliminar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_codigoProducto.Focus();
                return;
            }

            Instrumento instrumentoA = operacion.infoInstrumento(codigoProducto);

            if (instrumentoA == null)
            {
                MessageBox.Show($"No se encontró ningún producto con el código: '{codigoProducto}'. No se puede eliminar.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TB_codigoProducto.Clear();
                TB_codigoProducto.Focus();
                return;
            }

            DialogResult confirmacion = MessageBox.Show($"¿Está seguro de que desea eliminar el producto '{instrumentoA.nombre}' (Código: {codigoProducto})?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                operacion.eliminarProd(codigoProducto);
                MessageBox.Show("El instrumento se ha eliminado con éxito de la base de datos.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            TB_codigoProducto.Clear();
            lblCodigo.Text = lblNombre.Text = lblMarca.Text = lblModelo.Text = lblPrecio.Text =
            lblaFab.Text = lblIdIva.Text = lblCantidad.Text = lblCategoria.Text =
            lblProveedor.Text = lblColor.Text = lblMaterial.Text = lblDimension.Text = "";
            TB_codigoProducto.Focus();
        }

    }
}
