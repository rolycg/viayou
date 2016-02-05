using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaYou.Adapters.geobytes.Models;

namespace ViaYou.Adapters.geobytes
{
    public class FakeCityProvider : ICityProvider
    {
        public IEnumerable<GeobytesCity> GetCities(string term)
        {
            yield return new GeobytesCity("Madrid", 1);
            yield return new GeobytesCity("Milano", 2);
            yield return new GeobytesCity("Lisbon", 3);
            yield return new GeobytesCity("Munich", 4);
        }
    }
}
