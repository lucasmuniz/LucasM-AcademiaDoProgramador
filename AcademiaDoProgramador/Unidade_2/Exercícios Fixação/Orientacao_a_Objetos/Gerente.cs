namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class Gerente
    {
        public string nome;
        public double salario;

        public void AumentoSalario()
        {
            this.AumentoSalario(0.1);
            
        }

        public void AumentoSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}