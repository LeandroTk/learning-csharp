using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void soma()
        {
            float valor1, valor2, resultado;

            try
            {
                valor1 = float.Parse(textBox1.Text);
                valor2 = float.Parse(textBox2.Text);
                resultado = valor1 + valor2;
                label1.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                label1.Text = "";
                label1.Text = caught.Message;
            }
        }

        private void subtracao()
        {
            float valor1, valor2, resultado;

            try
            {
                valor1 = float.Parse(textBox1.Text);
                valor2 = float.Parse(textBox2.Text);
                resultado = valor1 - valor2;
                label1.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                label1.Text = "";
                label1.Text = caught.Message;
            }
        }

        private void vezes()
        {
            float valor1, valor2, resultado;

            try
            {
                valor1 = float.Parse(textBox1.Text);
                valor2 = float.Parse(textBox2.Text);
                resultado = valor1 * valor2;
                label1.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                label1.Text = "";
                label1.Text = caught.Message;
            }
        }

        private void divisao()
        {
            float valor1, valor2, resultado;

            try
            {
                valor1 = float.Parse(textBox1.Text);
                valor2 = float.Parse(textBox2.Text);
                resultado = valor1 / valor2;
                label1.Text = resultado.ToString();
            }
            catch (Exception caught)
            {
                label1.Text = "";
                label1.Text = caught.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soma();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            subtracao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vezes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            divisao();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != 13 && e.KeyChar != 8)
            {
                MessageBox.Show("Tecla Inválida");
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar != 13 && e.KeyChar != 8 && e.KeyChar != (char)43 && e.KeyChar != (char)45 && e.KeyChar != (char)42 && e.KeyChar != (char)47)
            {
                MessageBox.Show("Tecla Inválida");
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == 13)
            {
                soma();
            }
            else if (e.KeyChar == (char)43)
            {
                soma();
            }
            else if (e.KeyChar == (char)45)
            {
                subtracao();
            }
            else if (e.KeyChar == (char)42)
            {
                vezes();
            }
            else if (e.KeyChar == (char)47)
            {
                divisao();
            }
        }
    }
}
