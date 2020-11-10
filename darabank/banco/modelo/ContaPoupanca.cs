using System;
using System.Collections.Generic;
using System.Text;
using darabank;

namespace darabank.banco.modelo

{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int agencia, int numeroDaConta) : base(agencia, numeroDaConta)
        {
        }

        public override void Depositar(double valor)
        {
            saldo += valor;
        }

        public override string ToString()
        {
            return "Conta Poupanca, " + base.ToString();
        }
    }
}
