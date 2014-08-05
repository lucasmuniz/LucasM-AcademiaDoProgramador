using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaValorPadrao
    {
        public static void Main4(string[] args)
        {
            ContaEAgencia c = new ContaEAgencia();

            Console.WriteLine(c.numero);
            Console.WriteLine(c.saldo);
            Console.WriteLine(c.limite);

            Console.ReadKey();
        }
    }
}