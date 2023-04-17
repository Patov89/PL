namespace Punto_2
{
    partial class fTiempo
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
            this.lDestino = new System.Windows.Forms.Label();
            this.lDistancia = new System.Windows.Forms.Label();
            this.lVelocidad = new System.Windows.Forms.Label();
            this.tDestino = new System.Windows.Forms.TextBox();
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.bTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(585, 261);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lDestino
            // 
            this.lDestino.AutoSize = true;
            this.lDestino.Location = new System.Drawing.Point(72, 96);
            this.lDestino.Name = "lDestino";
            this.lDestino.Size = new System.Drawing.Size(46, 13);
            this.lDestino.TabIndex = 1;
            this.lDestino.Text = "Destino:";
            // 
            // lDistancia
            // 
            this.lDistancia.AutoSize = true;
            this.lDistancia.Location = new System.Drawing.Point(72, 144);
            this.lDistancia.Name = "lDistancia";
            this.lDistancia.Size = new System.Drawing.Size(77, 13);
            this.lDistancia.TabIndex = 2;
            this.lDistancia.Text = "Distancia (km):";
            // 
            // lVelocidad
            // 
            this.lVelocidad.AutoSize = true;
            this.lVelocidad.Location = new System.Drawing.Point(72, 193);
            this.lVelocidad.Name = "lVelocidad";
            this.lVelocidad.Size = new System.Drawing.Size(91, 13);
            this.lVelocidad.TabIndex = 3;
            this.lVelocidad.Text = "Velocidad (km/h):";
            // 
            // tDestino
            // 
            this.tDestino.Location = new System.Drawing.Point(198, 93);
            this.tDestino.Name = "tDestino";
            this.tDestino.Size = new System.Drawing.Size(100, 20);
            this.tDestino.TabIndex = 4;
            // 
            // tDistancia
            // 
            this.tDistancia.Location = new System.Drawing.Point(198, 141);
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(100, 20);
            this.tDistancia.TabIndex = 5;
            // 
            // tVelocidad
            // 
            this.tVelocidad.Location = new System.Drawing.Point(198, 193);
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(100, 20);
            this.tVelocidad.TabIndex = 6;
            // 
            // bTiempo
            // 
            this.bTiempo.Location = new System.Drawing.Point(440, 141);
            this.bTiempo.Name = "bTiempo";
            this.bTiempo.Size = new System.Drawing.Size(75, 23);
            this.bTiempo.TabIndex = 7;
            this.bTiempo.Text = "Tiempo";
            this.bTiempo.UseVisualStyleBackColor = true;
            this.bTiempo.Click += new System.EventHandler(this.bTiempo_Click);
            // 
            // fTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTiempo);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.tDestino);
            this.Controls.Add(this.lVelocidad);
            this.Controls.Add(this.lDistancia);
            this.Controls.Add(this.lDestino);
            this.Controls.Add(this.bCerrar);
            this.Name = "fTiempo";
            this.Text = "Tiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lDestino;
        private System.Windows.Forms.Label lDistancia;
        private System.Windows.Forms.Label lVelocidad;
        private System.Windows.Forms.TextBox tDestino;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Button bTiempo;
    }
}

