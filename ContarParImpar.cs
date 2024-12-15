using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class ContarParImpar
    {
        public static void Main(string[] args)
        {
            int numero;
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Digite números inteiros (0 para parar o programa)");

            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Você digitou {pares} números pares e {impares} números impares.");
        }
    }
}
