using System;
namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class TestaGerente
    {
        public static void Main(string[] args)
        {
            Gerente g1 = new Gerente();
            g1.nome = "Lucas";
            g1.salario = 10000;
            Console.WriteLine("Salário antigo: {0}",g1.salario);
            g1.AumentoSalario();
            Console.WriteLine("Salário novo: {0}",g1.salario);

            Console.ReadKey();
          
        }
    }
}