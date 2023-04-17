namespace Punto_8
{
    partial class fIntercambio
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
            this.lNumeroA = new System.Windows.Forms.Label();
            this.lNumeroB = new System.Windows.Forms.Label();
            this.tNumeroA = new System.Windows.Forms.TextBox();
            this.tNumeroB = new System.Windows.Forms.TextBox();
            this.bIntercambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(516, 264);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lNumeroA
            // 
            this.lNumeroA.AutoSize = true;
            this.lNumeroA.Location = new System.Drawing.Point(128, 119);
            this.lNumeroA.Name = "lNumeroA";
            this.lNumeroA.Size = new System.Drawing.Size(57, 13);
            this.lNumeroA.TabIndex = 1;
            this.lNumeroA.Text = "Numero A:";
            // 
            // lNumeroB
            // 
            this.lNumeroB.AutoSize = true;
            this.lNumeroB.Location = new System.Drawing.Point(128, 165);
            this.lNumeroB.Name = "lNumeroB";
            this.lNumeroB.Size = new System.Drawing.Size(57, 13);
            this.lNumeroB.TabIndex = 2;
            this.lNumeroB.Text = "Numero B:";
            // 
            // tNumeroA
            // 
            this.tNumeroA.Location = new System.Drawing.Point(214, 116);
            this.tNumeroA.Name = "tNumeroA";
            this.tNumeroA.Size = new System.Drawing.Size(100, 20);
            this.tNumeroA.TabIndex = 3;
            // 
            // tNumeroB
            // 
            this.tNumeroB.Location = new System.Drawing.Point(214, 162);
            this.tNumeroB.Name = "tNumeroB";
            this.tNumeroB.Size = new System.Drawing.Size(100, 20);
            this.tNumeroB.TabIndex = 4;
            // 
            // bIntercambiar
            // 
            this.bIntercambiar.Location = new System.Drawing.Point(455, 146);
            this.bIntercambiar.Name = "bIntercambiar";
            this.bIntercambiar.Size = new System.Drawing.Size(75, 23);
            this.bIntercambiar.TabIndex = 5;
            this.bIntercambiar.Text = "Intercambiar";
            this.bIntercambiar.UseVisualStyleBackColor = true;
            this.bIntercambiar.Click += new System.EventHandler(this.bIntercambiar_Click);
            // 
            // fIntercambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bIntercambiar);
            this.Controls.Add(this.tNumeroB);
            this.Controls.Add(this.tNumeroA);
            this.Controls.Add(this.lNumeroB);
            this.Controls.Add(this.lNumeroA);
            this.Controls.Add(this.bCerrar);
            this.Name = "fIntercambio";
            this.Text = "Intercambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lNumeroA;
        private System.Windows.Forms.Label lNumeroB;
        private System.Windows.Forms.TextBox tNumeroA;
        private System.Windows.Forms.TextBox tNumeroB;
        private System.Windows.Forms.Button bIntercambiar;
    }
}

