using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [ForeignKey("Veiculo")]
        public int DetalheCarro { get; set; }
        public int QtdePorta { get; set; }
        public float Potencia { get; set; }
        public string Combustivel { get; set; }

        public Veiculo? Veiculo { get; set; }

    }
}
