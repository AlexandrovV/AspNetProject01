using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public int StudioId { get; set; }
        public Studio Studio { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
