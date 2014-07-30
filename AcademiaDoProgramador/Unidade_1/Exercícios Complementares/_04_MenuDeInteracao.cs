using System;

namespace Unidade_1.Exercícios_Complementares
{
    internal class _04_MenuDeInteracao
    {
        public static int opc = 1;

        public static void Main4(string[] args)
        {
            //Use seus conhecimentos para criar um programa que mostre um menu de atalho para os 5
            //padrões que acabamos de fazer.

            while (opc != 0)
            {
                Console.WriteLine("1 - Opção A");
                Console.WriteLine("2 - Opção B");
                Console.WriteLine("3 - Opção C");
                Console.WriteLine("4 - Opção D");

                opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 1)
                {
                    Console.WriteLine("Você entrou na opção A");
                }
                if (opc == 2)
                {
                    Console.WriteLine("Você entrou na opção B");
                }
                if (opc == 3)
                {
                    Console.WriteLine("Você entrou na opção C");
                }
                if (opc == 4)
                {
                    Console.WriteLine("Você entrou na opção D");
                }
            }
            Console.ReadKey();
        }
    }
}