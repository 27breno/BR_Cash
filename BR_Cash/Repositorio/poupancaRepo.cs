using BR_Cash.DTO;
using BR_Cash.estidades;
using BR_Cash.Interfaces.interfaceRepository;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Repositorio
{
    public class poupancaRepo : IPoupancaRepo
    {
        private readonly string ConnectionString;
        public poupancaRepo(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(PoupancaDTO cam)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<PoupancaDTO>(cam);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Conta_Poupanca cam = BuscarPorId(id);
            connection.Delete<Conta_Poupanca>(cam);
        }

        public List<Conta_Poupanca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Conta_Poupanca>().ToList();
        }
        public Conta_Poupanca BuscarPoupançaPorId(int Contaid)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM Conta_Poupancas  WHERE ContaId = @ContaId";
            return connection.QueryFirstOrDefault<Conta_Poupanca>(query, new { ContaId = Contaid });
        }

        public Conta_Poupanca BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Conta_Poupanca>(id);
        }
    }
}
