using System;
using Darabank.Modelos;
using Darabank.Modelos.Funcionarios;
using Humanizer;

namespace Darabank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
           //Utilização do Humanizer para refinar a contagem entre datas;
            DateTime dataFimPagamento = new DateTime(2020, 12, 7);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente + "\n");

            string message = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(message);

        }
    }
}
