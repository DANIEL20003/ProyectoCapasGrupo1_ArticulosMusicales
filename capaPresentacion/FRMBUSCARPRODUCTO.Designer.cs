namespace capaPresentacion
{
    partial class FRMBUSCARPRODUCTO
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
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLT_codigo = new System.Windows.Forms.Label();
            this.TB_codigoProducto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdIva = new System.Windows.Forms.Label();
            this.lblaFab = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblt_dimension = new System.Windows.Forms.Label();
            this.lblt_material = new System.Windows.Forms.Label();
            this.lblt_color = new System.Windows.Forms.Label();
            this.lblt_proveedor = new System.Windows.Forms.Label();
            this.lblt_categoria = new System.Windows.Forms.Label();
            this.lblt_cantidad = new System.Windows.Forms.Label();
            this.lblt_idIva = new System.Windows.Forms.Label();
            this.lblt_anioFab = new System.Windows.Forms.Label();
            this.lblt_precio = new System.Windows.Forms.Label();
            this.lblt_modelo = new System.Windows.Forms.Label();
            this.lblt_marca = new System.Windows.Forms.Label();
            this.lblt_nombre = new System.Windows.Forms.Label();
            this.LBLT_cod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.LBL_titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 65);
            this.panel1.TabIndex = 0;
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.AutoSize = true;
            this.LBL_titulo.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titulo.ForeColor = System.Drawing.Color.Gold;
            this.LBL_titulo.Location = new System.Drawing.Point(240, 4);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(319, 57);
            this.LBL_titulo.TabIndex = 2;
            this.LBL_titulo.Text = "Buscar Producto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(313, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Todos los derechos reservados";
            // 
            // LBLT_codigo
            // 
            this.LBLT_codigo.AutoSize = true;
            this.LBLT_codigo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLT_codigo.ForeColor = System.Drawing.Color.Black;
            this.LBLT_codigo.Location = new System.Drawing.Point(61, 104);
            this.LBLT_codigo.Name = "LBLT_codigo";
            this.LBLT_codigo.Size = new System.Drawing.Size(267, 25);
            this.LBLT_codigo.TabIndex = 3;
            this.LBLT_codigo.Text = "Ingrese el Código del producto:";
            // 
            // TB_codigoProducto
            // 
            this.TB_codigoProducto.Location = new System.Drawing.Point(334, 109);
            this.TB_codigoProducto.Name = "TB_codigoProducto";
            this.TB_codigoProducto.Size = new System.Drawing.Size(261, 20);
            this.TB_codigoProducto.TabIndex = 4;
            this.TB_codigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_codigoProducto_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Indigo;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gold;
            this.btnBuscar.Location = new System.Drawing.Point(624, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 30);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDimension);
            this.groupBox1.Controls.Add(this.lblMaterial);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblIdIva);
            this.groupBox1.Controls.Add(this.lblaFab);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblModelo);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblt_dimension);
            this.groupBox1.Controls.Add(this.lblt_material);
            this.groupBox1.Controls.Add(this.lblt_color);
            this.groupBox1.Controls.Add(this.lblt_proveedor);
            this.groupBox1.Controls.Add(this.lblt_categoria);
            this.groupBox1.Controls.Add(this.lblt_cantidad);
            this.groupBox1.Controls.Add(this.lblt_idIva);
            this.groupBox1.Controls.Add(this.lblt_anioFab);
            this.groupBox1.Controls.Add(this.lblt_precio);
            this.groupBox1.Controls.Add(this.lblt_modelo);
            this.groupBox1.Controls.Add(this.lblt_marca);
            this.groupBox1.Controls.Add(this.lblt_nombre);
            this.groupBox1.Controls.Add(this.LBLT_cod);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension.Location = new System.Drawing.Point(651, 99);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(20, 18);
            this.lblDimension.TabIndex = 25;
            this.lblDimension.Text = "...";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(651, 67);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(20, 18);
            this.lblMaterial.TabIndex = 24;
            this.lblMaterial.Text = "...";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(651, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(20, 18);
            this.lblColor.TabIndex = 23;
            this.lblColor.Text = "...";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(419, 163);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(20, 18);
            this.lblProveedor.TabIndex = 22;
            this.lblProveedor.Text = "...";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(419, 131);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(20, 18);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "...";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(419, 99);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(20, 18);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Text = "...";
            // 
            // lblIdIva
            // 
            this.lblIdIva.AutoSize = true;
            this.lblIdIva.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdIva.Location = new System.Drawing.Point(419, 67);
            this.lblIdIva.Name = "lblIdIva";
            this.lblIdIva.Size = new System.Drawing.Size(20, 18);
            this.lblIdIva.TabIndex = 19;
            this.lblIdIva.Text = "...";
            // 
            // lblaFab
            // 
            this.lblaFab.AutoSize = true;
            this.lblaFab.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaFab.Location = new System.Drawing.Point(419, 35);
            this.lblaFab.Name = "lblaFab";
            this.lblaFab.Size = new System.Drawing.Size(20, 18);
            this.lblaFab.TabIndex = 18;
            this.lblaFab.Text = "...";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(143, 163);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(20, 18);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "...";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(143, 131);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(20, 18);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "...";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(143, 99);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(20, 18);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "...";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(143, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(20, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "...";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(143, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(20, 18);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "...";
            // 
            // lblt_dimension
            // 
            this.lblt_dimension.AutoSize = true;
            this.lblt_dimension.Location = new System.Drawing.Point(547, 99);
            this.lblt_dimension.Name = "lblt_dimension";
            this.lblt_dimension.Size = new System.Drawing.Size(82, 18);
            this.lblt_dimension.TabIndex = 12;
            this.lblt_dimension.Text = "Dimensión:";
            // 
            // lblt_material
            // 
            this.lblt_material.AutoSize = true;
            this.lblt_material.Location = new System.Drawing.Point(547, 67);
            this.lblt_material.Name = "lblt_material";
            this.lblt_material.Size = new System.Drawing.Size(70, 18);
            this.lblt_material.TabIndex = 11;
            this.lblt_material.Text = "Material:";
            // 
            // lblt_color
            // 
            this.lblt_color.AutoSize = true;
            this.lblt_color.Location = new System.Drawing.Point(547, 35);
            this.lblt_color.Name = "lblt_color";
            this.lblt_color.Size = new System.Drawing.Size(47, 18);
            this.lblt_color.TabIndex = 10;
            this.lblt_color.Text = "Color:";
            // 
            // lblt_proveedor
            // 
            this.lblt_proveedor.AutoSize = true;
            this.lblt_proveedor.Location = new System.Drawing.Point(273, 163);
            this.lblt_proveedor.Name = "lblt_proveedor";
            this.lblt_proveedor.Size = new System.Drawing.Size(80, 18);
            this.lblt_proveedor.TabIndex = 9;
            this.lblt_proveedor.Text = "Proveedor:";
            // 
            // lblt_categoria
            // 
            this.lblt_categoria.AutoSize = true;
            this.lblt_categoria.Location = new System.Drawing.Point(273, 131);
            this.lblt_categoria.Name = "lblt_categoria";
            this.lblt_categoria.Size = new System.Drawing.Size(74, 18);
            this.lblt_categoria.TabIndex = 8;
            this.lblt_categoria.Text = "Categoría:";
            // 
            // lblt_cantidad
            // 
            this.lblt_cantidad.AutoSize = true;
            this.lblt_cantidad.Location = new System.Drawing.Point(273, 99);
            this.lblt_cantidad.Name = "lblt_cantidad";
            this.lblt_cantidad.Size = new System.Drawing.Size(73, 18);
            this.lblt_cantidad.TabIndex = 7;
            this.lblt_cantidad.Text = "Cantidad:";
            // 
            // lblt_idIva
            // 
            this.lblt_idIva.AutoSize = true;
            this.lblt_idIva.Location = new System.Drawing.Point(273, 67);
            this.lblt_idIva.Name = "lblt_idIva";
            this.lblt_idIva.Size = new System.Drawing.Size(55, 18);
            this.lblt_idIva.TabIndex = 6;
            this.lblt_idIva.Text = "Id iva:";
            // 
            // lblt_anioFab
            // 
            this.lblt_anioFab.AutoSize = true;
            this.lblt_anioFab.Location = new System.Drawing.Point(273, 35);
            this.lblt_anioFab.Name = "lblt_anioFab";
            this.lblt_anioFab.Size = new System.Drawing.Size(140, 18);
            this.lblt_anioFab.TabIndex = 5;
            this.lblt_anioFab.Text = "Año de Fabricación:";
            // 
            // lblt_precio
            // 
            this.lblt_precio.AutoSize = true;
            this.lblt_precio.Location = new System.Drawing.Point(62, 163);
            this.lblt_precio.Name = "lblt_precio";
            this.lblt_precio.Size = new System.Drawing.Size(53, 18);
            this.lblt_precio.TabIndex = 4;
            this.lblt_precio.Text = "Precio:";
            // 
            // lblt_modelo
            // 
            this.lblt_modelo.AutoSize = true;
            this.lblt_modelo.Location = new System.Drawing.Point(62, 131);
            this.lblt_modelo.Name = "lblt_modelo";
            this.lblt_modelo.Size = new System.Drawing.Size(62, 18);
            this.lblt_modelo.TabIndex = 3;
            this.lblt_modelo.Text = "Modelo:";
            // 
            // lblt_marca
            // 
            this.lblt_marca.AutoSize = true;
            this.lblt_marca.Location = new System.Drawing.Point(62, 99);
            this.lblt_marca.Name = "lblt_marca";
            this.lblt_marca.Size = new System.Drawing.Size(53, 18);
            this.lblt_marca.TabIndex = 2;
            this.lblt_marca.Text = "Marca:";
            // 
            // lblt_nombre
            // 
            this.lblt_nombre.AutoSize = true;
            this.lblt_nombre.Location = new System.Drawing.Point(62, 67);
            this.lblt_nombre.Name = "lblt_nombre";
            this.lblt_nombre.Size = new System.Drawing.Size(64, 18);
            this.lblt_nombre.TabIndex = 1;
            this.lblt_nombre.Text = "Nombre:";
            // 
            // LBLT_cod
            // 
            this.LBLT_cod.AutoSize = true;
            this.LBLT_cod.Location = new System.Drawing.Point(62, 35);
            this.LBLT_cod.Name = "LBLT_cod";
            this.LBLT_cod.Size = new System.Drawing.Size(57, 18);
            this.LBLT_cod.TabIndex = 0;
            this.LBLT_cod.Text = "Código:";
            // 
            // FRMBUSCARPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.TB_codigoProducto);
            this.Controls.Add(this.LBLT_codigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FRMBUSCARPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMBUSCARPRODUCTO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.Label LBLT_codigo;
        private System.Windows.Forms.TextBox TB_codigoProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblt_dimension;
        private System.Windows.Forms.Label lblt_material;
        private System.Windows.Forms.Label lblt_color;
        private System.Windows.Forms.Label lblt_proveedor;
        private System.Windows.Forms.Label lblt_categoria;
        private System.Windows.Forms.Label lblt_cantidad;
        private System.Windows.Forms.Label lblt_idIva;
        private System.Windows.Forms.Label lblt_anioFab;
        private System.Windows.Forms.Label lblt_precio;
        private System.Windows.Forms.Label lblt_modelo;
        private System.Windows.Forms.Label lblt_marca;
        private System.Windows.Forms.Label lblt_nombre;
        private System.Windows.Forms.Label LBLT_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdIva;
        private System.Windows.Forms.Label lblaFab;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}