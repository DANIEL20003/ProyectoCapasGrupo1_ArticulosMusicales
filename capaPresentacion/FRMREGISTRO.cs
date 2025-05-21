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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace capaPresentacion
{
    public partial class FRMREGISTRO : Form
    {
        string cedula, nombre, apellido, direccion, email = "",telefono;
        

        public static class UsuarioManager
        {
            // Lista de usuarios en memoria
            public static List<Usuario> listaUsuarios = new List<Usuario>();
        }
        public FRMREGISTRO()
        {
            InitializeComponent();
        }

        clasePuente objP = new clasePuente();
        Clientes objCl = new Clientes();

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string cedulaTexto = txtCedula.Text.Trim();

                // Verificar si la cédula tiene 10 dígitos
                if (cedulaTexto.Length != 10 || !cedulaTexto.All(char.IsDigit))
                {
                    MessageBox.Show("La cédula debe tener exactamente 10 dígitos numéricos.");
                    e.Handled = true; 
                    return; 
                }

                Cedula cedulaObj = new Cedula(cedulaTexto);

                if (!cedulaObj.ComprobarCedula())
                {
                    MessageBox.Show("Cédula inválida.");
                    e.Handled = true; 
                    return; 
                }

                cedula = cedulaTexto;  
                txtNombre.Focus(); 
                e.Handled = true;  
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtApellido.Focus();
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                apellido = txtApellido.Text.Trim();
            }
        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                email = txtEmail.Text.Trim();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                direccion = txtDireccion.Text.Trim();
            }
        }

        private void rdbSoltero_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbCasado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void TXB_registroU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXB_crearC.Focus();
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                objCl.Nombre = txtNombre.Text;
                objCl.Apellido = txtApellido.Text;
                objCl.Cedula = txtCedula.Text;
                objCl.Telefono = txttelefono.Text;
                objCl.Correo_electronico = txtEmail.Text;
                objCl.Direccion = txtDireccion.Text;
                objCl.id_tipo_cliente = int.Parse(cbxtipo.Text);
                objCl.Contraseña = TXB_crearC.Text;
                objCl.Usuario = txtusuario.Text;

                objP.Ingresar(objCl);

                MessageBox.Show("¡Cliente guardado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtApellido.Focus();
        }

        private void txtApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txttelefono.Focus();
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtEmail.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Ingrese números de 10 dígitos");
                txttelefono.Clear();
            }
                
        }

        private void txtEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtDireccion.Focus();
        }

        private void txtDireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtusuario.Focus();
        }

        private void TXB_crearC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TXB_crearC.Focus();
        }

        private void TXB_crearC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Poner que se ejecute directamente
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private int calcularEdad(DateTime fechaNac)
        {
            DateTime fechaActual = DateTime.Today;
            TimeSpan diferencia = fechaActual - fechaNac;
            return (int)(diferencia.TotalDays / 365.25);

        }

        private void FRMREGISTRO_Load(object sender, EventArgs e)
        {

        }
    }
}
