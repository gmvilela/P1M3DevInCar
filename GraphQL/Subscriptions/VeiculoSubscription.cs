using P1M3DevInCar.GraphQL.Models;
using P1M3DevInCar.Models;

namespace P1M3DevInCar.GraphQL.Subscriptions
{
    [ExtendObjectType(OperationTypeNames.Subscription)]
    public class VeiculoSubscription
    {
        [Subscribe]
        public VeiculoViewModel VeiculoVendido([EventMessage] VeiculoViewModel message) => message;

    }
}
