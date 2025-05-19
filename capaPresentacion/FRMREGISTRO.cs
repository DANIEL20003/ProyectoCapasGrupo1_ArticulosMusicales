using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace capaPresentacion
{
    public partial class FRMREGISTRO : Form
    {
        string cedula, nombre, apellido, direccion, ciudad, email = "";
        char estadoCivil = 'S', genero = 'M';
        int edadEnAnios;
        DateTime fechaNac;

        public static class UsuarioManager
        {
            // Lista de usuarios en memoria
            public static List<Usuario> listaUsuarios = new List<Usuario>();
        }
        public FRMREGISTRO()
        {
            InitializeComponent();
        }

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
                dateTimePicker1.Focus();
            }
        }

        private void cbxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciudad = cbxProvincia.SelectedItem.ToString();
            txtEmail.Focus();
        }

        private void cbxProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
                e.Handled = true;
            }
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
            if (rdbSoltero.Checked)
            {
                estadoCivil = 'S';
            }
        }

        private void rdbCasado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCasado.Checked)
            {
                estadoCivil = 'C';
            }
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked) genero = 'M';
        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemenino.Checked) genero = 'F';
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

        private void TXB_crearC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Poner que se ejecute directamente
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioNombre = TXB_registroU.Text.Trim();
                string contraseña = TXB_crearC.Text.Trim();

                if (string.IsNullOrEmpty(usuarioNombre) || string.IsNullOrEmpty(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                fechaNac = dateTimePicker1.Value;
                edadEnAnios = calcularEdad(fechaNac);

                if (edadEnAnios < 18)
                {
                    MessageBox.Show("Debes tener al menos 18 años para registrarte.");
                    return;
                }

                // Verificar si el usuario ya está registrado en la lista temporal
                foreach (var usuario in UsuarioManager.listaUsuarios)
                {
                    if (usuario.UsuarioNombre == usuarioNombre)
                    {
                        MessageBox.Show("El usuario ya está registrado.");
                        return;
                    }
                }

                // Crear el nuevo usuario y agregarlo a la lista temporal
                Usuario nuevoUsuario = new Usuario(usuarioNombre, contraseña);
                UsuarioManager.listaUsuarios.Add(nuevoUsuario);

                MessageBox.Show("Usuario creado exitosamente.");

                // Limpiar los campos del formulario
                TXB_registroU.Clear();
                TXB_crearC.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtEmail.Clear();
                txtDireccion.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
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
