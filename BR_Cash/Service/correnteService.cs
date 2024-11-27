using BR_Cash.DTO;
using BR_Cash.estidades;
using BR_Cash.interfaces;
using BR_Cash.Interfaces.interfaceRepository;
using BR_Cash.Interfaces.interfaceService;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Service
{
    public class correnteService : IcorrenteService
    {
        public IConfiguration configuration { get; set; }
        public ICorrenteRepo repository { get; set; }
        public IContaRepo repositoryConta { get; set; }
        public correnteService(IConfiguration configu, ICorrenteRepo repositorio, IContaRepo repositorioConta)
        {
            configuration = configu;
            repository = repositorio;
            repositoryConta = repositorioConta; 
        }
        public void Adicionar(Conta_Corrente Corrente)
        {
            Conta conta = new Conta()
            {

                Titular = Corrente.Titular,
                Saldo = Corrente.Saldo,
            };
            repositoryConta.Adicionar(conta); 

            CorrenteDTO car = new CorrenteDTO()
            {
                contaId = conta.Id,
                LimiteDeCredito = Corrente.LimiteDeCredito ,
                Titular= Corrente.Titular,
                Saldo= Corrente.Saldo,
                
            };
            repository.Adicionar(car);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Conta_Corrente> Listar()
        {
            return repository.Listar();
        }

        public List<Conta_Corrente> Listar(int id)
        {
            var conta = repositoryConta.BuscarPorId(id);

            if (conta == null)
                return new List<Conta_Corrente>();

            var corrente = repository.BuscarPorId(id);

            if (corrente == null)
                return new List<Conta_Corrente>();

            return new List<Conta_Corrente>
            {
                new Conta_Corrente
                {
                    Id = conta.Id,
                    Titular = conta.Titular,
                    Saldo = conta.Saldo,
                    LimiteDeCredito = corrente.LimiteDeCredito 
                    
                }
            };
        }

        public Conta_Corrente BuscarContaPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
    }
}
