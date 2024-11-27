using BR_Cash.estidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Interfaces.interfaceService
{
    public interface IpoupancaService
    {
        void Adicionar(Conta_Poupanca pou);


        void Remover(int id);

        List<Conta_Poupanca> Listar();


        List<Conta_Poupanca> Listar(int id);

        Conta_Poupanca BuscarContaPorId(int id);
       
    }
}
