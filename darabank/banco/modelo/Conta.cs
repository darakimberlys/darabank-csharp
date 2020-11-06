using System;

namespace darabank
{
    public abstract class Conta
    {
        private static int total = 0;
        protected double saldo;
        private int agencia;
        private int numeroDaConta;

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
        //incluir metodos nos getters e setters
        public int Saldo { get; set; }

        public int Agencia { get; set; }

        public int NumeroDaConta { get; set; }

        public Cliente Titular { get; set; }//verificar

        //verificar getters e setters - incluir do titular

        //incluir metodos
    }
}
