using System;
using System.Globalization;
namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o salario: ");
            double salario, imposto;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            imposto = 0;

            if (salario <= 2000.00)
            {
                imposto = 2000.00 * 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = 1000.00 * 0.08 + (salario - 3000.00) * 0.18;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + 1000.00 * 0.08 + 1500.00 * 0.18;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
