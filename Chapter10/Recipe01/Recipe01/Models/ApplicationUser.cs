using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Recipe01.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        public int MilesFromCityCenter { get; set; }
        public IList<ConcertAlertPreference> ConcertAlertPreferances { get;set;}
    }
}