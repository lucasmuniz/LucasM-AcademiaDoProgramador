using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaCartaoDeCredito
    {
        private static void Main()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 12345678;
            cdc1.dataDeValidade = "12/17";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 987654434;
            cdc2.dataDeValidade = "12/18";

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);

            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);
            Console.ReadKey();
        }
    }
}