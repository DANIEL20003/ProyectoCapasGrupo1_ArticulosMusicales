namespace capaPresentacion
{
    partial class FRMMENUCLIENTE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ayuda = new System.Windows.Forms.Label();
            this.pcb_carrito = new System.Windows.Forms.PictureBox();
            this.pcb_catalogo = new System.Windows.Forms.PictureBox();
            this.lbl_salir = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_catalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(134, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a Harmony";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Indigo;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 377);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(715, 38);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(69, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catálogo de instrumentos musicales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(387, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carrito de instrumentos musicales";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ayuda
            // 
            this.lbl_ayuda.AutoSize = true;
            this.lbl_ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ayuda.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ayuda.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ayuda.Location = new System.Drawing.Point(643, 344);
            this.lbl_ayuda.Name = "lbl_ayuda";
            this.lbl_ayuda.Size = new System.Drawing.Size(60, 22);
            this.lbl_ayuda.TabIndex = 5;
            this.lbl_ayuda.Text = "Ayuda";
            this.lbl_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ayuda.Click += new System.EventHandler(this.lbl_ayuda_Click);
            // 
            // pcb_carrito
            // 
            this.pcb_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_carrito.Image = global::capaPresentacion.Properties.Resources.Carrito_instrumentos;
            this.pcb_carrito.Location = new System.Drawing.Point(415, 107);
            this.pcb_carrito.Name = "pcb_carrito";
            this.pcb_carrito.Size = new System.Drawing.Size(188, 174);
            this.pcb_carrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_carrito.TabIndex = 3;
            this.pcb_carrito.TabStop = false;
            this.pcb_carrito.Click += new System.EventHandler(this.pcb_carrito_Click);
            // 
            // pcb_catalogo
            // 
            this.pcb_catalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_catalogo.Image = global::capaPresentacion.Properties.Resources.Instrumentos;
            this.pcb_catalogo.Location = new System.Drawing.Point(97, 107);
            this.pcb_catalogo.Name = "pcb_catalogo";
            this.pcb_catalogo.Size = new System.Drawing.Size(205, 174);
            this.pcb_catalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_catalogo.TabIndex = 2;
            this.pcb_catalogo.TabStop = false;
            this.pcb_catalogo.Click += new System.EventHandler(this.pcb_catalogo_Click);
            // 
            // lbl_salir
            // 
            this.lbl_salir.AutoSize = true;
            this.lbl_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_salir.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salir.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_salir.Location = new System.Drawing.Point(12, 344);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(48, 22);
            this.lbl_salir.TabIndex = 6;
            this.lbl_salir.Text = "Salir";
            this.lbl_salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_salir.Click += new System.EventHandler(this.lbl_salir_Click);
            // 
            // FRMMENUCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(715, 415);
            this.Controls.Add(this.lbl_salir);
            this.Controls.Add(this.lbl_ayuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcb_carrito);
            this.Controls.Add(this.pcb_catalogo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FRMMENUCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMMENUCLIENTE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_catalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pcb_catalogo;
        private System.Windows.Forms.PictureBox pcb_carrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ayuda;
        private System.Windows.Forms.Label lbl_salir;
    }
}