using P1M3DevInCar.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Seeds
{
    public class CamioneteSeed
    {
        public static List<Camionete> CamioneteSeeder { get; set; } = new List<Camionete>()
        {
            new Camionete{Id = 1, DetalheCamionete = 3, QtdePorta = 2, CapacidadeCarregamento = 10000,
                          Potencia = 2000, Combustivel = "Diesel"}
        };
    }
}