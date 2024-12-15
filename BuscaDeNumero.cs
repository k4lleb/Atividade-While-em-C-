using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class BuscaDeNumero
    {
        public static void Main(string[] args)
        {
            int numeroSecreto = 28;
            int chute = -1;

            Console.WriteLine("Adivinha um número de 1 a 100");

            while (chute != numeroSecreto)
            {
                Console.WriteLine("Digite seu palpite: ");
                chute = int.Parse(Console.ReadLine());

                Console.Clear();

                if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é maior. Tente novamente");
                }
                else if (numeroSecreto > chute)
                {
                    Console.WriteLine("O número é menor. Tente novamente");
                }
            }

            Console.WriteLine($"Parabéns! Você adivinhou que o número secreto era o {numeroSecreto}!");
        }
    }
}
