using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe01_06.Models
{
    public class GuitarCaseModel
    {
        public List<GuitarPick> Picks { get; set; }
        public List<GuitarCable> Cables { get; set; }
        public Guitar MyGuitar { get; set; }
    }

    // Defined in another assembly
    public class Guitar
    {
        public string Brand { get; set; }
        public string BodyStyle { get; set; }
        public string Finish { get; set; }
    }

    public class GuitarCable
    {
        public string Brand { get; set; }
        public int Length { get; set; }
    }

    public class GuitarPick
    {
        public string Brand { get; set; }
        public string Thickness { get; set; }
    }

}
