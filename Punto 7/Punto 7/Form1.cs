using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_7
{
    public partial class fDigitos : Form
    {
        public fDigitos()
        {
            InitializeComponent();
        }

        private void lIngresenumero_Click(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tIngresenumero.Text);
            int digito1 = numero/10;
            int digito2 = numero % 10;
            int suma = digito1 + digito2;

            MessageBox.Show("La suma de los digitos es "+suma);
        }
    }
}
