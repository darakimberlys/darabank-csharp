using System;
using Darabank.Modelos;
using Darabank.Modelos.Funcionarios;

namespace Darabank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020, 12, 7);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente+"\n");

            string message = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(message);

            static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
            { 
                if (timeSpan.Days > 30)
                {
                    int quantidadeMeses = timeSpan.Days / 30;
                    if(quantidadeMeses == 1)
                    {
                        return " 1 mês";
                    }
                    return quantidadeMeses + " meses";
                }

                else if(timeSpan.Days > 7)
                {
                    int quantidadeSemanas = timeSpan.Days / 7;
                    if(quantidadeSemanas == 1)
                    {
                        return " 1 semana";
                    }
                    return quantidadeSemanas + " semanas";
                }
                return timeSpan.Days + " dias";
            }
        }
    }
}
