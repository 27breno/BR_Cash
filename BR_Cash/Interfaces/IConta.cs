using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.interfaces{ 

    internal interface IConta
   {
        void Depositar(double valor);

        bool Sacar(double valor);
      

        void ExibirInformacoe();
        double GetSaldo();
    }

}
