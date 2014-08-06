using System;
namespace Unidade_2.Exercícios_Complementares
{
    internal class TestaTurma
    {
        public static void Main1(string[] args)
        {
            Turma t1 = new Turma();
            t1.periodo = "Noturno";
            t1.serie="Terceira";
            t1.sigla="aa444";
            t1.tipoDeEnsino="Distancia";


            Aluno a1 = new Aluno();
            a1.primeiroNome = "Camila";
            a1.segundoNome = "Silva";
            a1.rgAluno = 1222220393;
            a1.dataNascimento = "12/12/12";


            //agrupamento
            a1.turma = t1;

            


            Console.WriteLine(a1.primeiroNome);
            Console.WriteLine(a1.segundoNome);
            Console.WriteLine(a1.rgAluno);
            Console.WriteLine(a1.dataNascimento);
            Console.WriteLine(a1.turma.serie);
            Console.WriteLine(a1.turma.sigla);
            Console.WriteLine(a1.turma.periodo);
            Console.WriteLine(a1.turma.tipoDeEnsino);

            Console.ReadKey();

        }
    }
}