using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class NumeroDeTentativas
    {
        public static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número entre 1 e 100:");

            numero = int.Parse(Console.ReadLine());

            while (numero < 1 || numero > 100)
            {
                Console.WriteLine("Número inválido! Digite um número entre 1 e 100:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Você digitou um número válido: {numero}");
        }
    }
}