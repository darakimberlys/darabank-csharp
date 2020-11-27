namespace Darabank.Modelos

{
    /// <summary>
    /// Esta classe define uma Conta Corrente no banco.
    /// </summary>

    public class ContaCorrente : Conta, ITributavel 
    {
        /// <summary>
        /// Cria uma instancia de Conta Corrente a selecionar com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/>, e deve possuir um valor menor que 0. </param>
        /// <param name="numeroDaConta">Representa o valor da propriedade <see cref="NumeroDaConta"/>, e deve possuir um valor menor que 0. </param>
        public ContaCorrente(int agencia, int numeroDaConta) : base(agencia, numeroDaConta)
        { }
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <param name="valor">Representa o valor do Saque, deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
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
