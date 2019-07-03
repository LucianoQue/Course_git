using System;
using System.Globalization;

namespace Exer_60_Conta_Banc
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria();
        
            Console.Write("Entre com os dados da conta: ");
            c.Nconta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o nome do titular da conta: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            string sn = Console.ReadLine();
            if(sn == "s")
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                c.Dinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();
            Console.WriteLine(");
            

            
            


            
        }
    }
}
