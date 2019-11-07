using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string Name { get; set; }
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
