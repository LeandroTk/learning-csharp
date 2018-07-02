using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circulo c = new Circulo();

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            c.raio = double.Parse(txtRaio.Text);
        }

        private void btnDiametro_Click(object sender, EventArgs e)
        {
            txtResultado.Text = c.diametro().ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            txtResultado.Text = c.area().ToString();
        }

        private void btnCircunferenca_Click(object sender, EventArgs e)
        {
            txtResultado.Text = c.circunferencia().ToString();
        }
    }

    public class Circulo
    {
        public double raio;

        public double diametro()
        {
            return raio * 2;
        }

        public double area()
        {
            return 3.14 * raio * raio;
        }

        public double circunferencia()
        {
            return 3.14 * diametro();
        }
    }
}
