namespace Punto_6
{
    partial class fCapacidad
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
            this.lCupototal = new System.Windows.Forms.Label();
            this.lCantidadpersonas = new System.Windows.Forms.Label();
            this.tCupototal = new System.Windows.Forms.TextBox();
            this.tCantidadpersonas = new System.Windows.Forms.TextBox();
            this.bPorcentaje = new System.Windows.Forms.Button();
            this.bIngresopersona = new System.Windows.Forms.Button();
            this.bEgresopersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(556, 392);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lCupototal
            // 
            this.lCupototal.AutoSize = true;
            this.lCupototal.Location = new System.Drawing.Point(92, 115);
            this.lCupototal.Name = "lCupototal";
            this.lCupototal.Size = new System.Drawing.Size(106, 13);
            this.lCupototal.TabIndex = 1;
            this.lCupototal.Text = "Cupo total de la sala:";
            // 
            // lCantidadpersonas
            // 
            this.lCantidadpersonas.AutoSize = true;
            this.lCantidadpersonas.Location = new System.Drawing.Point(91, 159);
            this.lCantidadpersonas.Name = "lCantidadpersonas";
            this.lCantidadpersonas.Size = new System.Drawing.Size(177, 13);
            this.lCantidadpersonas.TabIndex = 2;
            this.lCantidadpersonas.Text = "Cantidad de personas actualmente: ";
            // 
            // tCupototal
            // 
            this.tCupototal.Location = new System.Drawing.Point(304, 112);
            this.tCupototal.Name = "tCupototal";
            this.tCupototal.Size = new System.Drawing.Size(100, 20);
            this.tCupototal.TabIndex = 3;
            // 
            // tCantidadpersonas
            // 
            this.tCantidadpersonas.Location = new System.Drawing.Point(304, 156);
            this.tCantidadpersonas.Name = "tCantidadpersonas";
            this.tCantidadpersonas.Size = new System.Drawing.Size(100, 20);
            this.tCantidadpersonas.TabIndex = 4;
            // 
            // bPorcentaje
            // 
            this.bPorcentaje.Location = new System.Drawing.Point(217, 248);
            this.bPorcentaje.Name = "bPorcentaje";
            this.bPorcentaje.Size = new System.Drawing.Size(144, 23);
            this.bPorcentaje.TabIndex = 5;
            this.bPorcentaje.Text = "Porcentaje de ocupacion";
            this.bPorcentaje.UseVisualStyleBackColor = true;
            this.bPorcentaje.Click += new System.EventHandler(this.bPorcentaje_Click);
            // 
            // bIngresopersona
            // 
            this.bIngresopersona.Location = new System.Drawing.Point(217, 295);
            this.bIngresopersona.Name = "bIngresopersona";
            this.bIngresopersona.Size = new System.Drawing.Size(116, 23);
            this.bIngresopersona.TabIndex = 6;
            this.bIngresopersona.Text = "Ingreso de persona";
            this.bIngresopersona.UseVisualStyleBackColor = true;
            this.bIngresopersona.Click += new System.EventHandler(this.bIngresopersona_Click);
            // 
            // bEgresopersona
            // 
            this.bEgresopersona.Location = new System.Drawing.Point(217, 340);
            this.bEgresopersona.Name = "bEgresopersona";
            this.bEgresopersona.Size = new System.Drawing.Size(116, 23);
            this.bEgresopersona.TabIndex = 7;
            this.bEgresopersona.Text = "Egreso de persona";
            this.bEgresopersona.UseVisualStyleBackColor = true;
            this.bEgresopersona.Click += new System.EventHandler(this.bEgresopersona_Click);
            // 
            // fCapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEgresopersona);
            this.Controls.Add(this.bIngresopersona);
            this.Controls.Add(this.bPorcentaje);
            this.Controls.Add(this.tCantidadpersonas);
            this.Controls.Add(this.tCupototal);
            this.Controls.Add(this.lCantidadpersonas);
            this.Controls.Add(this.lCupototal);
            this.Controls.Add(this.bCerrar);
            this.Name = "fCapacidad";
            this.Text = "Capacidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lCupototal;
        private System.Windows.Forms.Label lCantidadpersonas;
        private System.Windows.Forms.TextBox tCupototal;
        private System.Windows.Forms.TextBox tCantidadpersonas;
        private System.Windows.Forms.Button bPorcentaje;
        private System.Windows.Forms.Button bIngresopersona;
        private System.Windows.Forms.Button bEgresopersona;
    }
}

