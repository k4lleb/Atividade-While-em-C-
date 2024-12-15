using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class PotenciaDe2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado = numero;
            int potencia = 0;

            while (resultado <= 1000)
            {
                Console.WriteLine($"Resultado da multiplicação por 2^{potencia} : {resultado}");
                resultado *= 2;
                potencia++;
            }

            Console.WriteLine("O resultado ultrapassou 1000.");
        }
    }
}
