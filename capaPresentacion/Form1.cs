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
using CapaCom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static capaPresentacion.FRMREGISTRO;

using capaEntidades;
using capaLogica;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public static int ClienteIdActual { get; private set; }
        clasePuente objP = new clasePuente();

        List<Clientes> listaclientes = new List<Clientes>();

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
                string usuarioIngresado = txtusuario.Text.Trim();
                string contraseniaIngresada = txtcontrasenia.Text.Trim();
                bool band = false;


                if ((usuarioIngresado == usuario1 || usuarioIngresado == usuario2 ||
                     usuarioIngresado == usuario3 || usuarioIngresado == usuario4 ||
                     usuarioIngresado == usuario5 || usuarioIngresado == usuario6 ||
                     usuarioIngresado == usuario7 || usuarioIngresado == usuario8 ||
                     usuarioIngresado == usuario9) && contraseniaIngresada == contra)
                {
                    using (FRMMENUADMINISTRADOR objetopin = new FRMMENUADMINISTRADOR())
                    {
                        objetopin.RecibirInformacion(usuarioIngresado);
                        this.Hide();
                        objetopin.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    listaclientes = objP.getClientes();
                    if (listaclientes != null)
                    {
                        foreach (Clientes c in listaclientes)
                        {
                            if (txtusuario.Text == c.Usuario && txtcontrasenia.Text == c.Contraseña)
                            {
                                band = true;
                                ClienteIdActual = c.id_cliente;
                                DatosComun.ClienteId = ClienteIdActual;
                                using (FRMMENUCLIENTE objMenuCliente = new FRMMENUCLIENTE())
                                {
                                    this.Hide();
                                    objMenuCliente.ShowDialog();
                                    this.Show();
                                }
                                
                                break;

                            }
                        }
                    }

                    if (!band)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
                }

                txtusuario.Clear();
                txtcontrasenia.Clear();
                txtusuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
