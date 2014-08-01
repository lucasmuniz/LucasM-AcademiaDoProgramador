using System;

namespace Unidade_1.Exercícios_Complementares.Complementares_2
{
    internal class _01_JogoXadrez
    {
        public static void Main1(string[] args)
        {
            /*1)Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos)
                e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o
                jogo pode iniciar em um dia e terminar no dia seguinte.*/

            int horaInicio, fimDeJogo, tempoDeJogo;

            Console.WriteLine("Digite a hora de início do jogo de xadrez: ");
            horaInicio = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite a hora de fim de jogo: ");
            fimDeJogo = Convert.ToInt16(Console.ReadLine());

            if (horaInicio >= fimDeJogo)
            {
                tempoDeJogo = 24;
                tempoDeJogo = tempoDeJogo - (horaInicio - fimDeJogo);
            }
            else
            {
                tempoDeJogo = fimDeJogo - horaInicio;
            }
            Console.WriteLine("Tempo de jogo: {0}", tempoDeJogo);
            Console.ReadKey();
        }
    }
}