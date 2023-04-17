using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_6
{
    public partial class fCapacidad : Form
    {
        public fCapacidad()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPorcentaje_Click(object sender, EventArgs e)
        {
            // Ingresamos los datos.
            int cupo = Convert.ToInt32(tCupototal.Text);
            int cantidad = Convert.ToInt32(tCantidadpersonas.Text);

            // Calculamos.
            double porcentaje = (cantidad * 100) / cupo;

            // Mostramos el resultado.
            MessageBox.Show($"El porcentaje de ocupacion es de: {porcentaje} %");

        }

        private void bIngresopersona_Click(object sender, EventArgs e)
        {
            // Incrementamos de a 1.
            int cantidad = Convert.ToInt32(tCantidadpersonas.Text);
            cantidad++;
            MessageBox.Show($"Ingreso registrado. Cantidad de personas actualmente: {cantidad}");
            

            
        }

        private void bEgresopersona_Click(object sender, EventArgs e)
        {
            // Decrementamos de a 1.
            int cantidad = Convert.ToInt32(tCantidadpersonas.Text);
            cantidad--;
            MessageBox.Show($"Egreso registrado. Cantidad de personas actualmente: {cantidad}");

        }
    }
}
