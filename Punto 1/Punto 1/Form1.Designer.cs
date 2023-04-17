namespace Punto_1
{
    partial class fCirculo
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
            this.lRadio = new System.Windows.Forms.Label();
            this.lUnidad = new System.Windows.Forms.Label();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.tUnidad = new System.Windows.Forms.TextBox();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(587, 286);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lRadio
            // 
            this.lRadio.AutoSize = true;
            this.lRadio.Location = new System.Drawing.Point(114, 131);
            this.lRadio.Name = "lRadio";
            this.lRadio.Size = new System.Drawing.Size(41, 13);
            this.lRadio.TabIndex = 1;
            this.lRadio.Text = "Radio: ";
            // 
            // lUnidad
            // 
            this.lUnidad.AutoSize = true;
            this.lUnidad.Location = new System.Drawing.Point(114, 191);
            this.lUnidad.Name = "lUnidad";
            this.lUnidad.Size = new System.Drawing.Size(95, 13);
            this.lUnidad.TabIndex = 2;
            this.lUnidad.Text = "Unidad (cm,m,km):";
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(271, 124);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(100, 20);
            this.tRadio.TabIndex = 3;
            // 
            // tUnidad
            // 
            this.tUnidad.Location = new System.Drawing.Point(271, 184);
            this.tUnidad.Name = "tUnidad";
            this.tUnidad.Size = new System.Drawing.Size(100, 20);
            this.tUnidad.TabIndex = 4;
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(522, 122);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 5;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(522, 182);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // fCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.tUnidad);
            this.Controls.Add(this.tRadio);
            this.Controls.Add(this.lUnidad);
            this.Controls.Add(this.lRadio);
            this.Controls.Add(this.bCerrar);
            this.Name = "fCirculo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lRadio;
        private System.Windows.Forms.Label lUnidad;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.TextBox tUnidad;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bArea;
    }
}

