using HexaArchitecture.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HexaArchitecture.Persistence.Adapter
{
    public static class PersistenceExtensions
    {
        public static void AddPersistence(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("HexaArchConnInMemoryDb"));

            serviceCollection.AddDbContext<VisitDbContext>(options => options.UseSqlServer("Server=W2K16BDDCHADEV1\\CHAINE;Database=M6Visiteurs;User=adminBackOffice;Password=\"J4p!d8)$yrGq\";Integrated Security=false;MultipleActiveResultSets=true"));
        }
    }
}
