using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.estidades
{
    public class Conta_Poupanca : Conta
    {
        public double TaxaDeJuros { get; set; }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor; 
                Saldo += Saldo * (TaxaDeJuros / 100);  
            }
        }
    }
}
