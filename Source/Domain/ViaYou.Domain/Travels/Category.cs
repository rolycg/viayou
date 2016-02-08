using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViaYou.Domain.Travels
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }


        public void Update(string name)
        {
            Name = name;
        }

        public Category()
        {

        }
        public Category(string name)
        {
            Name = name;
        }
    }
}
