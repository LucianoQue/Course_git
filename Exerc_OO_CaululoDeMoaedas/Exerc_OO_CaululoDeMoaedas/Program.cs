using System;
using System.Globalization;
namespace Exerc_OO_CaululoDeMoaedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o valor da cotação do dolar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.Write("Quantos dolares deseja comprar? ");
            double qt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.DolarParaReal(cot, qt).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
