namespace darabank.banco.modelo

{
    public class ContaPoupanca : Conta, Tributavel
    {
        public ContaPoupanca(int agencia, int numeroDaConta) : base(agencia, numeroDaConta)
        { }

        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Conta Poupanca, " + base.ToString();
        }

        public double ValorImposto()
        {
            throw new System.NotImplementedException();
        }
    }
}
