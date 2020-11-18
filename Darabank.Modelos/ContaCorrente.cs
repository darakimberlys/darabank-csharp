namespace Darabank.Modelos

{
    public class ContaCorrente : Conta, ITributavel 
    {
        public ContaCorrente(int agencia, int numeroDaConta) : base(agencia, numeroDaConta)
        { }
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo: " + Saldo + ", valor: " + valor);
            }
            double valorASacar = valor + 0.2;
            Sacar(valorASacar);
        }

        public override string ToString()
        {
            return "Conta Corrente, " + base.ToString();
        }

        public double ValorImposto()
        {
            throw new System.NotImplementedException();
        }
    }
}
