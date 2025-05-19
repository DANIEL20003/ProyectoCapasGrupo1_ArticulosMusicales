namespace capaPresentacion
{
    partial class FRMCARRITO
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVcarrito = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_precio_total = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estos son los instrumentos musicales guardados en tu carrito:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "IVA aplicado:";
            // 
            // DGVcarrito
            // 
            this.DGVcarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcarrito.Location = new System.Drawing.Point(35, 196);
            this.DGVcarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVcarrito.Name = "DGVcarrito";
            this.DGVcarrito.RowHeadersWidth = 51;
            this.DGVcarrito.Size = new System.Drawing.Size(625, 286);
            this.DGVcarrito.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 123);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 72);
            this.label1.TabIndex = 29;
            this.label1.Text = "Carrito de instrumentos musicales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 512);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 42);
            this.panel2.TabIndex = 9;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(695, 442);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(140, 39);
            this.btn_volver.TabIndex = 26;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            // 
            // lbl_precio_total
            // 
            this.lbl_precio_total.AutoSize = true;
            this.lbl_precio_total.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_total.Location = new System.Drawing.Point(847, 196);
            this.lbl_precio_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precio_total.Name = "lbl_precio_total";
            this.lbl_precio_total.Size = new System.Drawing.Size(88, 28);
            this.lbl_precio_total.TabIndex = 27;
            this.lbl_precio_total.Text = "$ 234.25";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.Location = new System.Drawing.Point(857, 238);
            this.lbl_iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(55, 28);
            this.lbl_iva.TabIndex = 28;
            this.lbl_iva.Text = "15 %";
            // 
            // FRMCARRITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_iva);
            this.Controls.Add(this.lbl_precio_total);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGVcarrito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMCARRITO";
            this.Text = "FRMCARRITO";
            this.Load += new System.EventHandler(this.FRMCARRITO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVcarrito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_precio_total;
        private System.Windows.Forms.Label lbl_iva;
    }
}