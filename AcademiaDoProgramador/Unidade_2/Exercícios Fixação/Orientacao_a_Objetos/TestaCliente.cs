using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaCliente
    {
        private static void Main1(string[]args)
        {
            Cliente c1 = new Cliente();
            c1.nome = "Lucas Muniz";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Thiago Sartor";
            c2.codigo = 2;

            Console.WriteLine(c1.nome);
            Console.WriteLine(c1.codigo);

            Console.WriteLine(c2.nome);
            Console.WriteLine(c2.codigo);

            Console.ReadKey();
        }
    }
}