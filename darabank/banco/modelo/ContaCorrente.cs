namespace darabank.banco.modelo

{
    public class ContaCorrente : Conta //implementar metodo
    {
        public ContaCorrente(int agencia, int numeroDaConta) : base(agencia, numeroDaConta)
        {
        }
        public override void Depositar(double valor)
        {
            saldo += valor;
        }

        public override void Sacar(double valor)// verificar exception
        {
            if (saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo: " + this.saldo + ", valor: " + valor);
            }
            double valorASacar = valor + 0.2;
            Sacar(valorASacar);
        }
        //adicionar metodo de imposto 

        public override string ToString()
        {
            return "Conta Corrente, " + base.ToString();
        }
    }
}
