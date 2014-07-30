using System;

namespace Unidade_1.Exercícios_Complementares
{
    internal class _01_TrianguloAsterisco
    {
        public static void Main(string[] args)
        {
            // Crie umprograma que imprima na tela um triângulo de “*”.

            //Primeiro modo de fazer
            Console.WriteLine("    *   ");
            Console.WriteLine("   ***  ");
            Console.WriteLine("  *****  ");
            Console.WriteLine(" ******* ");
            Console.WriteLine("*********");
            Console.ReadKey();

            //Segundo modo de fazer
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadKey();
        }
    }
}