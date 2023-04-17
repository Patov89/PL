using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_3
{
    public partial class fArena : Form
    {
        public fArena()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bArena_Click(object sender, EventArgs e)
        {
            // Ingresamos los datos.
            double ancho = Convert.ToDouble(tAncho.Text);
            double alto = Convert.ToDouble(tAlto.Text);
            double metroscubicos = Convert.ToDouble(tMetroscubicos.Text);

            // Calculamos la cantidad de arena.
            double arena = ancho * alto * metroscubicos;

            //Mostramos los resultados.
            MessageBox.Show($"La cantidad de arena necesaria es {arena} metros cubicos");

        

        }
    }
}
