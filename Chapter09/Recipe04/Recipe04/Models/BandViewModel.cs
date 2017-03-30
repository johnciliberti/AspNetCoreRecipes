using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Recipe04.Models
{
    public class BandViewModel
    {
        [Required]
        [StringLength(30, MinimumLength =3)]
        [Display(Name ="Band Name")]
        [RegularExpression("^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$")]
        [Remote(action: "VerifyBandName", controller: "Band")]
        public string BandName { get; set; }
    }
}
