using P1M3DevInCar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Seeds
{
    public class MotoTricicloSeed
    {
        public static List<MotoTriciclo> MotoTricicloSeeder { get; set; } = new List<MotoTriciclo>()
        {
            new MotoTriciclo{Id = 1, DetalheMotoTriciclo = 1, Potencia = 100, QtdeRoda = 2}
        };
    }
}


