using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_5
{
    public partial class fVuelto : Form
    {
        public fVuelto()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bVuelto_Click(object sender, EventArgs e)
        {
            // Ingresamos los datos.
            string cliente = tCliente.Text;
            double total = Convert.ToDouble(tTotal.Text);
            double pago = Convert.ToDouble(tPago.Text);

            // Calculamos el vuelto.
            double vuelto = pago - total;

            // Mostramos en pantalla.
            MessageBox.Show($"El vuelto a {cliente} es de {vuelto} pesos");

        }
    }
}
