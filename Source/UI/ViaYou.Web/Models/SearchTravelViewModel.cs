using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViaYou.Web.Models
{
    public class SearchTravelViewModel
    {
        public int From { get; set; }
        public int To { get; set; }
        public int CategoryId { get; set; }
        public int ContainedInId { get; set; }
    }
}