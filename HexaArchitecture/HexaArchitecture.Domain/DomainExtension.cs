using HexaArchitecture.DomainApi.Port;
using Microsoft.Extensions.DependencyInjection;

namespace HexaArchitecture.Domain
{
    public static class DomainExtension
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IRequestDeal<>), typeof(DealDomain<>));
            serviceCollection.AddTransient(typeof(IRequestVisit<>), typeof(VisitDomain<>));
        }
    }
}
