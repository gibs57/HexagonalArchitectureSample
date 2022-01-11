using HexaArchitecture.DomainApi.Model;
using System.Collections.Generic;

namespace HexaArchitecture.DomainApi.Port
{
    public interface IObtainDeal<T>
    {
        List<Deal> GetDeals();
        Deal GetDeal(T id);
    }
}
