using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Models
{
    public class MotoTriciclo
    {
        public int Id { get; set; }
        [ForeignKey("Veiculo")]
        public int DetalheMotoTriciclo { get; set; }
        public float Potencia { get; set; }
        public int QtdeRoda { get; set; }

        public Veiculo? Veiculo { get; set; }

    }
}
