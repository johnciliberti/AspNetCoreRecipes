using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Recipe05.Models
{
    public class Guitar
    {
        [Display(Description ="Name your custom guitar.")]
        public string Name { get; set; }
        public GuitarBody Body { get; set; }
        [Display(Name = "Bridge Pickup.")]
        public GuitarPickup BridgePickup { get; set; }

        [Display(Name = "Middle Pickup.")]
        public GuitarPickup MiddlePickup { get; set; }
        
        [Display(Name = "Neck Pickup.")]
        public GuitarPickup NeckPickup { get; set; }
        

        public IList<GuitarString> Strings { get; set; }
    }
}
