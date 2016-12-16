using System.ComponentModel.DataAnnotations;

namespace Chapter04.Models.Recipe06
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

    }
}
