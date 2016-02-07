using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Travels;

namespace ViaYou.Domain.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category GetById(int id);
        IQueryable<Category> GetAll();
    }
}
