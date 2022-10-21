using HotChocolate.Subscriptions;
using P1M3DevInCar.Context;
using P1M3DevInCar.Models;

namespace P1M3DevInCar.GraphQL.Mutations
{
    public class VeiculoInput
    {
        public int VeiculoID { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataCompra { get; set; }
        public string Cor { get; set; }
        public float Valor { get; set; }
        public int Tipo { get; set; }
        public bool Venda { get; set; }
        public string Nome { get; set; }
        public string NumeroChassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Placa { get; set; }
        public string? CpfComprador { get; set; }
        public int? DetalheMotoTriciclo { get; set; }
        public int? DetalheCarro { get; set; }
        public int? DetalheCamionete { get; set; }

    }

    [ExtendObjectType(OperationTypeNames.Mutation)]
    public class VeiculoMutation
    {

        public async Task<bool> VenderVeiculo([Service] DevInCarContext context, VeiculoInput input,
            [Service]ITopicEventSender eventSender)
        {
            try
            {
                context.Veiculos.Add(new Veiculo() { Id = input.VeiculoID, CpfComprador = input.Cpf, 
                    DataCompra = input.DataCompra, Venda = true});
                await context.SaveChangesAsync();
                return true;
            }
            catch (SystemException)
            {
                throw new Exception("Não foi possível vender o veículo");
            }
        }

        public async Task<bool> AlterarCor([Service] DevInCarContext context, VeiculoInput input)
        {
            try
            {
                context.Veiculos.Add(new Veiculo(){Id = input.VeiculoID, Cor = input.Cor});
                await context.SaveChangesAsync();
                return true;
            }
            catch (SystemException)
            {
                throw new Exception("Não foi possível alterar cor do veículo");
            }
        }

        public async Task<bool> AlterarValor([Service] DevInCarContext context, VeiculoInput input)
        {
            try
            {
                context.Veiculos.Add(new Veiculo() { Id = input.VeiculoID, Valor = input.Valor });
                await context.SaveChangesAsync();
                return true;
            }
            catch (SystemException)
            {
                throw new Exception("Não foi possível alterar valor do veículo");
            }
        }

        public async Task<bool> NovoVeiculo([Service] DevInCarContext context, VeiculoInput input)
        {
            try
            {
                context.Veiculos.Add(new Veiculo() { Id = input.VeiculoID, Valor = input.Valor, 
                                                    CpfComprador = input.Cpf, DataCompra = input.DataCompra,
                                                    Cor = input.Cor, Tipo = input.Tipo, Venda = input.Venda,
                                                    Nome = input.Nome, NumeroChassi = input.NumeroChassi,
                                                    DataFabricacao = input.DataFabricacao, Placa = input.Placa,
                                                    DetalheMotoTriciclo = input.DetalheMotoTriciclo,
                                                    DetalheCarro = input.DetalheCarro, DetalheCamionete = input.DetalheCamionete});
                await context.SaveChangesAsync();
                return true;
            }
            catch (SystemException)
            {
                throw new Exception("Não foi possível alterar valor do veículo");
            }
        }

    }

}
