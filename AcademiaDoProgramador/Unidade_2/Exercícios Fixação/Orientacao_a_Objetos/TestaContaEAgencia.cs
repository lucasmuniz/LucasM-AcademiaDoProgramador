using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaContaEAgencia
    {
        public static void Main4(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            ContaEAgencia c1 = new ContaEAgencia();
            c1.numero = 123;
            c1.saldo = 2222;
            c1.limite = 500;

            c1.agencia = a1;

            Console.WriteLine("Numero: {0}",c1.numero);
            Console.WriteLine("Saldo: {0}",c1.saldo);
            Console.WriteLine("Saldo: {0}",c1.limite);
            Console.WriteLine("Agência numero {0}",c1.agencia.numero);

            

            Console.ReadKey();
        }
    }
}