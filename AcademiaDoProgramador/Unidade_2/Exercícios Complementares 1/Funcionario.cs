namespace Unidade_2.Exercícios_Complementares
{
    internal class Funcionario
    {
        public string primeiroNome, segundoNome, cargo;
        public double salario;

        public double AumentaSalario()
        {
            return this.salario += 500;
        }

        public void Dados()
        {
            System.Console.WriteLine(this.primeiroNome);
            System.Console.WriteLine(this.segundoNome);
            System.Console.WriteLine(this.cargo);
        }
    }
}