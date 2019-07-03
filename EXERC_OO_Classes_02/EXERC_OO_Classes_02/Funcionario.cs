using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EXERC_OO_Classes_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double porcentagem)
        {
             SalarioBruto = (porcentagem / 100) * SalarioBruto + SalarioBruto;
        }
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
