using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViaYou.Web.Models
{
    public class SearchTravelViewModel
    {
        [Required]
        public int From { get; set; }
        [Required]
        public int To { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ContainedInId { get; set; }
    }
}