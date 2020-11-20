using System;
using Darabank.Modelos;
using Darabank.Modelos.Funcionarios;

namespace Darabank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(336, 2566);
            Funcionario funcionario = null;
            Console.WriteLine(conta.NumerodaConta);
        }
    }
}
