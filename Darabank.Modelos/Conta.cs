﻿using System;

namespace Darabank.Modelos
{

    /// <summary>
    /// Esta classe define o funcionamento das Contas no banco.
    /// </summary>
    public abstract class Conta
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTransferenciasNaoPermitidas { get; private set; }

        public int NumerodaConta { get; set; }

        private int _agencia;

        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        private double _saldo = 100; // hipoteticamente, nesse banco, ganha-se um bonus de 100 reais por criar a conta;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        /// <summary>
        /// Cria uma instancia do tipo de Conta a selecionar com os argumentos utilizados.
        /// </summary>
        /// <param name="agencia"> Representa o valor da Propriedade <see cref="Agencia"/>, e deve possuir um valor menor que 0. </param>
        /// <param name="numeroDaConta"> Representa o valor da Propriedade <see cref="NumerodaConta"/>, e deve possuir um valor menor que 0.</param>
        public Conta(int agencia, int numeroDaConta)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O Argumento referente a Agencia deve ser maior que 0.", nameof(agencia));
            } // impede que o sistema aceite o numero da agencia seja menor ou igual a zero;

            if (numeroDaConta <= 0)
            {
                throw new ArgumentException("O Argumento referente ao numero da conta deve ser maior que 0.", nameof(numeroDaConta));
            } // impede que o sistema aceite o numero da conta seja menor ou igual a zero;

            Agencia = agencia;
            NumerodaConta = numeroDaConta;

            TotalDeContasCriadas++; //faz a contagem de quantas contas foram criadas;
            TaxaOperacao = 30 / TotalDeContasCriadas;

        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançado quando um valor negativo é utilizado no argumento <paramref name="valor"/> </exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo"/></exception>
        /// <param name="valor">Representa o valor do Saque, deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
        public virtual void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.");
            } // impede que o usuário tente sacar um valor menor que 0, o que geraria um aumento no saldo, caso sacasse um valor negattivo;

            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++; //Conta quantas vezes o usuario tentou sacar um valor que ele não possui, futuramente podendo ser candidato de ofertas de emprestimo, etc;
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            _saldo -= valor;
        }

        public virtual void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0 || _saldo < valor)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorDeTransferenciasNaoPermitidas++; //Conta quantas vezes o usuario tentou transferir um valor que ele não possui;
                throw new OperacaoFinanceiraException("Operação não realizada. Por favor, verifique", ex);
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}