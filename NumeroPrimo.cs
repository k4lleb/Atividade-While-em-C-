using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class NumeroPrimo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se é primo ou não");
            int numero = int.Parse(Console.ReadLine());

            int divisor = 2;
            bool ehPrimo = true;

            while (divisor <= numero / 2 && ehPrimo)
            {
                ehPrimo = numero % divisor != 0;
                divisor++;
            }

            Console.WriteLine(ehPrimo ? $"O número {numero} é primo." : $"O número {numero} não é primo.");
        }
    }
}
