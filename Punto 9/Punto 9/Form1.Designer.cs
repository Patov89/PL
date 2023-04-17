namespace Punto_9
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
            this.lTiempo1 = new System.Windows.Forms.Label();
            this.lHoras = new System.Windows.Forms.Label();
            this.lMinutos = new System.Windows.Forms.Label();
            this.lSegundos = new System.Windows.Forms.Label();
            this.lTiempo2 = new System.Windows.Forms.Label();
            this.tHoras1 = new System.Windows.Forms.TextBox();
            this.tMinutos1 = new System.Windows.Forms.TextBox();
            this.tSegundos1 = new System.Windows.Forms.TextBox();
            this.tHoras2 = new System.Windows.Forms.TextBox();
            this.tMinutos2 = new System.Windows.Forms.TextBox();
            this.tSegundos2 = new System.Windows.Forms.TextBox();
            this.bSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(549, 288);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lTiempo1
            // 
            this.lTiempo1.AutoSize = true;
            this.lTiempo1.Location = new System.Drawing.Point(229, 56);
            this.lTiempo1.Name = "lTiempo1";
            this.lTiempo1.Size = new System.Drawing.Size(51, 13);
            this.lTiempo1.TabIndex = 1;
            this.lTiempo1.Text = "Tiempo 1";
            // 
            // lHoras
            // 
            this.lHoras.AutoSize = true;
            this.lHoras.Location = new System.Drawing.Point(91, 104);
            this.lHoras.Name = "lHoras";
            this.lHoras.Size = new System.Drawing.Size(38, 13);
            this.lHoras.TabIndex = 2;
            this.lHoras.Text = "Horas:";
            // 
            // lMinutos
            // 
            this.lMinutos.AutoSize = true;
            this.lMinutos.Location = new System.Drawing.Point(91, 151);
            this.lMinutos.Name = "lMinutos";
            this.lMinutos.Size = new System.Drawing.Size(47, 13);
            this.lMinutos.TabIndex = 3;
            this.lMinutos.Text = "Minutos:";
            this.lMinutos.Click += new System.EventHandler(this.label3_Click);
            // 
            // lSegundos
            // 
            this.lSegundos.AutoSize = true;
            this.lSegundos.Location = new System.Drawing.Point(91, 201);
            this.lSegundos.Name = "lSegundos";
            this.lSegundos.Size = new System.Drawing.Size(58, 13);
            this.lSegundos.TabIndex = 4;
            this.lSegundos.Text = "Segundos:";
            // 
            // lTiempo2
            // 
            this.lTiempo2.AutoSize = true;
            this.lTiempo2.Location = new System.Drawing.Point(391, 56);
            this.lTiempo2.Name = "lTiempo2";
            this.lTiempo2.Size = new System.Drawing.Size(51, 13);
            this.lTiempo2.TabIndex = 5;
            this.lTiempo2.Text = "Tiempo 2";
            // 
            // tHoras1
            // 
            this.tHoras1.Location = new System.Drawing.Point(209, 104);
            this.tHoras1.Name = "tHoras1";
            this.tHoras1.Size = new System.Drawing.Size(100, 20);
            this.tHoras1.TabIndex = 6;
            // 
            // tMinutos1
            // 
            this.tMinutos1.Location = new System.Drawing.Point(209, 151);
            this.tMinutos1.Name = "tMinutos1";
            this.tMinutos1.Size = new System.Drawing.Size(100, 20);
            this.tMinutos1.TabIndex = 7;
            // 
            // tSegundos1
            // 
            this.tSegundos1.Location = new System.Drawing.Point(209, 201);
            this.tSegundos1.Name = "tSegundos1";
            this.tSegundos1.Size = new System.Drawing.Size(100, 20);
            this.tSegundos1.TabIndex = 8;
            // 
            // tHoras2
            // 
            this.tHoras2.Location = new System.Drawing.Point(373, 101);
            this.tHoras2.Name = "tHoras2";
            this.tHoras2.Size = new System.Drawing.Size(100, 20);
            this.tHoras2.TabIndex = 9;
            // 
            // tMinutos2
            // 
            this.tMinutos2.Location = new System.Drawing.Point(373, 148);
            this.tMinutos2.Name = "tMinutos2";
            this.tMinutos2.Size = new System.Drawing.Size(100, 20);
            this.tMinutos2.TabIndex = 10;
            // 
            // tSegundos2
            // 
            this.tSegundos2.Location = new System.Drawing.Point(373, 201);
            this.tSegundos2.Name = "tSegundos2";
            this.tSegundos2.Size = new System.Drawing.Size(100, 20);
            this.tSegundos2.TabIndex = 11;
            // 
            // bSumar
            // 
            this.bSumar.Location = new System.Drawing.Point(549, 147);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(75, 23);
            this.bSumar.TabIndex = 12;
            this.bSumar.Text = "Sumar";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.bSumar_Click);
            // 
            // fTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSumar);
            this.Controls.Add(this.tSegundos2);
            this.Controls.Add(this.tMinutos2);
            this.Controls.Add(this.tHoras2);
            this.Controls.Add(this.tSegundos1);
            this.Controls.Add(this.tMinutos1);
            this.Controls.Add(this.tHoras1);
            this.Controls.Add(this.lTiempo2);
            this.Controls.Add(this.lSegundos);
            this.Controls.Add(this.lMinutos);
            this.Controls.Add(this.lHoras);
            this.Controls.Add(this.lTiempo1);
            this.Controls.Add(this.bCerrar);
            this.Name = "fTiempo";
            this.Text = "Tiempo:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lTiempo1;
        private System.Windows.Forms.Label lHoras;
        private System.Windows.Forms.Label lMinutos;
        private System.Windows.Forms.Label lSegundos;
        private System.Windows.Forms.Label lTiempo2;
        private System.Windows.Forms.TextBox tHoras1;
        private System.Windows.Forms.TextBox tMinutos1;
        private System.Windows.Forms.TextBox tSegundos1;
        private System.Windows.Forms.TextBox tHoras2;
        private System.Windows.Forms.TextBox tMinutos2;
        private System.Windows.Forms.TextBox tSegundos2;
        private System.Windows.Forms.Button bSumar;
    }
}

