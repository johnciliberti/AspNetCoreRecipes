using System;
using System.Collections.Generic;

namespace Recipe05.DataAccess.Entities
{
    public partial class Events
    {
        public int EventId { get; set; }
        public string Description { get; set; }
        public int BandId { get; set; }
        public int VenueId { get; set; }
        public DateTime EventDate { get; set; }

        public virtual Bands Band { get; set; }
        public virtual Venues Venue { get; set; }
    }
}
