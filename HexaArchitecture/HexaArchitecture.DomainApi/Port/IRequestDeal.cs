using System.Collections.Generic;

namespace HexaArchitecture.DomainApi.Port
{
    public interface IRequestDeal<T>
    {
        List<T> GetDeals();
        T GetDeal(int id);
    }
}
