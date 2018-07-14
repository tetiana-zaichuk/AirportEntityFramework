using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Models
{
    public class Aircraft: Entity
    {
        public string AircraftName { get; set; }
        public int AircraftTypeId { get; set; }
        public DateTime AircraftReleaseDate { get; set; }
        [NotMapped]
        public TimeSpan ExploitationTimeSpan { get; set; }
        public long ExploitationTimeSpanTicks
        {
            get => ExploitationTimeSpan.Ticks;
            set => ExploitationTimeSpan = TimeSpan.FromTicks(value);
        }
    }
}
