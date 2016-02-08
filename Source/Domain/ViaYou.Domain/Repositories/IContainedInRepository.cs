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
        void Add(ContainedIn containedIn);
        ContainedIn GetById(int id);
        IQueryable<ContainedIn> GetAll();
    }
}
