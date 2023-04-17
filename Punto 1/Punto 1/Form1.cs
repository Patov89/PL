using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_1
{
    public partial class fCirculo : Form
    {
        public fCirculo()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            // Tomamos los datos de ingreso.
            string unidad = tUnidad.Text;

            double radio = Convert.ToDouble(tRadio.Text);

            double Pi = 3.141592;

            // Calculamos el perimetro del circulo.
            double perimetro = radio * 2 * Pi;

            // Mostramos el resultado.
            MessageBox.Show($"El perímetro es: {perimetro} {unidad}");
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            // Tomamos los datos de ingreso.
            string unidad = tUnidad.Text;

            double radio = Convert.ToDouble(tRadio.Text);

            double Pi = 3.141592;

            // Calculamos el are del circulo.
            double area = radio * radio * Pi;

            // Mostramos el resultado.
            MessageBox.Show($"El área es: {area} {unidad} al cuadrado");

        }
    }
}
