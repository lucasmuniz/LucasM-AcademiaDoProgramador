using System;

namespace Unidade_2.Exercícios_Complementares
{
    internal class TestaFuncionario
    {
        public static void Main1(string[] args)
        {
            Funcionario f1 = new Funcionario();
            f1.primeiroNome = "Lucas";
            f1.segundoNome = "Muniz";
            f1.cargo = "Vendedor";
            f1.salario = 1200;
            f1.AumentaSalario();
            f1.Dados();

            Funcionario f2 = new Funcionario();
            f2.primeiroNome = "Luana";
            f2.segundoNome = "Muniz";
            f2.cargo = "Vendedor";
            f2.salario = 1890;

            Console.WriteLine("Nome: {0}",f1.primeiroNome);
            Console.WriteLine(f1.segundoNome);
            Console.WriteLine("Cargo: {0}",f1.cargo);
            Console.WriteLine("Salário: {0}",f1.salario);

            Console.WriteLine(f2.primeiroNome);
            Console.WriteLine(f2.segundoNome);
            Console.WriteLine(f2.cargo);
            Console.WriteLine(f2.salario);
            Console.ReadKey();
        }
    }
}