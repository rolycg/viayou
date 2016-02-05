using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaYou.Data
{
    public class BaseRepository : IDisposable
    {
        public ViaYouDataContext Context { get; set; }

        public void Dispose()
        {
            Context.Dispose();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                Dispose();
        }
    }
}
