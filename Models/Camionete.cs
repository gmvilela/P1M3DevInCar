using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Models
{
    public class Camionete
    {
        public int Id { get; set; }
        [ForeignKey("Veiculo")]
        public int DetalheCamionete { get; set; }
        public int QtdePorta { get; set; }
        public float CapacidadeCarregamento { get; set; }
        public float Potencia { get; set; }
        public string Combustivel { get; set; }

        public Veiculo? Veiculo { get; set; }


    }
}
