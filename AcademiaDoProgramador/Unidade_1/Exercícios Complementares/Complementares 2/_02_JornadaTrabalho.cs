using System;

namespace Unidade_1.Exercícios_Complementares.Complementares_2
{
    internal class _02_JornadaTrabalho
    {
        public static void Main2(string[] args)
        {
            /*2)A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar
             mais de 40 horas receberá hora extra, cujo cálculo é o valor da hora regular com um acréscimo de 50%.
             Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o
             salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas
             (considere que o mês possua 4 semanas exatas). */

            double horasTrabalhadas, salarioPorHora, salarioTotal, valorExtra, horasExtra;
            Console.Write("Quantas horas foram trabalhadas? ");
            horasTrabalhadas = Convert.ToInt16(Console.ReadLine());

            Console.Write("Qual o salario por hora? ");
            salarioPorHora = Convert.ToInt16(Console.ReadLine());

            valorExtra = salarioPorHora + (salarioPorHora * 0.5);

            Console.Write("Quantas horas extras foram trabalhadas? ");
            horasExtra = Convert.ToInt16(Console.ReadLine());

            salarioTotal = (horasTrabalhadas * salarioPorHora) + (horasExtra * valorExtra);
            Console.WriteLine("O salario total do funcionário é: {0}", salarioTotal);
            Console.ReadKey();
        }
    }
}