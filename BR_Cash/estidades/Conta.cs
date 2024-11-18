using BR_Cash.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BR_Cash.estidades
{
    public class Conta : IConta
    {
        public string Titular { get; set; } /*quem é o titular da conta*/
        public double Saldo { get; set; } /*O saldo que se encontra na conta*/

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;

                return true;
            }
            return false;

        }

        public void ExibirInformacoe()
        {
                Console.WriteLine($"Titular da conta: {Titular}," +
                    $"o Saldo disponivel é de: {Saldo}");
        }



        
    }
}
