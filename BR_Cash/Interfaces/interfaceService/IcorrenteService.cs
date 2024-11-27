using BR_Cash.estidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Interfaces.interfaceService
{
    public interface IcorrenteService
    {
        void Adicionar(Conta_Corrente carro);


        void Remover(int id);



        List<Conta_Corrente> Listar();

        List<Conta_Corrente> Listar(int id);

        Conta_Corrente BuscarContaPorId(int id);

    }
} 
