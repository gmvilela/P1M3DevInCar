using System.ComponentModel.DataAnnotations.Schema;

namespace P1M3DevInCar.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public bool Venda { get; set; }
        public string Nome { get; set; }
        public string NumeroChassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Placa { get; set; }
        public float Valor { get; set; }
        public string Cor { get; set; }
        public string? CpfComprador { get; set; }
        public DateTime? DataCompra { get; set; }
        public int? DetalheMotoTriciclo { get; set; }
        public int? DetalheCarro { get; set; }
        public int? DetalheCamionete { get; set; }

    }
}
