using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMercadoria
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mercadoria produto1 = new Mercadoria();
        Mercadoria produto2 = new Mercadoria();
        Mercadoria produto3 = new Mercadoria();

        private void ImprimirResultado()
        {
            resultado.Items.Add("Nome produto1: " + produto1.nome);
            resultado.Items.Add("Preço produto1: R$" + produto1.preco + "\n\n");

            resultado.Items.Add("Nome produto2: " + produto2.nome);
            resultado.Items.Add("Preço produto2: R$" + produto2.preco + "\n\n");

            resultado.Items.Add("Nome produto3: " + produto3.nome);
            resultado.Items.Add("Preço produto3: R$" + produto3.preco + "\n\n");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto1.Text = "";
            txtProduto2.Text = "";
            txtProduto3.Text = "";
            txtProdutoValor1.Text = "";
            txtProdutoValor2.Text = "";
            txtProdutoValor3.Text = "";
            resultado.Items.Clear();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            produto1.nome = txtProduto1.Text;
            produto1.preco = double.Parse(txtProdutoValor1.Text);
            produto2.nome = txtProduto2.Text;
            produto2.preco = double.Parse(txtProdutoValor2.Text);
            produto3.nome = txtProduto3.Text;
            produto3.preco = double.Parse(txtProdutoValor3.Text);

            ImprimirResultado();
        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            resultado.Items.Clear();
            
            double reajustePorcentagem = double.Parse(txtReajuste.Text);

            produto1.atualizaPreco(reajustePorcentagem);
            produto2.atualizaPreco(reajustePorcentagem);
            produto3.atualizaPreco(reajustePorcentagem);

            ImprimirResultado();
        }
    }

    public class Mercadoria
    {
        public string nome;
        public double preco;

        public void atualizaPreco(double percent)
        {
            preco = preco + (preco * percent / 100);
        }
    }
}
