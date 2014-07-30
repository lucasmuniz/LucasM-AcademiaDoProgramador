using System;

namespace Unidade_1.Exercícios_Complementares
{
    internal class _02_TriangulosVarios
    {
        public static void Main2(string[] args)
        {
            // Crie um programa que imprima na tela vários triângulos de “*”.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
                Console.WriteLine("**");
                Console.WriteLine("***");
                Console.WriteLine("****");
                Console.WriteLine("*****");
            }
            Console.ReadKey();
        }
    }
}