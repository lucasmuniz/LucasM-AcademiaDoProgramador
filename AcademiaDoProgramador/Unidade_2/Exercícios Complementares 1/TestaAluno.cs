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

            Console.WriteLine("Nome: {0}",a1.primeiroNome);
            Console.WriteLine(a1.segundoNome);
            Console.WriteLine("RG: {0}",a1.rgAluno);
            Console.WriteLine("Data Nascimento {0}",a1.dataNascimento);

            Console.ReadKey();
        }
    }
}