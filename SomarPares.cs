using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class SomarPares
    {
        public static void Main(string[] args)
        {
            int numero;
            int somaPares = 0;

            Console.WriteLine("Digite números inteiros (0 para encerrar o programa)");

            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    somaPares += numero;
                }

                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma dos pares que foram digitados é de: {somaPares}");
        }
    }
}
