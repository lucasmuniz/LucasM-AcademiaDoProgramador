using System;

namespace Unidade_1.Exercícios_Complementares.Complementares_2
{
    internal class _05_PrecoCombustivel
    {
        public static void Main5(string[] args)
        {
            /*  Um posto está vendendo combustíveis com a seguinte tabela de descontos:
                Álcool 	até 20 litros, desconto de 3% por litro:
		        Acima de 20 litros, desconto de 5% por litro.

                Gasolina até 20 litros, desconto de 4% por litro:
		        Acima de 20 litros, desconto de 6% por litro.

                Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível
               (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
               sabendo-se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90. */
            string tipoCombustivel;
            double descontoCombustivel, precoFinal, litrosAbastecidos, preco;

            Console.WriteLine("Digite o tipo do combustivel:");
            Console.WriteLine("G - Gasolina");
            Console.WriteLine("A - Álcool\n");
            Console.Write("Opção: ");

            tipoCombustivel = Console.ReadLine();
            if (tipoCombustivel == "G")
            {
                Console.Write("Digite a quantidade de litros abastecido: ");
                litrosAbastecidos = Convert.ToDouble(Console.ReadLine());
                if (litrosAbastecidos <= 20)
                {
                    preco = litrosAbastecidos * 3.30;
                    descontoCombustivel = preco * 0.04;
                    precoFinal = preco - descontoCombustivel;
                    Console.WriteLine("\n");
                    Console.WriteLine("Valor sem desconto: R${0}", preco);
                    Console.WriteLine("Valor com desconto: R${0}", precoFinal);
                }
                else if (litrosAbastecidos > 20)
                {
                    preco = litrosAbastecidos * 3.30;
                    descontoCombustivel = preco * 0.06;
                    precoFinal = preco - descontoCombustivel;
                    Console.WriteLine("\n");
                    Console.WriteLine("Valor sem desconto: R${0}", preco);
                    Console.WriteLine("Valor com desconto: R${0}", precoFinal);
                }
            }
            if (tipoCombustivel == "A")
            {
                Console.Write("Digite a quantidade de litros abastecido: ");
                litrosAbastecidos = Convert.ToDouble(Console.ReadLine());
                if (litrosAbastecidos <= 20)
                {
                    preco = litrosAbastecidos * 2.90;
                    descontoCombustivel = preco * 0.03;
                    precoFinal = preco - descontoCombustivel;
                    Console.WriteLine("\n");
                    Console.WriteLine("Valor sem desconto: R${0}", preco);
                    Console.WriteLine("Valor com desconto: R${0}", precoFinal);
                }
                else if (litrosAbastecidos > 20)
                {
                    preco = litrosAbastecidos * 2.90;
                    descontoCombustivel = preco * 0.05;
                    precoFinal = preco - descontoCombustivel;
                    Console.WriteLine("\n");
                    Console.WriteLine("Valor sem desconto: R${0}", preco);
                    Console.WriteLine("Valor com desconto: R${0}", precoFinal);
                }
            }
            Console.ReadKey();
        }
    }
}