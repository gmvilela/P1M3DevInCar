using P1M3DevInCar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Seeds
{
    public class TipoVeiculoSeed
    {
        public static List<TipoVeiculo> TipoVeiculoSeeder { get; set; } = new List<TipoVeiculo>()
        {
            new TipoVeiculo{Id =1, Tipo = 1, TipoDeVeiculo = "Moto/Triciclo"},
            new TipoVeiculo{Id =2, Tipo = 2, TipoDeVeiculo = "Carro"},
            new TipoVeiculo{Id =3, Tipo = 3, TipoDeVeiculo = "Camionete"}
        };
    }
}

