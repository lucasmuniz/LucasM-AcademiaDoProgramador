using System;

namespace Unidade_1.Exercícios_Complementares.Complementares_2
{
    internal class _04_EstoqueProdutos
    {
        public static void Main4(string[] args)
        {
            /*4)	Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque
             * e quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média
             * ((quantidade média = quantidade máxima + quantidade mínima) /2). Se a quantidade em estoque
             * for maior ou igual a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever
             * a mensagem 'Efetuar compra'. */

            double quantidadeAtualEstoque, quantidadeMaximaEstoque, quantidadeMinimaEstoque, quantidadeMedia;
            Console.Write("Digite a quantidade atual em estoque: ");
            quantidadeAtualEstoque = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade Maximo em estoque: ");
            quantidadeMaximaEstoque = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade Minima em estoque: ");
            quantidadeMinimaEstoque = Convert.ToDouble(Console.ReadLine());

            quantidadeMedia = ((quantidadeMaximaEstoque + quantidadeMinimaEstoque) / 2);

            Console.WriteLine("\n\n");
            Console.WriteLine("==== RESULTADO ====\n");
            if (quantidadeAtualEstoque >= quantidadeMedia)
            {
                Console.WriteLine("NÃO EFETUAR COMPRA");
            }
            else
            {
                Console.WriteLine("EFETUAR COMPRA");
            }
            Console.ReadKey();
        }
    }
}