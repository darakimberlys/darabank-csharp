using System;
using darabank;
using darabank.banco.modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace darabank_test
{
    [TestClass]
    public class TesteClasseConta
    {
        [TestMethod]
        public void TestMethod1()
        {
            Cliente contaDaGabi = new Cliente();

            ContaPoupanca conta = new ContaPoupanca(363, 8688);

            contaDaGabi.Nome = "Gabriela Felicia";
            contaDaGabi.Cpf = "565.564.454-88";
            contaDaGabi.Profissao = "Desenvolvedora .Net";

            conta.Titular = contaDaGabi;
            conta.Saldo = 333.80;

            Console.WriteLine(contaDaGabi.Nome);
            Console.WriteLine(contaDaGabi.Cpf);
            Console.WriteLine(contaDaGabi.Profissao);

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);

            //teste ok 09/11 - conta poupanca

            Cliente contaDaMayara = new Cliente();

            ContaPoupanca contaMay = new ContaPoupanca(363, 8688);

            contaDaMayara.Nome = "Mayara Fernandes";
            contaDaMayara.Cpf = "666.222.555-55";
            contaDaMayara.Profissao = "Desenvolvedora .Net Sr";

            contaMay.Titular = contaDaMayara;
            contaMay.Saldo = 23000.00;

            Console.WriteLine(contaDaMayara.Nome);
            Console.WriteLine(contaDaMayara.Cpf);
            Console.WriteLine(contaDaMayara.Profissao);

            Console.WriteLine(contaMay.Saldo);
            Console.WriteLine(contaMay.Titular.Nome);
        }
    }
}
