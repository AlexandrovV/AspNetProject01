using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }
        public string Name { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
