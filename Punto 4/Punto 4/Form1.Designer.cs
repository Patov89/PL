namespace Punto_4
{
    partial class fGigabyte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCerrar = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lTamañomb = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tTamaño = new System.Windows.Forms.TextBox();
            this.bConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(544, 366);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(143, 135);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(50, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre: ";
            // 
            // lTamañomb
            // 
            this.lTamañomb.AutoSize = true;
            this.lTamañomb.Location = new System.Drawing.Point(143, 181);
            this.lTamañomb.Name = "lTamañomb";
            this.lTamañomb.Size = new System.Drawing.Size(74, 13);
            this.lTamañomb.TabIndex = 2;
            this.lTamañomb.Text = "Tamaño (MB):";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(267, 132);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 3;
            // 
            // tTamaño
            // 
            this.tTamaño.Location = new System.Drawing.Point(267, 178);
            this.tTamaño.Name = "tTamaño";
            this.tTamaño.Size = new System.Drawing.Size(100, 20);
            this.tTamaño.TabIndex = 4;
            // 
            // bConvertir
            // 
            this.bConvertir.Location = new System.Drawing.Point(584, 154);
            this.bConvertir.Name = "bConvertir";
            this.bConvertir.Size = new System.Drawing.Size(75, 23);
            this.bConvertir.TabIndex = 5;
            this.bConvertir.Text = "Convertir";
            this.bConvertir.UseVisualStyleBackColor = true;
            this.bConvertir.Click += new System.EventHandler(this.bConvertir_Click);
            // 
            // fGigabyte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConvertir);
            this.Controls.Add(this.tTamaño);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lTamañomb);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bCerrar);
            this.Name = "fGigabyte";
            this.Text = "Gigabyte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lTamañomb;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tTamaño;
        private System.Windows.Forms.Button bConvertir;
    }
}

