using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chapter04.Models.Recipe05
{
    public class GuitarBrandViewModel
    {
        public List<SelectListItem> Brands { get; set; }
        public int SelectedBrandId { get; set; }
        public GuitarBrand SelectedBrand { get; set; }
    }

    
}
