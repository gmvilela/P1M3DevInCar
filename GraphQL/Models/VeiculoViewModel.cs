using P1M3DevInCar.Models;

namespace P1M3DevInCar.GraphQL.Models
{
    public class VeiculoViewModel : Veiculo
    {
        
        public VeiculoViewModel(Veiculo veiculo)
        {
            Id = veiculo.Id;
            Tipo = veiculo.Tipo;
            Venda = veiculo.Venda;
            Nome = veiculo.Nome;
            NumeroChassi = veiculo.NumeroChassi;
            DataFabricacao = veiculo.DataFabricacao;
            Placa = veiculo.Placa;
            Valor = veiculo.Valor;
            Cor = veiculo.Cor;
            CpfComprador = veiculo.CpfComprador;
            DataCompra = veiculo.DataCompra;
            DetalheMotoTriciclo = veiculo.DetalheMotoTriciclo;
            DetalheCarro = veiculo.DetalheCarro;
            DetalheCamionete = veiculo.DetalheCamionete
        }

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
