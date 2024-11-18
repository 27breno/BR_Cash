using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.estidades
{
    public class Conta_Corrente : Conta
    {
        public double LimiteDeCredito { get; set; }


        public virtual bool Sacar(double valor)
        {
            if (valor <= 0)
                return false; 

            if (Saldo + LimiteDeCredito >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
