using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class Tabuada
    {
        public static void Main(string[] args)
        {

            int numero;

            do
            {
                Console.WriteLine("Escolha um número de 1 a 10 para fazer a tabuada");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 10);

            int tabuada = 1;

            Console.WriteLine($"Tabuada do {numero}");

            while (tabuada <= 10)
            {
                int resultado = numero * tabuada;
                Console.WriteLine($"{numero} x {tabuada} = {resultado} ");
                tabuada++;
            } 
        }
    }
}
