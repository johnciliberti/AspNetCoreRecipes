using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe01.Models
{
    /// <summary>
    /// Summary description for Guitar
    /// </summary>
    public class Guitar
    {
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public bool HasWhammyBar { get; set; }
        public string WhammyBarType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Description { get; set; }
        public List<string> Strings { get; set; }
    }
}