using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static capaPresentacion.FRMREGISTRO;
//esta es una pequeña prueba
namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public int idCliente;

        private SoundPlayer soundPlayer;
        String usuario4 = "Erik Yumi";
        String usuario1 = "Daniel Quiguiri";
        String usuario2 = "Danny Allauca";
        String usuario3 = "Angel Gadvay";
        String usuario5 = "Kevin Parra";
        String usuario6 = "Andrea Vinueza";
        String usuario7 = "Alexander Villalva";
        String usuario8 = "Mateo López";
        String usuario9 = "Lorena Aguirre";

        string contra = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                /*if (string.IsNullOrWhiteSpace(txtusuario.Text))
                {
                    MessageBox.Show("El campo de usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusuario.Focus();
                    e.Handled = true;
                    return;
                }


                string[] usuariosPermitidos = {
                    usuario1, usuario2, usuario3, usuario4, usuario5,
                    usuario6, usuario7, usuario8, usuario9
                };

                if (!usuariosPermitidos.Contains(txtusuario.Text))
                {
                    MessageBox.Show("Usuario no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtusuario.Clear();
                    txtusuario.Focus();
                    e.Handled = true;
                    return;
                }

                */
                txtcontrasenia.Focus();
            }
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            FRMREGISTRO objRegistro = new FRMREGISTRO();
            objRegistro.ShowDialog();  
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioIngresado = txtusuario.Text.Trim(); //Revisar
                string contraseniaIngresada = txtcontrasenia.Text.Trim();//Revisar

                bool usuarioTemporalValido = UsuarioManager.listaUsuarios.Any(u =>//Revisar
                u.UsuarioNombre == usuarioIngresado && u.Contraseña == contraseniaIngresada);//Revisar

                if (txtusuario.Text == usuario1 || txtusuario.Text == usuario2 || txtusuario.Text == usuario3 || txtusuario.Text == usuario4 || txtusuario.Text == usuario5 || txtusuario.Text == usuario6 || txtusuario.Text == usuario7 || txtusuario.Text == usuario8 || txtusuario.Text == usuario9 || txtusuario.Text == contra)
                {
                    FRMMENUADMINISTRADOR objetopin = new FRMMENUADMINISTRADOR();

                    string informacion = txtusuario.Text; // Obtener el texto del TextBox

                    // Pasar la información al segundo formulario
                    objetopin.RecibirInformacion(informacion);
                    this.Hide(); // Oculta el login mientras se abre el nuevo form
                    objetopin.ShowDialog();
                    this.Show(); // Muestra el login otra vez cuando se cierra el otro form
                }
                else if (usuarioTemporalValido || txtusuario.Text == "cliente")
                {
                    FRMMENUCLIENTE objMenuCliente = new FRMMENUCLIENTE();
                    string informacion = txtusuario.Text; // Obtener el texto del TextBox
                    this.Hide();
                    objMenuCliente.ShowDialog();
                    this.Show();
                } else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
                txtusuario.Clear();
                txtcontrasenia.Clear();
                txtusuario.Focus();

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error, intente de nuevo");
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtcontrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==(char)Keys.Enter)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
