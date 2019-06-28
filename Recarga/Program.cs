using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recarga
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Ao mudar de cartão alterar:

             Taxas de cada dia
             --Data de recarga
             Saldo atual

             */
            {
                //entradas
                double saldoAtual = 31.7;
                //DateTime dataRecarga = new DateTime(2019, 7, 5);
                //fim das entradas

                //==============================================//
                //Data final no (mês atual + 2)--> 1a sexta do (mes atual + 2) que a data >= 5
                DateTime dataFinal;
                DateTime dataHoje = DateTime.Now;

                dataFinal = dataHoje;
                dataFinal = dataFinal.AddMonths(2); //Adicionando 2 meses
                int diaMes = dataFinal.Day;

                //Alterando dia do mes para primeiro (1o) || Se necessário
                if (diaMes > 1)
                {
                    int diasDiminuir = (diaMes - 1) * (-1);
                    dataFinal = dataFinal.AddDays(diasDiminuir);
                }

                //Procurando uma sexta
                int diaDoMes = 1;
                while (!dataFinal.DayOfWeek.Equals(DayOfWeek.Friday))
                {
                    dataFinal = dataFinal.AddDays(1);
                    diaDoMes++;
                }

                //Procurando a primeira sexta > 4	
                if (diaDoMes < 5)
                {
                    dataFinal = dataFinal.AddDays(7);
                    diaDoMes += 7;
                }

                Console.WriteLine("Dia do mes: " + diaDoMes + " | Data final: " + dataFinal);
                //Fim do processamento da data final

                //==============================================//

                //Taxas de uso do cartão dentro do período (a partir do dia seguinte (amanhã))
                double taxaDiaUtil = 2; // 2 meias passagens
                double taxaSabado = 1;
                double taxaDomingoFeriado = 0;
                double totalTaxasUsoPassagem = 0;

                DateTime dataAuxiliar = dataHoje;
                while (!(dataAuxiliar.Day.Equals(dataFinal.Day) && dataAuxiliar.Month.Equals(dataFinal.Month) && dataAuxiliar.Year.Equals(dataFinal.Year)))
                {
                    dataAuxiliar = dataAuxiliar.AddDays(1);
                    //Dias úteis
                    if (dataAuxiliar.DayOfWeek != DayOfWeek.Saturday && dataAuxiliar.DayOfWeek != DayOfWeek.Sunday)
                    {
                        totalTaxasUsoPassagem += taxaDiaUtil;
                    }
                    else
                    {   //Sábados
                        if (dataAuxiliar.DayOfWeek == DayOfWeek.Saturday)
                        {
                            totalTaxasUsoPassagem += taxaSabado;
                        }
                        else
                        {   //Domingos
                            if (dataAuxiliar.DayOfWeek == DayOfWeek.Sunday)
                            {
                                totalTaxasUsoPassagem += taxaDomingoFeriado;
                            }
                        }
                    }
                }


                Console.WriteLine("Quantidade de meias passagens a serem usadas no período: " + totalTaxasUsoPassagem);
                //Fim das taxas

                //==============================================//

                //Cálculos do período
                double valorPassagemInteira = 4.00;
                double valorPassagemMeia = valorPassagemInteira / 2;
                double valorPeriodo = totalTaxasUsoPassagem * valorPassagemMeia;

                Console.WriteLine("Valor a pagar no próximo período: " + valorPeriodo);
                //Fim de cálculos do período

                //==============================================//

                //Valor da recarga a ser feita
                double valorRecarga = valorPeriodo - saldoAtual;

                Console.WriteLine("Saldo atual: " + saldoAtual);
                Console.WriteLine("Valor a ser recarregado no cartão: " + valorRecarga);
                //Fim do valor da recarga a ser feita

                Console.WriteLine("Tecle enter para sair...");
                Console.ReadLine();
            }
        }
    }
}