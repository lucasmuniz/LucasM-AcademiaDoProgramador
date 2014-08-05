using System;
namespace Unidade_2.Exercícios_Complementares
{
    internal class TestaAluno
    {
        public static void Main1(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.primeiroNome = "Jose";
            a1.segundoNome = "Magrao";
            a1.rgAluno = 01204940495;
            a1.dataNascimento = "11/11/11";

            Aluno a2 = new Aluno();
            a2.primeiroNome = "Lucas";
            a2.segundoNome = "Muniz";
            a2.rgAluno = 0123938485;
            a2.dataNascimento = "23/12/90";

            Console.WriteLine(a1.primeiroNome);
            Console.WriteLine(a1.segundoNome);
            Console.WriteLine(a1.rgAluno);
            Console.WriteLine(a1.dataNascimento);

            Console.WriteLine(a2.primeiroNome);
            Console.WriteLine(a2.segundoNome);
            Console.WriteLine(a2.rgAluno);
            Console.WriteLine(a2.dataNascimento);

            Console.ReadKey();
        }
    }
}