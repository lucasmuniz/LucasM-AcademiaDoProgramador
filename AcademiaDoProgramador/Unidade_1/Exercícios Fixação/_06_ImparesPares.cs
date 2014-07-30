using System;

namespace Unidade_1.Exercícios_Fixação
{
    internal class _06_ImparesPares
    {
        public static void Main6(string[] args)
        {
            //Faça um programa que percorra todos os números de 1 até 100. Para os números ímpares, deve ser impresso um “*”,
            //e para os números pares, deve ser impresso dois “**”.

            for (int i = 1; i <= 100; i++)
            {
                int resto = i % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
               
            }
            Console.ReadKey();
        }
    }
}