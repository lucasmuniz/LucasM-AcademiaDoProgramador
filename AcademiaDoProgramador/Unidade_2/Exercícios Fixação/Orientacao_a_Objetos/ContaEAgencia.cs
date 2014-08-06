namespace Unidade_2.Exercícios_Fixação.Orientacao_a_Objetos
{
    internal class ContaEAgencia
    {
        public int numero;
        public double saldo;

        public Agencia agencia;
        public double limite = 100;

        public static void Main(string[] args)
        {
            ContaEAgencia c = new ContaEAgencia();
            c.Deposita(100);
            double saldoDisponivel = c.ConsultaSaldoDisponivel();
            System.Console.WriteLine(saldoDisponivel);
            System.Console.ReadKey();
        }

        private void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }
    }
}