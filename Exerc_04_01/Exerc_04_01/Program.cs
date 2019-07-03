using System;
using System.Globalization;

namespace uri1116
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segungo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} { segungo} { terceiro}");
            }
           
        }
    }
}