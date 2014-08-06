namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class ContaEAgencia
    {
        public int numero;
        public double saldo;

        public Agencia agencia;
        public double limite = 100;

        public static void Main1(string[] args)
        {
            ContaEAgencia c = new ContaEAgencia();
            c.Deposita(100);
            c.ImprimeExtrato();
            c.Saca(50);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            System.Console.WriteLine("Seu saldo é: {0}",saldoDisponivel);
            System.Console.ReadKey();
        }

        private void Deposita(double valor)
        {
            this.saldo += valor;
        }

        private void Saca(double valor)
        {
            this.saldo -= valor;
        }

        private void ImprimeExtrato()
        {
            System.Console.WriteLine("Saldo: {0}", this.saldo);
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}