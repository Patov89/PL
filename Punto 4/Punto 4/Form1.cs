using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_4
{
    public partial class fGigabyte : Form
    {
        public fGigabyte()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bConvertir_Click(object sender, EventArgs e)
        {
            // Ingresamos los datos.
            string nombre = tNombre.Text;
            double tamaño = Convert.ToDouble(tTamaño.Text);

            // Calculamos
            double gigabyte = tamaño / 1024;

            // Mostramos resultados.
            MessageBox.Show($"El archivo {nombre} tiene un tamaño de {gigabyte} gigabytes");

        }
    }
}
