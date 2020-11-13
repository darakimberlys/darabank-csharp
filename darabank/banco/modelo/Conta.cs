using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darabank.banco.modelo
{
    public abstract class Conta
    {
        public int numeroDaConta;
        public int agencia;
        public double Saldo { get;  set; }
        public Cliente Titular { get; set; }

        public Conta(int agencia, int numeroDaConta)
        {
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
        }

        public int NumeroDaConta { get ; set ; }

        public int Agencia { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }


        public virtual void Depositar(double valor) //verificar
        {
            Saldo += valor;
        }

        public override bool Equals(object obj)
        {
            Conta outraConta = obj as Conta;

            if (outraConta == null)
            {
                return false;
            }
            return NumeroDaConta == outraConta.NumeroDaConta && Agencia == outraConta.Agencia;
        }

        public virtual void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (Saldo > valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            Saldo -= valor;
        }


        public override string ToString()
        {
            return "agencia: " + agencia +
                   ", conta: " + NumeroDaConta;
        }

        public void Transferir(double valor, Conta contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }

        public override int GetHashCode() { return 0; }

    }
}