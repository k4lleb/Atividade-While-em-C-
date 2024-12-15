using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosWhile
{
    internal class Calculadora
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação (+, -, *, /) ou digite 'sair' para encerrar.");

            string operacao = "";

            while (operacao != "sair")
            {
                Console.WriteLine("\n Digite uma operação: ");
                operacao = Console.ReadLine().ToLower();

                while (operacao == "+")
                {
                    Console.WriteLine("Digite um número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"O resultado de {numero1} + {numero2} é: {numero1 + numero2}");
                    operacao = "";
                }

                while (operacao == "-")
                {
                    Console.WriteLine("Digite um número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"O resultado de {numero1} - {numero2} é: {numero1 - numero2}");
                    operacao = "";
                }

                while (operacao == "*")
                {
                    Console.WriteLine("Digite um número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"O resultado de {numero1} x {numero2} é: {numero1 * numero2}");
                    operacao = "";
                }

                while (operacao == "/")
                {
                    Console.Write("Digite o primeiro número: ");
                    double numero1 = double.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double numero2 = double.Parse(Console.ReadLine());

                    while (numero2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        Console.Write("Digite um número diferente de zero: ");
                        numero2 = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine($"O resultado de {numero1} / {numero2} é: {numero1 / numero2}");
                    operacao = ""; // Reseta para sair deste laço interno
                }

                while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/" && operacao != "sair")
                {
                    Console.WriteLine("Operação inválida! Escolha entre +, -, *, / ou digite 'sair' para encerrar.");
                    Console.Write("Digite a operação: ");
                    operacao = Console.ReadLine().ToLower();
                }
            }

            Console.WriteLine("Programa encerrado. Obrigado por usar a calculadora!");
        }
    }
}
