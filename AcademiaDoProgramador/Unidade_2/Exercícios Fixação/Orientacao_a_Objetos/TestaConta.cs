using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaConta
    {
        public static void Main3(string[] args)
        {
            ContaEAgencia c1 = new ContaEAgencia();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            Console.WriteLine("Número da conta: {0}", c1.numero);
            Console.WriteLine("Saldo: {0}",c1.saldo);
            Console.WriteLine("Limite: {0}",c1.limite);

            Console.ReadKey();
        }
    }
}