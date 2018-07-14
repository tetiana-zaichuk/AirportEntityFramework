using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Crew : Entity
    {
        public Pilot Pilot { get; set; }
        public List<Stewardess> Stewardesses { get; set; }
        
        //public int DepartureId { get; set; }
        //public Departure Departure { get; set; }
    }
}
