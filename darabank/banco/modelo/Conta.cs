using System;
using System.Threading;

namespace darabank
{
    public abstract class Conta
    {
        private static int total = 0;
        protected double saldo;
        private int agencia;
        private int numeroDaConta;
        private Cliente titular;

        public Conta(int agencia, int numeroDaConta)
        {
            Conta.total++;
            this.agencia = agencia;
            this.numeroDaConta = numeroDaConta;
        }

        public virtual void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo: " + this.saldo + ", valor: " + valor);
            }
            saldo -= valor; //verify
        }

        public bool Transferir(double valor, Conta contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public double Saldo { get; set; }

        public int Agencia
        {
            get { return this.agencia = Agencia; }

            set
            {
                this.agencia = Agencia;

                if (agencia <= 0)
                {
                    Console.WriteLine("O número da agencia não pode ser menor ou igual a zero.");
                }
            }
        }

        public int NumeroDaConta
        {

            get { return this.numeroDaConta = NumeroDaConta; }

            set
            {
                if (numeroDaConta <= 0)
                {
                    Console.WriteLine("O número da conta não pode ser menor ou igual a zero.");
                }
                this.numeroDaConta = numeroDaConta;
            }
        }

        public Cliente Titular { get; set; }

        public override bool Equals(object? obj)
        {
            Conta outraConta = (Conta)obj;
            if (this.agencia != outraConta.agencia)
            {
                return false;
            }
            if (this.numeroDaConta != outraConta.numeroDaConta)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return "agencia: " + agencia +
                   ", conta: " + numeroDaConta;
        }
    }
}
