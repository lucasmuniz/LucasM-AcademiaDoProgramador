using System;

namespace Unidade_1.Exercícios_Fixação
{
    internal class _07_ImprimePI
    {
        public static void Main7(string[] args)
        {   //Faça um programa que percorra todos os números de 1 até 100. Para os números múltiplos de 4,
            //imprima a palavra “PI”, e para os outros, imprima o próprio número.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}