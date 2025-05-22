using capaEntidades;
using capaLogica;
using capaPresentacion.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capaPresentacion
{
    public partial class FRMMODIFICARPRODUCTO : Form
    {
        decimal precio;
        string codigoInstrumento, proveedor;
        int cantidad;

        clasePuente objP = new clasePuente();
        Instrumento objI = new Instrumento();
        public FRMMODIFICARPRODUCTO()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // controla que el textbox no quede vacío
            if (string.IsNullOrWhiteSpace(txbCodigo.Text))
            {
                MessageBox.Show("Por favor, ingrese un código de producto.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbCodigo.Focus();
                return;
            }
            else
            {
                codigoInstrumento = txbCodigo.Text;
                objI = objP.infoInstrumento(codigoInstrumento);

                if (objI == null)
                {
                    MessageBox.Show($"No se encontró ningún producto con el código: '{codigoInstrumento}'", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCodigo.Clear();
                    txbCodigo.Focus();
                    return;
                }
                else
                {
                    gpbProducto.Visible = true;
                    claseIva iva = objP.showIvaActual();
                    string cat = objP.getC(objI.idCatego);

                    lblCodigo.Text = objI.codInstru.ToString();
                    lblNombre.Text = objI.nombre.ToString();
                    lblMarca.Text = objI.marca.ToString();
                    lblModelo.Text = objI.modelo.ToString();
                    txbPrecio.Text = objI.precio.ToString();
                    lblaFab.Text = objI.anioFabrica.ToString();
                    lblIdIva.Text = iva.valor_iva.ToString() + "%";
                    txbCantidad.Text = objI.cantidad.ToString();
                    lblCategoria.Text = cat;
                    txbProveedor.Text = objI.proveedor.ToString();
                    lblColor.Text = objI.color.ToString();
                    lblMaterial.Text = objI.material.ToString();
                    lblDimension.Text = objI.dimension.ToString();

                    if (objI.foto != null)
                    {
                        //Para comvertir de byte[] a Image
                        MemoryStream ms = new MemoryStream(objI.foto);
                        Image imgInstru = Image.FromStream(ms);

                        // Mostrar en un pcb_instrumento
                        ptbImagenInstrumento.Image = imgInstru;
                    }
                    else
                    {
                        ptbImagenInstrumento.Image = Resources.NoImagen;
                    }

                }
            }
        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbCantidad.Text))
                    {
                        MessageBox.Show("La cantidad no puede estar vacía",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbCantidad.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        cantidad = int.Parse(txbCantidad.Text);

                        if (cantidad == 0)
                        {
                            DialogResult resultado = MessageBox.Show("Se ingresará una cantidad de 0. \n¿Está seguro?",
                                "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (resultado == DialogResult.Cancel)
                            {
                                txbCantidad.Clear();
                                txbCantidad.Focus();
                            }
                            else
                            {
                                txbProveedor.Focus();
                            }
                        }
                        else if (cantidad > 0)
                        {
                            txbProveedor.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan valores negativos en la cantidad", "Se presentó un error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txbCantidad.Clear();
                            txbCantidad.Focus();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Solo se aceptan valores numéricos enteros en la cantidad", "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbCantidad.Clear();
                    txbCantidad.Focus();

                }
            }
        }

        private void txbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnModificar.PerformClick();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Validación de ingreso en los campos haciendoles Keypress
            txbPrecio.Focus();                    // pongo el foco
            SendKeys.Send("{ENTER}");     // simulo que presionan Enter
            Application.DoEvents();       // dejo que el KeyPress se procese

            txbCantidad.Focus();                    // pongo el foco
            SendKeys.Send("{ENTER}");     // simulo que presionan Enter
            Application.DoEvents();       // dejo que el KeyPress se procese


            //Validación de ingreso del proveedor
            try
            {
                //controla que el textbox no quede vacío
                if (string.IsNullOrWhiteSpace(txbProveedor.Text))
                {
                    MessageBox.Show("El proveedor no puede estar vacío",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbProveedor.Focus(); // Devuelve el foco al TextBox
                }
                else
                {
                    proveedor = txbProveedor.Text;

                    //modificación en la base de datos
                    try
                    {

                        objP.modificarInstrumento(codigoInstrumento, precio, cantidad, proveedor);
                        MessageBox.Show("Se modificó el producto correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error \n" + ex, "Se presentó un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el proveedor:\n" + ex.Message, "Se presentó un error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProveedor.Clear();
                txbProveedor.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se canceló la operación de modificación", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FRMMODIFICARPRODUCTO_Load(object sender, EventArgs e)
        {
            gpbProducto.Visible = false;
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbPrecio.Text))
                    {
                        MessageBox.Show("El precio no puede estar vacío",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbPrecio.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        precio = Math.Round(decimal.Parse(txbPrecio.Text), 2);

                        //si ingresa un precio de 0 pide una confirmacion para aceptar ese precio
                        if (precio == 0)
                        {
                            DialogResult resultado = MessageBox.Show("Se ingresará un precio de $0.00. \n¿Está seguro?",
                                "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (resultado == DialogResult.Cancel)
                            {
                                txbPrecio.Clear();
                                txbPrecio.Focus();
                            }
                            else
                            {
                                txbPrecio.Text = precio.ToString();
                                txbCantidad.Focus();
                            }
                        }
                        else if (precio > 0)
                        {
                            txbPrecio.Text = precio.ToString();
                            txbCantidad.Focus();
                        }
                        else
                        {
                            MessageBox.Show("No se aceptan valores negativos en el precio", "Se presentó un error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txbPrecio.Clear();
                            txbPrecio.Focus();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Solo se aceptan valores numéricos en el precio", "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPrecio.Clear();
                    txbPrecio.Focus();
                }
            }
        }
    }
}
