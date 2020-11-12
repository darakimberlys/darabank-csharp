using System;
using darabank;
using darabank.banco.modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace darabank_test
{
    [TestClass]
    public class TesteGuardadorDeContas
    {
        [TestMethod]
        public void TestMethod1()
        {
            GuardadorDeContas guardador = new GuardadorDeContas();

            Conta cc = new ContaCorrente(6685, 84758);
            guardador.Adiciona(cc);

            Conta ccDois = new ContaCorrente(6685, 45115);
            guardador.Adiciona(ccDois);

            int tamanho = guardador.GetQuantidadeElementos();
            Console.WriteLine(tamanho);
            //funciona

            //Conta refConta = guardador.GetReferencia(1);
            //Console.WriteLine(refConta.NumeroDaConta);
        }
    }
}
