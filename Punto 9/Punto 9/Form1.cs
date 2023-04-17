using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_9
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            //Ingresamos los datos.
            int hora1 = Convert.ToInt32(tHoras1.Text);
            int hora2 = Convert.ToInt32(tHoras2.Text);
            int minuto1 = Convert.ToInt32(tMinutos1.Text);
            int minuto2 = Convert.ToInt32(tMinutos2.Text);
            int segundo1 = Convert.ToInt32(tSegundos1.Text);
            int segundo2 = Convert.ToInt32(tSegundos2.Text);

            //Calculamos.
            int sumatiempos = ((hora1 + hora2)*3600) + ((minuto1 + minuto2) * 60) + segundo1 + segundo2;
            int sumahoras = sumatiempos / 3600;
            int sumaminutos = (sumatiempos % 3600) / 60;
            int sumasegundos = sumatiempos % 60;

            //Mostramos.
            MessageBox.Show("La suma de los tiempo es: " +sumahoras +" horas "+sumaminutos +" minutos "+ sumasegundos +" segundos. ");







        }
    }
}
