using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.DTO
{
    [Table("Conta_Poupancas")]
    public class PoupancaDTO
    {
        public int Id { get; set; }
        public int contaId { get; set; } /*quem é o titular da conta*/
        public double TaxaDeJuros { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
    }
}
