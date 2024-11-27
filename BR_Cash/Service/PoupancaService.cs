using BR_Cash.DTO;
using BR_Cash.estidades;
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
    public class PoupancaService : IpoupancaService
    {
        public IConfiguration configuration { get; set; }
        public IPoupancaRepo repository { get; set; }

        public IContaRepo repositoryConta { get; set; }
        public PoupancaService(IConfiguration configu, IPoupancaRepo repositorio, IContaRepo repositoryConta)
        {

            configuration = configu;
            repository = repositorio;
            this.repositoryConta = repositoryConta;
        }
        public void Adicionar(Conta_Poupanca pou)
        {
            Conta conta = new Conta()
            {
                
                Titular = pou.Titular,
                Saldo = pou.Saldo,
            };
            repositoryConta.Adicionar(conta);

            PoupancaDTO poupan = new PoupancaDTO()
            {
                contaId = conta.Id,
                TaxaDeJuros = pou.TaxaDeJuros,
                Titular = pou.Titular,
                Saldo = pou.Saldo

            };
            repository.Adicionar(poupan);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Conta_Poupanca> Listar()
        {
            return repository.Listar();
        }

        public List<Conta_Poupanca> Listar(int id)
        {
            var conta = repositoryConta.BuscarPorId(id);

            if (conta == null)
                return new List<Conta_Poupanca>();

            var poupanca = repository.BuscarPorId(id);

            if (poupanca == null)
                return new List<Conta_Poupanca>();

            return new List<Conta_Poupanca>
            {
                new Conta_Poupanca
                {
                    Id = conta.Id,
                    Titular = conta.Titular,
                    Saldo = conta.Saldo,
                    TaxaDeJuros = poupanca.TaxaDeJuros

                }
            };
        }
        public Conta_Poupanca BuscarContaPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
    }
}
