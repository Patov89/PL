using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_2
{
    public partial class fTiempo : Form
    {
        public fTiempo()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bTiempo_Click(object sender, EventArgs e)
        {
            //Tomamos los datos de ingreso.
            string destino = tDestino.Text;
            double distancia = Convert.ToDouble(tDistancia.Text);
            double velocidad = Convert.ToDouble(tVelocidad.Text);

            //Calculamos el tiempo.
            double tiempo = distancia / velocidad;

            //Mostramos el resultado.
            MessageBox.Show($"El tiempo para llegar a {destino} es de {tiempo} horas.");


        
        
        }
    }
}
