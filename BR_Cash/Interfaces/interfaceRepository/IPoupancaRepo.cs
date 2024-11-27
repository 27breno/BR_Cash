using BR_Cash.DTO;
using BR_Cash.estidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Interfaces.interfaceRepository
{
    public interface IPoupancaRepo
    {
        long Adicionar(PoupancaDTO cam);


         void Remover(int id);
            


         List<Conta_Poupanca> Listar();

        Conta_Poupanca BuscarPoupançaPorId(int Contaid);


         Conta_Poupanca BuscarPorId(int id);

    }
}
