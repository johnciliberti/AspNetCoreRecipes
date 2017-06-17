using System.Collections.Generic;

namespace Chapter11.Models
{
    public class Profile
    {
        public string ProfileImageUrl { get; set; }
        public string BannerImageUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        public IList<CollaborationProject> Projects { get; set; }

    }
}
