using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Travels;

namespace ViaYou.Services.TravelSearchProvider
{
    public interface ITravelSearchService
    {
        IEnumerable<Travel> SearchTravels(int orginCityCode, int destinationCityCode, int categoryId, int containedInId);
    }
}
