using System;

namespace Darabank.Modelos
{
    public class Teste
    {
        static void Main(string[] args)
        {
            Cliente contaDaGabi = new Cliente();

            ContaPoupanca conta = new ContaPoupanca(363, 8688);

            contaDaGabi.Nome = "Gabriela Felicia";
            contaDaGabi.CPF = "565.564.454-88";
            contaDaGabi.Profissao = "Desenvolvedora .Net";

            conta.Titular = contaDaGabi;
            conta.Saldo = 333.80;

            Console.WriteLine(contaDaGabi.Nome);
            Console.WriteLine(contaDaGabi.CPF);
            Console.WriteLine(contaDaGabi.Profissao);

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Agencia);

            //teste ok 09/11 - conta poupanca

            Cliente contaDaMayara = new Cliente();

            ContaPoupanca contaMay = new ContaPoupanca(363, 8688);

            contaDaMayara.Nome = "Mayara Fernandes";
            contaDaMayara.CPF = "666.222.555-55";
            contaDaMayara.Profissao = "Desenvolvedora .Net Sr";

            contaMay.Titular = contaDaMayara;
            contaMay.Saldo = 23000.00;

            Console.WriteLine(contaDaMayara.Nome);
            Console.WriteLine(contaDaMayara.CPF);
            Console.WriteLine(contaDaMayara.Profissao);

            Console.WriteLine(contaMay.Saldo);
            Console.WriteLine(contaMay.Titular.Nome);

            //teste ok 09/11 - conta corrente, verificar anotacoes na classe

            Conta conta1 = new ContaCorrente(123, 12112);
        }
    }
}