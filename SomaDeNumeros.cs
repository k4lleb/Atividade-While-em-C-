using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class SomaDeNumeros
    {
        public static void Main(string[] args)
        {
            int numero;
            int soma = 0;
            
            Console.WriteLine("Digite números e ao sair irá somar todos que você digitou (0 para encerrar)");

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            } while (numero != 0);

            Console.WriteLine($"A soma dos números digitados é de: {soma}");
        }
    }
}
