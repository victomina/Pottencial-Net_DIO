using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"O meu nome é {Nome}, tenho {Idade} anos, e meu salario é: {Salario}");
        }
    }
}