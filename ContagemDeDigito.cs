using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class ContagemDeDigito
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Math.Abs(int.Parse(Console.ReadLine()));

            int contagem = 0;

            while (numero > 0)
            {
                numero /= 10;
                contagem++;
            }

            if (contagem == 0)
            {
                contagem = 1;
            }

            Console.WriteLine($"O número possui {contagem} dígitos.");
        }
    }
}
