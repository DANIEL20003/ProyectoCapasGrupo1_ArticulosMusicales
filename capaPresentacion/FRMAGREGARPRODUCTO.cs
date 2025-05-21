using capaEntidades;
using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace capaPresentacion
{
    public partial class FRMAGREGARPRODUCTO : Form
    {
        clasePuente objP = new clasePuente();
        Instrumento objI = new Instrumento();

        string codigo, nombre, marca, modelo, categoria, proveedor, color, material, dimension;
        decimal precio;
        int añoFabricacion, cantidad;
        byte[] foto;

        private void txbAñoFabricacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbAñoFabricacion.Text))
                    {
                        MessageBox.Show("El año de fabricación no puede estar vacío",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbAñoFabricacion.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        añoFabricacion = int.Parse(txbAñoFabricacion.Text);

                        int añoActual = DateTime.Now.Year;

                        //si no esta en el rango correcto
                        if (añoFabricacion < 1900 || añoFabricacion > añoActual)
                        {
                            MessageBox.Show("El año debe estar en el rango de 1900 - " + añoActual, "Año ingresado inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txbAñoFabricacion.Clear();
                            txbAñoFabricacion.Focus();
                        }
                        else
                        {
                            txbCantidad.Focus();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Solo se aceptan valores numéricos enteros en el año de fabricación", "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbAñoFabricacion.Clear();
                    txbAñoFabricacion.Focus();
                }
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
                                cmbCategoria.Focus();
                                //cmbCategoria.DroppedDown = true;
                            }
                        }
                        else if (cantidad > 0)
                        {
                            cmbCategoria.Focus();
                            //cmbCategoria.DroppedDown = true;
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

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cmbCategoria.Text))
                {
                    MessageBox.Show("Debe seleccionar una categoría",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCategoria.Focus(); // Devuelve el foco 
                    cmbCategoria.DroppedDown = true;
                }
                else
                {
                    categoria = cmbCategoria.Text;
                    txbProveedor.Focus();
                    
                }
            }
        }

        /*private void cmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(cmbProveedor.Text))
                    {
                        MessageBox.Show("El proveedor no puede estar vacío",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbProveedor.Focus(); // Devuelve el foco 
                        cmbProveedor.DroppedDown = true;
                    }
                    else
                    {
                        
                        proveedor = cmbProveedor.Text;
                        cmbColor.Focus();
                        cmbColor.DroppedDown = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el proveedor:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbProveedor.Focus();
                }
                
            }
        }*/

        private void cmbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cmbColor.Text))
                {
                    MessageBox.Show("Debe seleccionar un color",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbColor.Focus(); // Devuelve el foco 
                    //cmbColor.DroppedDown = true;
                }
                else
                {
                    color = cmbColor.Text;
                    cmbMaterial.Focus();
                    //cmbMaterial.DroppedDown = true;
                }
            }
        }

        private void cmbMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cmbMaterial.Text))
                {
                    MessageBox.Show("Debe seleccionar un material",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbMaterial.Focus(); // Devuelve el foco 
                    cmbMaterial.DroppedDown = true;
                }
                else
                {
                    material = cmbMaterial.Text;
                    txbDimension.Focus();
                    
                }
            }
        }

        private void txbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
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
                        //si no esta vacío continúa normalmente
                        proveedor = txbProveedor.Text;
                        cmbColor.Focus();
                        //cmbColor.DroppedDown = true;
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
        }

        private void txbDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbDimension.Text))
                    {
                        MessageBox.Show("La dimensión no puede estar vacía",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbDimension.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        dimension = txbDimension.Text;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la dimensión:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDimension.Clear();
                    txbDimension.Focus();
                }
            }
        }



        /*private void cmbDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cmbDimension.Text))
                {
                    MessageBox.Show("Debe seleccionar una dimensión",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbDimension.Focus(); // Devuelve el foco 
                    cmbDimension.DroppedDown = true;
                }
                else
                {
                    dimension = cmbDimension.Text;
                    //el mismo usuario debe dar clic al boton agregar foto
                }
            }
        }*/

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
                        precio = decimal.Parse(txbPrecio.Text);

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
                                txbAñoFabricacion.Focus();
                            }
                        }
                        else if (precio > 0)
                        {
                            txbAñoFabricacion.Focus();
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

        private void txbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbModelo.Text))
                    {
                        MessageBox.Show("El modelo no puede estar vacío",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbModelo.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        modelo = txbModelo.Text;
                        txbPrecio.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el modelo:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbModelo.Clear();
                    txbModelo.Focus();
                }
            }
        }


        private void txbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbMarca.Text))
                    {
                        MessageBox.Show("La marca no puede estar vacía",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbMarca.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        marca = txbMarca.Text;
                        txbModelo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la marca:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMarca.Clear();
                    txbMarca.Focus();
                }
            }
        }

        public FRMAGREGARPRODUCTO()
        {
            InitializeComponent();
        }

        private void FRMAGREGARPRODUCTO_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //si esque el usuario se salto de llenar 
            //voy hacer que todos los campos hagan keypress para que haya control

            // Arreglo con todos tus controles en el orden que quieras validar
            Control[] controles = new Control[]
            {
                txbCodigo,
                txbNombre,
                txbMarca,
                txbModelo,
                txbPrecio,
                txbAñoFabricacion,
                txbCantidad,
                cmbCategoria,
                txbProveedor,
                cmbColor,
                cmbMaterial,
                txbDimension,
                
            };

            //simula todos los KeyPress
            foreach (Control c in controles)
            {
                c.Focus();                    // pongo el foco
                SendKeys.Send("{ENTER}");     // simulo que presionan Enter
                Application.DoEvents();       // dejo que el KeyPress se procese
            }

            //luego de las validaciones reviso si subió una imagen
            if (ptbImagenInstrumento.Image == null)
            {
                MessageBox.Show("Se necesita subir una imagen para guardar el producto musical", "Imagen inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ADVERTENCIA DE CONFIRMACION
            DialogResult resultado = MessageBox.Show(
                "Los campos que se podrán editar posteriormente son: Precio, Cantidad y Proveedor, los demás campos serán permanentes \n¿Desea guardar los cambios?",
                "Confirmación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (resultado == DialogResult.OK)
            {
                switch (categoria)
                {
                    case "Cuerda":
                        categoria = "1";
                        break;

                    case "Viento":
                        categoria = "2";
                        break;

                    case "Percusión":
                        categoria = "3";
                        break;

                    case "Teclado":
                        categoria = "4";
                        break;

                    case "Electrónico":
                        categoria = "5";
                        break;
                }

                try
                {
                    objI.codInstru = codigo;
                    objI.nombre = nombre;
                    objI.marca = marca;
                    objI.modelo = modelo;
                    objI.precio = precio;
                    objI.anioFabrica = añoFabricacion;

                    objI.idIva = 1;

                    objI.idCatego = Convert.ToInt32(categoria);
                    objI.proveedor = proveedor;
                    objI.color = color;
                    objI.material = material;
                    objI.dimension = dimension;
                    objI.cantidad = cantidad;

                    // Convertir la imagen del PictureBox a un arreglo de bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ptbImagenInstrumento.Image.Save(ms, ptbImagenInstrumento.Image.RawFormat);
                        foto = ms.ToArray();
                    }

                    objI.foto = foto;

                    //Se envia el objI para que sea ingresado en la BD
                    objP.IngresarInstrumento(objI);

                    

                    MessageBox.Show("Se agregó el producto correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n" + ex, "Se presentó un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (resultado == DialogResult.Cancel)
            {
                // Acción si el usuario presiona Cancelar
                MessageBox.Show("No se ingresó el producto actual", "Se canceló la operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "imagen.jpg";

            openFileDialog1.Filter = "Imágenes JPG|*.jpg|Imágenes PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ptbImagenInstrumento.Image = Image.FromFile(openFileDialog1.FileName);
                    btnAgregarFoto.Text = "Cambiar foto";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen:\n" + ex.Message, "Ha ocurrido un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna imagen", "Se canceló la operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbCodigo.Text))
                    {
                        MessageBox.Show("El código no puede estar vacío", 
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbCodigo.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        codigo = txbCodigo.Text;
                        txbNombre.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el código:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbCodigo.Clear();
                    txbCodigo.Focus();
                }
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    //controla que el textbox no quede vacío
                    if (string.IsNullOrWhiteSpace(txbNombre.Text))
                    {
                        MessageBox.Show("El nombre no puede estar vacío",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbNombre.Focus(); // Devuelve el foco al TextBox
                    }
                    else
                    {
                        //si no esta vacío continúa normalmente
                        nombre = txbNombre.Text;
                        txbMarca.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en el nombre:\n" + ex.Message, "Se presentó un error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNombre.Clear();
                    txbNombre.Focus();
                }
            }
        }
    }
}
