using System;
using System.Globalization;

namespace Exec_OO_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas x, y;

            x = new Pessoas();
            y = new Pessoas();

            Console.WriteLine("Insira os dados da primeira pessoa:");
            Console.WriteLine("Nome Completo");
            x.nome = Console.ReadLine();
            Console.WriteLine("Salario");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira os dados da segunda pessoa:");
            Console.WriteLine("Nome completo");
            y.nome = Console.ReadLine();
            Console.WriteLine("Salario");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x.nome + " tem salario = " + x.salario);
            Console.WriteLine(y.nome + " tem salario = " + y.salario);

            double media = (x.salario + y.salario) / 2;

            Console.WriteLine("Salario médio = " + media.ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
