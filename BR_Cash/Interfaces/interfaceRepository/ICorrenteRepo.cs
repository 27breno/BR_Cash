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
    public interface ICorrenteRepo
    {
        long Adicionar(CorrenteDTO cam);


         void Remover(int id);


        List<Conta_Corrente> Listar();

         Conta_Corrente BuscarCorrentePorId(int id);



         Conta_Corrente BuscarPorId(int id);
      
    }
}
