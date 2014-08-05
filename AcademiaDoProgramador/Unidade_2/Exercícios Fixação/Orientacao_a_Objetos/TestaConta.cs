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

            ContaEAgencia c2 = new ContaEAgencia();
            c2.numero = 5678;
            c2.saldo = 2000;
            c2.limite = 250;

            Console.WriteLine(c1.numero);
            Console.WriteLine(c1.saldo);
            Console.WriteLine(c1.limite);

            Console.WriteLine(c2.numero);
            Console.WriteLine(c2.saldo);
            Console.WriteLine(c2.limite);

            Console.ReadKey();
        }
    }
}