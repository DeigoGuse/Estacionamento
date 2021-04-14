using EstacionamentoShopping.Modelos.Calculo;
using System;

namespace EstacionamentoShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var repositorioVeiculos = new RepositorioVeiculos();
            var relatorioTodosVeiculos = new RelatorioTodosVeiculos(repositorioVeiculos);
            var repositorioDataEHorario = new RepositorioDataEHorario();

            GeradorVeiculoEData.GeraVeiculoEData(repositorioVeiculos,repositorioDataEHorario,30);

             relatorioTodosVeiculos.GerarRelatorio();

            Console.WriteLine("Programa Compilando e em Construção ... ");

        }
    }
}
