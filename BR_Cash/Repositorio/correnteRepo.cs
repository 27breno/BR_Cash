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
    public class correnteRepo : ICorrenteRepo
    {
        private readonly string ConnectionString;
        public correnteRepo(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public long Adicionar(CorrenteDTO cam)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Insert<CorrenteDTO>(cam);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Conta_Corrente cam = BuscarPorId(id);
            connection.Delete<Conta_Corrente>(cam);
        }

        public List<Conta_Corrente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Conta_Corrente>().ToList();
        }
        public Conta_Corrente BuscarCorrentePorId(int Contaid)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            string query = "SELECT * FROM Conta_Correntes  WHERE ContaId = @ContaId";
           return connection.QueryFirstOrDefault<Conta_Corrente>(query, new { ContaId = Contaid });
        }

        public Conta_Corrente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Conta_Corrente>(id);
        }
    }
}
