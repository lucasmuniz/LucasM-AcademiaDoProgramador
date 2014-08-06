using System;

namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaCartaoDeCredito
    {
        private static void Main2(string[] args)
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito();
            cdc1.numero = 12345678;
            cdc1.dataDeValidade = "12/17";

            CartaoDeCredito cdc2 = new CartaoDeCredito();
            cdc2.numero = 987654434;
            cdc2.dataDeValidade = "12/18";

            Cliente c = new Cliente();
            c.codigo = 21321;
            c.nome = "Lucas Muniz";

            cdc1.cliente = c;

            Console.WriteLine("Número do cartão: {0}",cdc1.numero);
            Console.WriteLine("Data de validade: {0}",cdc1.dataDeValidade);

            Console.WriteLine("Número do cartão: {0}",cdc2.numero);
            Console.WriteLine("Data de validade: {0}",cdc2.dataDeValidade);

            Console.WriteLine("Nome do cliente: {0}",cdc1.cliente.nome);
            Console.WriteLine("Código do cliente: {0}",cdc1.cliente.codigo);
            Console.ReadKey();
        }
    }
}