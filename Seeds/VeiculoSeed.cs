using P1M3DevInCar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Seeds
{
    public static class VeiculoSeed
    {
        public static List<Veiculo> VeiculoSeeder { get; set; } = new List<Veiculo>()
        {

            new Veiculo{ Id = 1, Tipo = 1, Venda = false, Nome = "Honda CG Titan", NumeroChassi = "9BWHE21JX24064444",
                        DataFabricacao = DateTime.Now, Placa = "CCC1A11", Valor = 10000, Cor = "Azul", 
                        DetalheMotoTriciclo = 1},

             new Veiculo{Id = 2, Tipo = 2, Venda = false, Nome = "VW Gol", NumeroChassi = "9BWHE21JX24060831",
                        DataFabricacao = DateTime.Now, Placa = "AAA1A11", Valor = 50000, Cor = "Cinza",
                        DetalheCarro = 2},


            new Veiculo{Id = 3, Tipo = 3, Venda = true, Nome = "Chevrolet S10", NumeroChassi = "9BWHE21JX24060333",
                        DataFabricacao = DateTime.Now, Placa = "BBB1A11", Valor = 100000, Cor = "Branca",
                        CpfComprador = "11111111100", DetalheCamionete = 3}

        };
    }
}



