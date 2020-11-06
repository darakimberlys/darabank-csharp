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

        public abstract void deposita(double valor);
        //verificar necessidade de parametro e "throws"

        public void saca(double valor) 
        {
            if (this.saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo: " + this.saldo + ", valor: " + valor);
            }
            this.saldo -= valor;
        }
       
        public void transfere(double valor, Conta destino)
        {
            this.saca(valor);
            destino.deposita(valor);
        }

        public int Saldo { get; set; }

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

        public int NumeroDaConta {

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
            Conta outraConta = (Conta) obj;
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
