using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class ParImpar
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um número");
                numero = int.Parse(Console.ReadLine());
            } while (numero % 2 != 0);

            Console.WriteLine("Você digitou um número par, programa encerrado");
        }
    }
}
