using EstacionamentoShopping.Modelos.Calculo;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoShopping
{
    public class CadastraVeiculoEData
    {
        private RepositorioGenerico<Veiculo> repositorioVeiculos;
        private RepositorioGenerico<DataEHorario> repositorioDataEHorario;

        public CadastraVeiculoEData(RepositorioGenerico<Veiculo> repositorioVeiculos,
            RepositorioGenerico<DataEHorario> repositorioDataEHorario)
        {
            this.repositorioVeiculos = repositorioVeiculos;
            this.repositorioDataEHorario = repositorioDataEHorario;
        }

        public bool CadastraVeiculo(string placa,bool estacionado, int quantidadeDeUso, EnumTipoVeiculo enumTipoVeiculo)
        {
            return SalvaVeiculo(placa,estacionado, quantidadeDeUso, enumTipoVeiculo );
            
        }

        public bool SalvaVeiculo(string placa, bool estacionado, int quantidadeDeUso,


            EnumTipoVeiculo enumTipoVeiculo)

        {

            if(placa == null)
            {
                return false;
            }
           
            
            Veiculo veiculo = FabricaVeiculo.Cria(placa, estacionado, quantidadeDeUso
                , enumTipoVeiculo);

            repositorioVeiculos.Insert(veiculo);

           
            return true;
        }

        public bool CadastraData(string placa, DateTime dataEntrada, DateTime dataSaida)
        {
            return SalvaData(placa, dataEntrada, dataSaida);

        }

        public bool SalvaData(string placa, DateTime dataEntrada, DateTime dataSaida)

        {

            if (placa == null)
            {
                return false;
            }
            if (dataEntrada == null)
            {
                return false;
            }
            if (dataSaida == null)
            {
                return false;
            }


            DataEHorario dataEHorario = new DataEHorario(placa, dataEntrada, dataSaida);

            repositorioDataEHorario.Insert(dataEHorario);
           
            return true;
        }


    }

}
