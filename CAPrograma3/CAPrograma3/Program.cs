using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPrograma3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, input;
            int age, readjust;
            double salary;

            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Idade: ");
            input = Console.ReadLine();
            age = int.Parse(input);
            Console.Write("Salário: ");
            input = Console.ReadLine();
            salary = double.Parse(input);

            Console.WriteLine("Reajuste (em %)");
            input = Console.ReadLine();
            readjust = int.Parse(input);

            Console.WriteLine("Dados lidos");
            Console.WriteLine("==========");

            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Idade: " + age);
            Console.WriteLine("Salário: " + salary);
            Console.WriteLine("Salário com reajuste: " + (salary + salary * readjust / 100));
            Console.ReadKey();
        }
    }
}
