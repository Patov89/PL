using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_8
{
    public partial class fIntercambio : Form
    {
        public fIntercambio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            string numeroA = tNumeroA.Text;
            string numeroB = tNumeroB.Text;
            string aux;

            aux = numeroA;
            numeroA = numeroB;
            numeroB = aux;

            MessageBox.Show("Numero A: " + numeroA + " Numero B: " + numeroB);


        }
    }
}
