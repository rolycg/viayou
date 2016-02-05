using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Domain.Services;

namespace ViaYou.Data
{
    public class TransactionManager : ITransactionManager
    {
        private readonly ViaYouDataContext _context;

        public TransactionManager(ViaYouDataContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
