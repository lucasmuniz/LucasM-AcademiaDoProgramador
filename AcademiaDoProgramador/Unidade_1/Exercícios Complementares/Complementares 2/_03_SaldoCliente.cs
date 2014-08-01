using System;

namespace Unidade_1.Exercícios_Complementares.Complementares_2
{
    internal class _03_SaldoCliente
    {
        public static void Main(string[] args)
        {
            /*3)	Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever
             * o saldo atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior ou igual a
             * zero escrever a mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'. */

            int numeroContaCliente;
            double saldo, debito, credito, saldoAtual;
            Console.Write("Digite número da conta: ");
            numeroContaCliente = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o saldo da conta: ");
            saldo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o débito da conta: ");
            debito = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o crédito da conta: ");
            credito = Convert.ToInt32(Console.ReadLine());
            saldoAtual = saldo - debito + credito;
            Console.WriteLine("\n");
            Console.WriteLine("==== RESULTADO ====\n");
            Console.WriteLine("Saldo atual: {0}", saldoAtual);
            if (saldoAtual > 0)
            {
                Console.WriteLine("Saldo Positivo!!");
            }
            else
            {
                Console.WriteLine("Saldo Negativo!");
            }
            Console.ReadKey();
        }
    }
}