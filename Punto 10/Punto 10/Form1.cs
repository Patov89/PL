using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_10
{
    public partial class fSalario : Form
    {
        public fSalario()
        {
            InitializeComponent();
        }

        private void fSalario_Load(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void bSalario_Click(object sender, EventArgs e)
        {
            //Ingresamos los datos.
            string nombre = tNombre.Text;
            double ingreso = Convert.ToDouble(tAñodeingreso.Text);
            double tarifa = Convert.ToDouble(tTarifahoraria.Text);
            double horas = Convert.ToDouble(tHorastrabajadaspordia .Text);
            double dias = Convert.ToDouble(tDiastrabajadospormes .Text);
            double añoactual = 2023;

            //Calculamos.
            double salariobruto = (tarifa * horas * dias);
            double retencion = (salariobruto * 0.2);
            double antiguedad = (salariobruto * ((añoactual - ingreso) * 0.015));
            double salariototal = (salariobruto + antiguedad - retencion);

            //Mostramos resultados.
            MessageBox.Show("El salario de " + nombre + " es: $ " + salariototal);
           
        }
    }
}
