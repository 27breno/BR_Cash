using BR_Cash.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.estidades
{
    public class GestaoContas
    {
        List <IConta> conta = new List <IConta> ();

        public void AdicionarContas(Conta contas)
        {
            conta.Add(contas);
        }

        public void ExibaCadastros()
        {
            foreach (var conta in conta)
            {
                conta.ExibirInformacoe();
            }
        }
    }
}
