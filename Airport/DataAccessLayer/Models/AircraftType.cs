﻿namespace DataAccessLayer.Models
{
    public class AircraftType: Entity
    {
        public string AircraftModel { get; set; }
        public int SeatsNumber { get; set; }
        public int Carrying { get; set; }
        
        //public int AircraftId { get; set; }
        //public Aircraft Aircraft { get; set; }
    }
}
