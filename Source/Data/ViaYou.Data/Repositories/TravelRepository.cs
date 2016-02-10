using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Repositories;
using ViaYou.Domain.Travels;

namespace ViaYou.Data.Repositories
{
    public class TravelRepository : ITravelRepository
    {
        public void Add(Travel travel)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Travel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Travel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
