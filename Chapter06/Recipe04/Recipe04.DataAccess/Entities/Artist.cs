using System;
using System.Collections.Generic;

namespace Recipe04.DataAccess.Entities
{
    public class Artist
    {

        public int ArtistId { get; set; }
        public string UserName { get; set; }
        public string Country { get; set; }
        public string Provence { get; set; }
        public string City { get; set; }
        public string WebSite { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual IList<ArtistSkill> ArtistSkills { get; set; }
    }

}
