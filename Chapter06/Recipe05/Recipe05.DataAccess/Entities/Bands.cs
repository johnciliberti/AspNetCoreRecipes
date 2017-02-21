using System;
using System.Collections.Generic;

namespace Recipe05.DataAccess.Entities
{
    public partial class Bands
    {
        public Bands()
        {
            Events = new HashSet<Events>();
        }

        public int BandId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
