using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping.Modelos.Calculo
{
    public class GeradorVeiculoEData
    {
        public static void GeraVeiculoEData(RepositorioGenerico<Veiculo> repositorioVeiculo,
            RepositorioGenerico<DataEHorario> repositorioDataEHorario,
            int quantidadeVeiculo)
        {
            CadastraVeiculoEData cadastroDeVeiculoEData =
                new CadastraVeiculoEData(repositorioVeiculo, repositorioDataEHorario);

            int index = 0;

            while (index < quantidadeVeiculo)
            {
                while ((cadastroDeVeiculoEData.CadastraVeiculo(
                    GeraPlacaVeiculo(),
                    true,
                    1,
                    TipoVeiculo(index)) && cadastroDeVeiculoEData.CadastraData(
                    GeraPlacaVeiculo(),
                    GeraDataEntrada(),
                    GeraDataSaida()
                    )) != true) ;

                    index++;
                

            }
        }
        public static String GeraPlacaVeiculo()
        {
            return new Random().Next(0, Int32.MaxValue).ToString();
        }
        public static EnumTipoVeiculo TipoVeiculo(int numeroVeiculo)
        {
            if (numeroVeiculo < 10)
                return EnumTipoVeiculo.MOTOCICLETA;
            if (numeroVeiculo < 20)
                return EnumTipoVeiculo.CARRO;
            else
                return EnumTipoVeiculo.CAMINHONETE;
        }
        public static DateTime GeraDataEntrada()
        {
            int dia = 17;
            int mes = 3;
            int ano = 2021;
            Random hora = new Random();
            Random minuto = new Random();
            Random segundo = new Random();

            string datastring = dia.ToString() + "/" + mes.ToString()
             + "/" + ano.ToString() + " " + hora.Next(1, 12).ToString()
             + ":" + minuto.Next(1, 60).ToString() + ":" + segundo.Next(1, 60).ToString();

            return DateTime.Parse(datastring);
        }
        public static DateTime GeraDataSaida()
        {
            int dia = 17;
            int mes = 3;
            int ano = 2021;
            Random hora = new Random();
            Random minuto = new Random();
            Random segundo = new Random();
            var dataSaidaAMais = 4;

            string datastring = dia.ToString() + "/" + mes.ToString()
            + "/" + ano.ToString() + " " + hora.Next(1, 12).ToString()
            + ":" + minuto.Next(1, 60).ToString() + ":" + segundo.Next(1, 60).ToString();

            return DateTime.Parse(datastring);

            // gerar a hora de saida com mais horas que a entrada
            // associar a geraçao de placa do cadastra veiculo com cadastra data pra ser a mesma placa

        }




    }
}



