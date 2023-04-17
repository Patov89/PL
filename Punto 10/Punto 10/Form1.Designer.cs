namespace Punto_10
{
    partial class fSalario
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
            this.lAñoingreso = new System.Windows.Forms.Label();
            this.lHorastrabajadaspordia = new System.Windows.Forms.Label();
            this.lTarifahoraria = new System.Windows.Forms.Label();
            this.lDiastrabajadospormes = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tAñodeingreso = new System.Windows.Forms.TextBox();
            this.tTarifahoraria = new System.Windows.Forms.TextBox();
            this.tHorastrabajadaspordia = new System.Windows.Forms.TextBox();
            this.tDiastrabajadospormes = new System.Windows.Forms.TextBox();
            this.bSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(586, 296);
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
            this.lNombre.Location = new System.Drawing.Point(66, 79);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre:";
            // 
            // lAñoingreso
            // 
            this.lAñoingreso.AutoSize = true;
            this.lAñoingreso.Location = new System.Drawing.Point(66, 123);
            this.lAñoingreso.Name = "lAñoingreso";
            this.lAñoingreso.Size = new System.Drawing.Size(81, 13);
            this.lAñoingreso.TabIndex = 2;
            this.lAñoingreso.Text = "Año de ingreso:";
            // 
            // lHorastrabajadaspordia
            // 
            this.lHorastrabajadaspordia.AutoSize = true;
            this.lHorastrabajadaspordia.Location = new System.Drawing.Point(66, 211);
            this.lHorastrabajadaspordia.Name = "lHorastrabajadaspordia";
            this.lHorastrabajadaspordia.Size = new System.Drawing.Size(127, 13);
            this.lHorastrabajadaspordia.TabIndex = 3;
            this.lHorastrabajadaspordia.Text = "Horas trabajadas por día:";
            // 
            // lTarifahoraria
            // 
            this.lTarifahoraria.AutoSize = true;
            this.lTarifahoraria.Location = new System.Drawing.Point(66, 167);
            this.lTarifahoraria.Name = "lTarifahoraria";
            this.lTarifahoraria.Size = new System.Drawing.Size(74, 13);
            this.lTarifahoraria.TabIndex = 4;
            this.lTarifahoraria.Text = "Tarifa Horaria:";
            // 
            // lDiastrabajadospormes
            // 
            this.lDiastrabajadospormes.AutoSize = true;
            this.lDiastrabajadospormes.Location = new System.Drawing.Point(66, 256);
            this.lDiastrabajadospormes.Name = "lDiastrabajadospormes";
            this.lDiastrabajadospormes.Size = new System.Drawing.Size(125, 13);
            this.lDiastrabajadospormes.TabIndex = 5;
            this.lDiastrabajadospormes.Text = "Días trabajados por mes:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(264, 76);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(182, 20);
            this.tNombre.TabIndex = 6;
            // 
            // tAñodeingreso
            // 
            this.tAñodeingreso.Location = new System.Drawing.Point(264, 120);
            this.tAñodeingreso.Name = "tAñodeingreso";
            this.tAñodeingreso.Size = new System.Drawing.Size(100, 20);
            this.tAñodeingreso.TabIndex = 7;
            // 
            // tTarifahoraria
            // 
            this.tTarifahoraria.Location = new System.Drawing.Point(264, 164);
            this.tTarifahoraria.Name = "tTarifahoraria";
            this.tTarifahoraria.Size = new System.Drawing.Size(100, 20);
            this.tTarifahoraria.TabIndex = 8;
            // 
            // tHorastrabajadaspordia
            // 
            this.tHorastrabajadaspordia.Location = new System.Drawing.Point(264, 208);
            this.tHorastrabajadaspordia.Name = "tHorastrabajadaspordia";
            this.tHorastrabajadaspordia.Size = new System.Drawing.Size(100, 20);
            this.tHorastrabajadaspordia.TabIndex = 9;
            // 
            // tDiastrabajadospormes
            // 
            this.tDiastrabajadospormes.Location = new System.Drawing.Point(264, 253);
            this.tDiastrabajadospormes.Name = "tDiastrabajadospormes";
            this.tDiastrabajadospormes.Size = new System.Drawing.Size(100, 20);
            this.tDiastrabajadospormes.TabIndex = 10;
            // 
            // bSalario
            // 
            this.bSalario.Location = new System.Drawing.Point(586, 181);
            this.bSalario.Name = "bSalario";
            this.bSalario.Size = new System.Drawing.Size(75, 23);
            this.bSalario.TabIndex = 11;
            this.bSalario.Text = "Salario";
            this.bSalario.UseVisualStyleBackColor = true;
            this.bSalario.Click += new System.EventHandler(this.bSalario_Click);
            // 
            // fSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSalario);
            this.Controls.Add(this.tDiastrabajadospormes);
            this.Controls.Add(this.tHorastrabajadaspordia);
            this.Controls.Add(this.tTarifahoraria);
            this.Controls.Add(this.tAñodeingreso);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lDiastrabajadospormes);
            this.Controls.Add(this.lTarifahoraria);
            this.Controls.Add(this.lHorastrabajadaspordia);
            this.Controls.Add(this.lAñoingreso);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.bCerrar);
            this.Name = "fSalario";
            this.Text = "Salario";
            this.Load += new System.EventHandler(this.fSalario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lAñoingreso;
        private System.Windows.Forms.Label lHorastrabajadaspordia;
        private System.Windows.Forms.Label lTarifahoraria;
        private System.Windows.Forms.Label lDiastrabajadospormes;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tAñodeingreso;
        private System.Windows.Forms.TextBox tTarifahoraria;
        private System.Windows.Forms.TextBox tHorastrabajadaspordia;
        private System.Windows.Forms.TextBox tDiastrabajadospormes;
        private System.Windows.Forms.Button bSalario;
    }
}

