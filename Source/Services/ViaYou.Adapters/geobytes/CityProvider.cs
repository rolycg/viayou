using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using RestSharp;
using System.Threading.Tasks;
using ViaYou.Adapters.geobytes.Models;

namespace ViaYou.Adapters.geobytes
{
    public class CityProvider : ICityProvider
    {
        RestClient _client;

        public CityProvider()
        {
            var server = "asdasd"; //ConfigurationManager.AppSettings["cities-provider-server-base-url"];
            _client = new RestClient(server);
        }

        public IEnumerable<GeobytesCity> GetCities(string term)
        {
            throw new NotImplementedException();
        }
    }
}
