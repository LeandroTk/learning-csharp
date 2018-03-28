using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPrograma5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite capacidade do elevador: ");
            string s = Console.ReadLine();
            double capacidade = double.Parse(s);

            Console.WriteLine("Digite o número de pessoa: ");
            s = Console.ReadLine();
            int numeroDePessoas = int.Parse(s);

            Console.WriteLine("Digite o peso das pessoas: ");
            s = Console.ReadLine();
            double peso = double.Parse(s);

            int pessoasPorViagem = (int)(capacidade / peso);
            int viagens = numeroDePessoas / pessoasPorViagem;
            
            if (numeroDePessoas % pessoasPorViagem > 0)
            {
                viagens++;
            }

            Console.WriteLine("Viagens necessárias: " + viagens.ToString());
            Console.ReadKey();
        }
    }
}
