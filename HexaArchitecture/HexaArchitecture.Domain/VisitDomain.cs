using HexaArchitecture.DomainApi.Port;
using HexaArchitecture.Persistence.Adapter.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HexaArchitecture.Domain
{
    public class VisitDomain<T> : IRequestVisit<T> where T : class
    {
        private readonly DbSet<T> table;

        public VisitDomain(VisitDbContext visitDbContext)
        {
            VisitDbContext _visitDbContext;
            _visitDbContext = visitDbContext;
            table = _visitDbContext.Set<T>();
        }
        public T GetVisit(int id)
        {
            return table.Find(id);
        }

        public List<T> GetVisits()
        {
            return table.ToList();
        }
    }
}
