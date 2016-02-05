using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Travels;

namespace ViaYou.Domain.Repositories
{
    public interface ITravelRepository
    {
        void Add(Travel travel);
        Travel GetById(int id);
        IQueryable<Travel> GetAll();
    }
}
