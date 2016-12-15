using System.ComponentModel.DataAnnotations;

namespace Chapter04.Models.Recipe03
{
    // as shown in Figure 4.12
    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        
        public bool AllowContactAboutOffers { get; set; }

        [Display(Name = "Favorite Color?")]
        public string FavoriteColor { get; set; }

    }
}
