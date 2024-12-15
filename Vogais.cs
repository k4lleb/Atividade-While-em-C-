using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class Vogais
    {
        public static void Main(string[] args)
        {
            string palavra;

            Console.WriteLine("Digite uma palavra (ou 'fim' para encerrar):");

            while (true)
            {
                palavra = Console.ReadLine();

                if (palavra.ToLower() == "fim")
                {
                    break;
                }

                int contagemVogais = 0;
                foreach (char c in palavra.ToLower())
                {
                    if ("aeiou".Contains(c))
                    {
                        contagemVogais++;
                    }
                }

                Console.WriteLine($"A quantidade de vogais na palavra '{palavra}' é: {contagemVogais}");
                Console.WriteLine("Digite outra palavra (ou 'fim' para encerrar):");
            }
        }
    }
}
