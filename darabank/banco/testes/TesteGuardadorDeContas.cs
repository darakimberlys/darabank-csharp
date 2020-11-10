using System;
using darabank.banco.modelo;


namespace darabank.banco.testes
{
    class TesteGuardadorDeContas
    {
        public static void Main(string[] args)
        {
            GuardadorDeContas guardador = new GuardadorDeContas();

            Conta cc = new ContaCorrente(6685, 84758);
            guardador.Adiciona(cc);

            Conta ccDois = new ContaCorrente(6685, 45115);
            guardador.Adiciona(ccDois);

            int tamanho = guardador.GetQuantidadeElementos();
            Console.WriteLine(tamanho);
            //funciona

            Conta refConta = guardador.GetReferencia(1);
            Console.WriteLine(refConta.NumeroDaConta);
            //quebra
        }
    }
}
