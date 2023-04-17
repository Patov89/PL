namespace Punto_7
{
    partial class fDigitos
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
            this.lIngresenumero = new System.Windows.Forms.Label();
            this.tIngresenumero = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(603, 291);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lIngresenumero
            // 
            this.lIngresenumero.AutoSize = true;
            this.lIngresenumero.Location = new System.Drawing.Point(101, 129);
            this.lIngresenumero.Name = "lIngresenumero";
            this.lIngresenumero.Size = new System.Drawing.Size(164, 13);
            this.lIngresenumero.TabIndex = 1;
            this.lIngresenumero.Text = "Ingrese un numero de dos cifras: ";
            this.lIngresenumero.Click += new System.EventHandler(this.lIngresenumero_Click);
            // 
            // tIngresenumero
            // 
            this.tIngresenumero.Location = new System.Drawing.Point(291, 129);
            this.tIngresenumero.Name = "tIngresenumero";
            this.tIngresenumero.Size = new System.Drawing.Size(100, 20);
            this.tIngresenumero.TabIndex = 2;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(252, 221);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // fDigitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tIngresenumero);
            this.Controls.Add(this.lIngresenumero);
            this.Controls.Add(this.bCerrar);
            this.Name = "fDigitos";
            this.Text = "Suma de digitos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lIngresenumero;
        private System.Windows.Forms.TextBox tIngresenumero;
        private System.Windows.Forms.Button bCalcular;
    }
}

