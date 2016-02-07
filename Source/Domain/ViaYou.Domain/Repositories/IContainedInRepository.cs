using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Travels;

namespace ViaYou.Domain.Repositories
{
    public interface IContainedInRepository
    {
        void Add(ContaidedIn containedIn);
        ContaidedIn GetById(int id);
        IQueryable<ContaidedIn> GetAll();
    }
}
