using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_60_Conta_Banc
{
    class ContaBancaria
    {
        private string _nome;
        public int Nconta { get; set; }
        public double Dinicial { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value; }
                }

        }




        
        

    }
}
