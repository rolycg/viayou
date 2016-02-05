using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Adapters.geobytes.Models;

namespace ViaYou.Adapters.geobytes
{
    public interface ICityProvider
    {
        IEnumerable<GeobytesCity> GetCities(string term);
    }
}
