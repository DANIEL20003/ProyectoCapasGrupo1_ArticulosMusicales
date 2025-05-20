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
    public partial class FRMMODIFICARIVA : Form
    {
        clasePuente operacion=new clasePuente();
        int iva;

        public FRMMODIFICARIVA()
        {
            InitializeComponent();
        }

        private void TB_codigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        public double getiva()
        {
            double ivac;
            ivac = double.Parse(TB_codigoProducto.Text);
            return ivac;
        }

        private void TB_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    iva=int.Parse(TB_codigoProducto.Text);
                    if(iva<0 || iva > 100)
                    {
                        MessageBox.Show("El valor ingresado para el IVA " +
                                        "no es un valor correcto, Ingrese de nuevo",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TB_codigoProducto.Clear();
                        return;
                    }

                    btnActualizarIva.PerformClick();
                }
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor para " +
                                        "el IVA, Ingrese de nuevo",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_codigoProducto.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarIva_Click(object sender, EventArgs e)
        {
            operacion.actualizarIv(iva);
        }
    }
}
