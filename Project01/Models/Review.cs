using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Text { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ReviewerId { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
