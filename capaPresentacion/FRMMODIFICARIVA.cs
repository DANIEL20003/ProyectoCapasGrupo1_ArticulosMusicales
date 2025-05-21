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
        decimal iva;

        public FRMMODIFICARIVA()
        {
            InitializeComponent();
            if (operacion.showIvaActual() == null)
            {
                lblIvaActual.Text = "Sin IVA";
            }
            else
            {
                claseIva sIA= operacion.showIvaActual();
                lblIvaActual.Text = sIA.valor_iva.ToString();
            }
        }

        private void TB_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    iva=decimal.Parse(TB_codigoProducto.Text);
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
            try
            {
                iva = decimal.Parse(TB_codigoProducto.Text);

                if (iva < 0 || iva > 100)
                {
                    MessageBox.Show("El valor ingresado para el IVA " +
                                    "no es un valor correcto, Ingrese de nuevo",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TB_codigoProducto.Clear();
                    return;
                }
                operacion.actualizarIv(iva);
                TB_codigoProducto.Clear();

                lblIvaActual.Text = iva.ToString();

                MessageBox.Show($"Se ha modificado correctamente el valor del iva a {iva}", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor para " +
                                        "el IVA, Ingrese de nuevo",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_codigoProducto.Clear();
            }
        }
    }
}
