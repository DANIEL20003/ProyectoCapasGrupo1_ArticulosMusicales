namespace capaPresentacion
{
    partial class FRMMENUADMINISTRADOR
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
            this.lblsaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsaludo
            // 
            this.lblsaludo.AutoSize = true;
            this.lblsaludo.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaludo.ForeColor = System.Drawing.Color.Black;
            this.lblsaludo.Location = new System.Drawing.Point(36, 364);
            this.lblsaludo.Name = "lblsaludo";
            this.lblsaludo.Size = new System.Drawing.Size(93, 40);
            this.lblsaludo.TabIndex = 73;
            this.lblsaludo.Text = "saludo";
            // 
            // FRMMENUADMINISTRADOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsaludo);
            this.Name = "FRMMENUADMINISTRADOR";
            this.Text = "FRMMENUADMINISTRADOR";
            this.Load += new System.EventHandler(this.FRMMENUADMINISTRADOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsaludo;
    }
}