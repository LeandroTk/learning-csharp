using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPrograma2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x, y, z;

            Console.WriteLine("Digite X:");
            s = Console.ReadLine();
            x = int.Parse(s);

            Console.WriteLine("Digite Y:");
            s = Console.ReadLine();
            y = int.Parse(s);

            Console.WriteLine("Adição: " + (x + y));
            Console.WriteLine("Subtração: " + (x - y));
            Console.WriteLine("Multiplicação: " + (x * y));
            Console.WriteLine("Divisão: " + (x / y));

            Console.ReadKey();
        }
    }
}
