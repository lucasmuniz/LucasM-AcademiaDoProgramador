using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaValorPadrao
    {
        public static void Main4(string[] args)
        {
            ContaEAgencia c = new ContaEAgencia();

            Console.WriteLine("Número: {0}",c.numero);
            Console.WriteLine("Saldo: {0}",c.saldo);
            Console.WriteLine("Limite: {0}",c.limite);

            Console.ReadKey();
        }
    }
}