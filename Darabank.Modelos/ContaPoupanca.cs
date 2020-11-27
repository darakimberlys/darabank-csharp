namespace Darabank.Modelos

{
    /// <summary>
    /// Esta classe define uma Conta Poupança no banco.
    /// </summary>
    public class ContaPoupanca : Conta, ITributavel
    {
        /// <summary>
        /// Cria uma instancia de Conta Poupança a selecionar com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Representa o valor da Propriedade <see cref="Agencia"/>, e deve possuir um valor menor que 0. </param>
        /// <param name="numeroDaConta"> Representa o valor da Propriedade <see cref="NumeroDaConta"/>, e deve possuir um valor menor que 0.</param>
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
