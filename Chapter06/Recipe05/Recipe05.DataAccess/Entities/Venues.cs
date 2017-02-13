using System;
using System.Collections.Generic;

namespace Recipe05.DataAccess.Entities
{
    public partial class Venues
    {
        public Venues()
        {
            Events = new HashSet<Events>();
        }

        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
