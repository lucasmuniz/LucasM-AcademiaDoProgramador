using System;

namespace Unidade_2.Exercícios_Complementares
{
    internal class TestaFuncionario
    {
        public static void Main2(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.primeiroNome = "Lucas";
            f1.segundoNome = "Muniz";
            f1.cargo = "Vendedor";

            Funcionario f2 = new Funcionario();
            f2.primeiroNome = "Luana";
            f2.segundoNome = "Muniz";
            f2.cargo = "Vendedor";

            Console.WriteLine(f1.primeiroNome);
            Console.WriteLine(f1.segundoNome);
            Console.WriteLine(f1.cargo);

            Console.WriteLine(f2.primeiroNome);
            Console.WriteLine(f2.segundoNome);
            Console.WriteLine(f2.cargo);

            Console.ReadKey();
        }
    }
}