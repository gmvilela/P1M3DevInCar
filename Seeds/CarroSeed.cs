using P1M3DevInCar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Seeds
{
    public class CarroSeed
    {
        public static List<Carro> CarroSeeder { get; set; } = new List<Carro>()
        {
            new Carro{Id = 1, DetalheCarro = 2, QtdePorta = 4, Potencia = 1000, Combustivel = "Flex"}
        };
    }
}

