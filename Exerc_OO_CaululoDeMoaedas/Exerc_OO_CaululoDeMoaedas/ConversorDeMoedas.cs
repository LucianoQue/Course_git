using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_OO_CaululoDeMoaedas
{
    class ConversorDeMoedas
    {
        public static double IOF = 6.00;

        public static double DolarParaReal(double cot, double qt)
        {
            double total = cot * qt;
            return total + total * IOF / 100;
        }
     
    }
}
