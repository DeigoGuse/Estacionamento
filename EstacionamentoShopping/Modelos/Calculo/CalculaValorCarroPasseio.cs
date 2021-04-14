using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping.Modelos.Calculo
{
    public class CalculaValorCarroPasseio : ICalculaValor
    {
        private readonly IRepositorio<ValoresCalculados> repositorioValoresCalculados;
        private readonly IRepositorio<DataEHorario> repositorioDataEHorario;

        public CalculaValorCarroPasseio(IRepositorio<ValoresCalculados> repositorioValoresCalculados, IRepositorio<DataEHorario> repositorioDataEHorario)
        {
            this.repositorioValoresCalculados = repositorioValoresCalculados;
            this.repositorioDataEHorario = repositorioDataEHorario;
        }

        public void CalculaValor(Veiculo veiculo)
        {
            var dataEHora = repositorioDataEHorario.ConsultarTodos().Find(

                x => x.Placa == veiculo.Placa && veiculo.Estacionado == true);

            var horaVeiculoNodia = (dataEHora.DataSaida - dataEHora.DataEntrada).TotalHours;




            repositorioValoresCalculados.Insert(new ValoresCalculados
            {
                Placa = veiculo.Placa,
                ValorPrimeiraHora = 3,
                ValorHoraAdicional = 1.50,
                ValorFinal = CalculaValorFinal(horaVeiculoNodia,veiculo.QuantidadeDeUso)


            });

            veiculo.Estacionado = false;
            veiculo.QuantidadeDeUso++;

        }


        public static double CalculaValorFinal(double horasVeiculoNodia,int quantidadeDeUso)
        {
            if ((quantidadeDeUso / 3) % 3 == 0)
            {
                return 0;
            }
            else
           if (horasVeiculoNodia <= 0.25)
            {
                return 0;
            }
            if (horasVeiculoNodia <= 1)
            {
                return 3;
            }
            else
                return ((Math.Ceiling(horasVeiculoNodia) - 1) * 1.50) + 3;

        }

    }
    
}
