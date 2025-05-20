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

        long maximo = 0, cantidad;
        decimal iva = 0, precioTotal = 0;

        List<Carrito> carritos = new List<Carrito>();

        Form1 obj = new Form1;

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
            iva = objP.getIva();
            lbl_iva.Text = iva.ToString("F2");
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_categoria.SelectedItem != null)
            {
                cmb_instrumento.Items.Clear();
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
                cmb_codigos.Items.Clear();
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

                maximo = objInstru.cantidad;
                lbl_stock.Text = maximo.ToString();
                
                lbl_precio_unidad.Text = "$ " + objInstru.precio.ToString("F2");
                lbl_marca.Text = objInstru.marca;
                lbl_modelo.Text = objInstru.modelo;
                lbl_aniofabrica.Text = objInstru.anioFabrica.ToString();

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

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea finalizar su selección? Despues de esto no se podran revertir los cambios.",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (respuesta == DialogResult.Yes)
            {
                objP.insertCarrito(carritos);
                MessageBox.Show(
                    "Sus instrumentos seleccionados se han guaradado exitosamente.",
                    "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("Finalización cancelada.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt64(txt_cantidad.Text);
            if (cantidad <= maximo)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro que desea guardar la cantidad de instrumentos?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );

                if (respuesta == DialogResult.Yes)
                {
                    carritos.Add(new Carrito
                    {
                        idCli = obj.idCliente,
                        codigoInstru = cmb_codigos.SelectedItem.ToString(),
                        cantidad = Convert.ToInt32(txt_cantidad.Text),
                        fecha = DateTime.Now
                    });
                    
                    lbl_precio_total.Text = ((precioTotal += objInstru.precio) * iva).ToString("F2");
                    
                    MessageBox.Show(
                        "La cantidad seleccionada ha sido guardada con éxito.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (respuesta == DialogResult.No)
                {
                    MessageBox.Show(
                        "No se ha guardado la cantidad seleccionada.", 
                        "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show(
                    $"La cantidad seleccionada no puede superar la cantidad existente de {maximo}",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_cantidad.Clear();
                txt_cantidad.Focus();
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
                carritos.Clear();
                maximo = 0;
                cantidad = 0;
                precioTotal = 0;
                lbl_precio_total.Text = "$ " + precioTotal.ToString("F2");
                cmb_categoria.SelectedIndex = -1;
                cmb_instrumento.Items.Clear();
                cmb_instrumento.Enabled = false;
                cmb_codigos.Items.Clear();
                cmb_codigos.Enabled = false;
                lbl_precio_unidad.Text = "";
                lbl_marca.Text = "";
                lbl_modelo.Text = "";
                lbl_aniofabrica.Text = "";

                MessageBox.Show(
                    "La selección de los instrumentos ha sido cancelada exitosamente.",
                    "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (respuesta == DialogResult.No)
            {
                MessageBox.Show("La cancelación no se ha llevado a cabo.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
