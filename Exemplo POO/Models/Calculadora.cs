using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_POO.Interfaces;

namespace Exemplo_POO.Models
{ //não sei o que faz ter esse // erro
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
           return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }   

        public int Somar(int num1,int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = 0;

            if (num1 - num2 < 0)
            {
                 res = num2 - num1;
            }
            return res;
        }
    }
}