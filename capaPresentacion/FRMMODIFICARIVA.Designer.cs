namespace capaPresentacion
{
    partial class FRMMODIFICARIVA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizarIva = new System.Windows.Forms.Button();
            this.TB_codigoProducto = new System.Windows.Forms.TextBox();
            this.LBLT_codigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gold;
            this.btnCancelar.Location = new System.Drawing.Point(316, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 30);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizarIva
            // 
            this.btnActualizarIva.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizarIva.FlatAppearance.BorderSize = 0;
            this.btnActualizarIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarIva.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarIva.ForeColor = System.Drawing.Color.Gold;
            this.btnActualizarIva.Location = new System.Drawing.Point(172, 247);
            this.btnActualizarIva.Name = "btnActualizarIva";
            this.btnActualizarIva.Size = new System.Drawing.Size(113, 30);
            this.btnActualizarIva.TabIndex = 19;
            this.btnActualizarIva.Text = "Actualizar";
            this.btnActualizarIva.UseVisualStyleBackColor = false;
            this.btnActualizarIva.Click += new System.EventHandler(this.btnActualizarIva_Click);
            // 
            // TB_codigoProducto
            // 
            this.TB_codigoProducto.Location = new System.Drawing.Point(322, 174);
            this.TB_codigoProducto.Name = "TB_codigoProducto";
            this.TB_codigoProducto.Size = new System.Drawing.Size(192, 20);
            this.TB_codigoProducto.TabIndex = 16;
            this.TB_codigoProducto.TextChanged += new System.EventHandler(this.TB_codigoProducto_TextChanged);
            this.TB_codigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_codigoProducto_KeyPress);
            // 
            // LBLT_codigo
            // 
            this.LBLT_codigo.AutoSize = true;
            this.LBLT_codigo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLT_codigo.ForeColor = System.Drawing.Color.Black;
            this.LBLT_codigo.Location = new System.Drawing.Point(96, 169);
            this.LBLT_codigo.Name = "LBLT_codigo";
            this.LBLT_codigo.Size = new System.Drawing.Size(220, 25);
            this.LBLT_codigo.TabIndex = 15;
            this.LBLT_codigo.Text = "Nuevo valor de IVA (%):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.LBL_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 65);
            this.panel1.TabIndex = 14;
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.AutoSize = true;
            this.LBL_titulo.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titulo.ForeColor = System.Drawing.Color.Gold;
            this.LBL_titulo.Location = new System.Drawing.Point(168, 4);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(264, 57);
            this.LBL_titulo.TabIndex = 2;
            this.LBL_titulo.Text = "Modifcar Iva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor actual del IVA (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "----";
            // 
            // FRMMODIFICARIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarIva);
            this.Controls.Add(this.TB_codigoProducto);
            this.Controls.Add(this.LBLT_codigo);
            this.Controls.Add(this.panel1);
            this.Name = "FRMMODIFICARIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMMODIFICARIVA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizarIva;
        private System.Windows.Forms.TextBox TB_codigoProducto;
        private System.Windows.Forms.Label LBLT_codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}