using System.Collections.Generic;

namespace PierresTreats.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<CategoryTreat>();
        }

        public int TreatId { get; set; }
        public string Name { get; set; }
        public virtual ApplicationUser User { get; set; }

        public ICollection<CategoryTreat> Flavors { get;}
    }
}