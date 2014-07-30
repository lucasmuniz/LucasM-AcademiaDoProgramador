using System;

namespace Unidade_1.Exercícios_Complementares
{
    internal class _03_SequenciaDeFibonacci
    {
        public static int primeiro = 0, segundo = 1, resultado;

        public static void Main3(string[] args)
        {
            //  Os números de Fibonacci são uma sequência de números definida recursivamente. O primeiro elemento da sequência
            //é 0 e o segundo é 1. Os outros elementos são calculados somando os dois antecessores.
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233...
            Console.WriteLine(primeiro);
            Console.WriteLine(segundo);
            for (int i = 0; i < 15; i++)
            {
                resultado = primeiro + segundo;
                Console.WriteLine(resultado);
                primeiro = segundo;
                segundo = resultado;
            }
            Console.ReadKey();
        }
    }
}