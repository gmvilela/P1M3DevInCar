using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Models
{
    public class TipoVeiculo
    {
        public int Id { get; set; }
        [ForeignKey("Veiculo")]
        public int Tipo { get; set; }
        public string TipoDeVeiculo { get; set; }

        public Veiculo? Veiculo { get; set; }
    }
}

// 1 = MotoTriciclo
// 2 = Carro
// 3 = Camionete
