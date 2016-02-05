using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaYou.Adapters.geobytes.Models
{
    public class GeobytesCity
    {
        public string Name { get; set; }
        public int Code { get; set; }


        public GeobytesCity()
        {
            
        }
        public GeobytesCity(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
}
