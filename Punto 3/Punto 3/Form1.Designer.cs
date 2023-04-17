namespace Punto_3
{
    partial class fArena
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
            this.lAncho = new System.Windows.Forms.Label();
            this.lAlto = new System.Windows.Forms.Label();
            this.lMetroscubicos = new System.Windows.Forms.Label();
            this.tAncho = new System.Windows.Forms.TextBox();
            this.tAlto = new System.Windows.Forms.TextBox();
            this.tMetroscubicos = new System.Windows.Forms.TextBox();
            this.bArena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(505, 253);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lAncho
            // 
            this.lAncho.AutoSize = true;
            this.lAncho.Location = new System.Drawing.Point(81, 98);
            this.lAncho.Name = "lAncho";
            this.lAncho.Size = new System.Drawing.Size(41, 13);
            this.lAncho.TabIndex = 1;
            this.lAncho.Text = "Ancho:";
            // 
            // lAlto
            // 
            this.lAlto.AutoSize = true;
            this.lAlto.Location = new System.Drawing.Point(81, 150);
            this.lAlto.Name = "lAlto";
            this.lAlto.Size = new System.Drawing.Size(28, 13);
            this.lAlto.TabIndex = 2;
            this.lAlto.Text = "Alto:";
            // 
            // lMetroscubicos
            // 
            this.lMetroscubicos.AutoSize = true;
            this.lMetroscubicos.Location = new System.Drawing.Point(81, 197);
            this.lMetroscubicos.Name = "lMetroscubicos";
            this.lMetroscubicos.Size = new System.Drawing.Size(83, 13);
            this.lMetroscubicos.TabIndex = 3;
            this.lMetroscubicos.Text = "Metros Cubicos:";
            // 
            // tAncho
            // 
            this.tAncho.Location = new System.Drawing.Point(202, 98);
            this.tAncho.Name = "tAncho";
            this.tAncho.Size = new System.Drawing.Size(100, 20);
            this.tAncho.TabIndex = 4;
            // 
            // tAlto
            // 
            this.tAlto.Location = new System.Drawing.Point(202, 147);
            this.tAlto.Name = "tAlto";
            this.tAlto.Size = new System.Drawing.Size(100, 20);
            this.tAlto.TabIndex = 5;
            // 
            // tMetroscubicos
            // 
            this.tMetroscubicos.Location = new System.Drawing.Point(202, 194);
            this.tMetroscubicos.Name = "tMetroscubicos";
            this.tMetroscubicos.Size = new System.Drawing.Size(100, 20);
            this.tMetroscubicos.TabIndex = 6;
            // 
            // bArena
            // 
            this.bArena.Location = new System.Drawing.Point(467, 150);
            this.bArena.Name = "bArena";
            this.bArena.Size = new System.Drawing.Size(75, 23);
            this.bArena.TabIndex = 7;
            this.bArena.Text = "Arena";
            this.bArena.UseVisualStyleBackColor = true;
            this.bArena.Click += new System.EventHandler(this.bArena_Click);
            // 
            // fArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bArena);
            this.Controls.Add(this.tMetroscubicos);
            this.Controls.Add(this.tAlto);
            this.Controls.Add(this.tAncho);
            this.Controls.Add(this.lMetroscubicos);
            this.Controls.Add(this.lAlto);
            this.Controls.Add(this.lAncho);
            this.Controls.Add(this.bCerrar);
            this.Name = "fArena";
            this.Text = "Arena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lAncho;
        private System.Windows.Forms.Label lAlto;
        private System.Windows.Forms.Label lMetroscubicos;
        private System.Windows.Forms.TextBox tAncho;
        private System.Windows.Forms.TextBox tAlto;
        private System.Windows.Forms.TextBox tMetroscubicos;
        private System.Windows.Forms.Button bArena;
    }
}

