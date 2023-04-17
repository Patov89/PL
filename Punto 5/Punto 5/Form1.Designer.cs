namespace Punto_5
{
    partial class fVuelto
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
            this.lCliente = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lPago = new System.Windows.Forms.Label();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.tPago = new System.Windows.Forms.TextBox();
            this.bVuelto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(519, 328);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(103, 146);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(42, 13);
            this.lCliente.TabIndex = 1;
            this.lCliente.Text = "Cliente:";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(103, 200);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(34, 13);
            this.lTotal.TabIndex = 2;
            this.lTotal.Text = "Total:";
            // 
            // lPago
            // 
            this.lPago.AutoSize = true;
            this.lPago.Location = new System.Drawing.Point(103, 251);
            this.lPago.Name = "lPago";
            this.lPago.Size = new System.Drawing.Size(35, 13);
            this.lPago.TabIndex = 3;
            this.lPago.Text = "Pago:";
            // 
            // tCliente
            // 
            this.tCliente.Location = new System.Drawing.Point(209, 143);
            this.tCliente.Name = "tCliente";
            this.tCliente.Size = new System.Drawing.Size(100, 20);
            this.tCliente.TabIndex = 4;
            // 
            // tTotal
            // 
            this.tTotal.Location = new System.Drawing.Point(209, 197);
            this.tTotal.Name = "tTotal";
            this.tTotal.Size = new System.Drawing.Size(100, 20);
            this.tTotal.TabIndex = 5;
            // 
            // tPago
            // 
            this.tPago.Location = new System.Drawing.Point(209, 248);
            this.tPago.Name = "tPago";
            this.tPago.Size = new System.Drawing.Size(100, 20);
            this.tPago.TabIndex = 6;
            // 
            // bVuelto
            // 
            this.bVuelto.Location = new System.Drawing.Point(494, 189);
            this.bVuelto.Name = "bVuelto";
            this.bVuelto.Size = new System.Drawing.Size(75, 23);
            this.bVuelto.TabIndex = 7;
            this.bVuelto.Text = "Vuelto";
            this.bVuelto.UseVisualStyleBackColor = true;
            this.bVuelto.Click += new System.EventHandler(this.bVuelto_Click);
            // 
            // fVuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVuelto);
            this.Controls.Add(this.tPago);
            this.Controls.Add(this.tTotal);
            this.Controls.Add(this.tCliente);
            this.Controls.Add(this.lPago);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lCliente);
            this.Controls.Add(this.bCerrar);
            this.Name = "fVuelto";
            this.Text = "Vuelto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lPago;
        private System.Windows.Forms.TextBox tCliente;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.TextBox tPago;
        private System.Windows.Forms.Button bVuelto;
    }
}

