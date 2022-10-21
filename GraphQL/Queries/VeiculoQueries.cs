using Microsoft.EntityFrameworkCore;
using P1M3DevInCar.Context;
using P1M3DevInCar.GraphQL.Models;
using P1M3DevInCar.Models;

namespace P1M3DevInCar.GraphQL.Queries
{
    public class VeiculoQueries
    {
        [ExtendObjectType(OperationTypeNames.Query)]
        public class VeiculoQuery
        {
            public List<Veiculo> ListarVeiculos([Service] DevInCarContext context, int? tipo)
            {
                switch(tipo)
                {
                    case 1:
                        return context.Veiculos.Where(x => x.Tipo == 1).ToList();
                    case 2:
                        return context.Veiculos.Where(x => x.Tipo == 2).ToList();
                    case 3:
                        return context.Veiculos.Where(x => x.Tipo == 3).ToList();
                    default:
                        return context.Veiculos.ToList();
                }
                
            }

            public List<Veiculo> VeiculosDisponiveis([Service] DevInCarContext context, int? tipo)
            {
                return context.Veiculos.Where(q => q.Venda == false).ToList();
            }

            public List<Veiculo> VeiculosVendidos([Service] DevInCarContext context, int? tipo)
            {
                return context.Veiculos.Where(q => q.Venda == true).ToList();
            }

            public Veiculo VeiculoMaiorPreco([Service] DevInCarContext context, int? tipo)
            {

                return context.Veiculos.OrderByDescending(x => x.Valor).FirstOrDefault();


            }

            public Veiculo VeiculoMenorPreco([Service] DevInCarContext context, int? tipo)
            {
                return context.Veiculos.OrderBy(q => q.Valor).FirstOrDefault();
                
            }

        }
    }
}
