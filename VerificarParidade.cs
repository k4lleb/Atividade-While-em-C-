using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class VerificarParidade
    {
        public static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número:");

            numero = int.Parse(Console.ReadLine());

            while (numero % 2 != 0)
            {
                Console.WriteLine("Número ímpar! Digite novamente:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número par digitado! Sucesso.");
        }
    }
}
