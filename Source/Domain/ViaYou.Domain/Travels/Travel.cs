using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaYou.Domain.Travels
{
    public class Travel
    {
        public int Id { get; set; }
        [Required]
        public int OriginCode { get; set; }
        [Required]
        public int DestinationCode { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int Calification { get; set; }
    }
}
