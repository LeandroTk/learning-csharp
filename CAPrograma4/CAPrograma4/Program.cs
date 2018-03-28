using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPrograma4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite capacidade do elevador: ");
            string s = Console.ReadLine();
            double capacidade = double.Parse(s);

            Console.WriteLine("Digite capacidade a ser transportada: ");
            s = Console.ReadLine();
            double carga = double.Parse(s);

            double viagens = carga / capacidade;
            int numeroDeViagens = (int)(viagens);

            if (viagens > numeroDeViagens)
            {
                numeroDeViagens++;
            }

            Console.WriteLine("Viagens necessárias: " + numeroDeViagens.ToString());
            Console.ReadKey();
        }
    }
}
