using System;
using System.Globalization;
namespace EXERC_OO_Classes_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario!");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Sarlário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario do funcionario? ");
            Console.WriteLine("S para Sim e N para não!");
            string sn = Console.ReadLine();

            if (sn != "s" && sn != "S")
            {
                Console.WriteLine("Funcionario: " + f);
            }
            else
            {
                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                f.AumentoSalario(aumento);
                Console.WriteLine("Dados atualizados: " + f);
            }
            

            
        }
    }
}
