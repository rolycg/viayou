using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Repositories;
using ViaYou.Domain.Travels;

namespace ViaYou.Services.TravelSearchProvider
{
    public class TravelSearchService : ITravelSearchService
    {
        private readonly ITravelRepository _travelRepository;

        public TravelSearchService(ITravelRepository travelRepository)
        {
            _travelRepository = travelRepository;
        }

        public IEnumerable<Travel> SearchTravels(int orginCityCode, int destinationCityCode, int categoryId,
            int containedInId)
        {
            return _travelRepository.GetAll();
        }
    }
}
