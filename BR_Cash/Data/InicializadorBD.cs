using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.Data
{
    public class InicializadorBD
    {
        private const string ConnectionString = "Data Source=BR_Cash.db";

        public static void Inicializador()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string commandoSQL = @"
                    CREATE TABLE IF NOT EXISTS Contas(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titular TEXT NOT NULL,
                        Saldo REAL NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Conta_Correntes(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titular TEXT NOT NULL,
                        Saldo REAL NOT NULL,
                        LimiteDeCredito REAL NOT NULL,
                        ContaId INTERGER NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Conta_Poupancas(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titular TEXT NOT NULL,
                        Saldo REAL NOT NULL,
                        TaxaDeJuros REAL NOT NULL,
                        ContaId INTERGER NOT NULL
                    );
                ";

                connection.Execute(commandoSQL);
            }
        }
    }
}
