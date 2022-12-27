using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class CorrenteConta
    {
        public CorrenteConta(int numeroconta, decimal saldoInicial)
        {
            NumeroConta = numeroconta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso!!");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que saldo disponível!!");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo disponível é : {saldo}");
        }
    }
}