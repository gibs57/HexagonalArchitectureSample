using System.Collections.Generic;

namespace HexaArchitecture.DomainApi.Port
{
    public interface IRequestVisit<T>
    {
        List<T> GetVisits();
        T GetVisit(int id);
    }
}
