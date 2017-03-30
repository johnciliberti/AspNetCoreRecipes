using System;

namespace Recipe05.Models
{
    public class GuitarBody
    {
        public string Name { get; set; }
        public string ToneWood { get; set; }
        public int NumberOfStringsSupported { get; set; }
        public bool AllowBridePickup { get; set; }
        public bool AllowMiddlePickup { get; set; }
        public bool AllowNeckPickup { get; set; }
        public BodyType BodyType { get; set; }
        public BodyStyle Style { get; set; }
        public String Color { get; set; }
    }

    public enum BodyType { HollowBody, Chambered, SolidBody}
    public enum BodyStyle { LesPaul, SG, Strat,Telecaster, FlyingV, Jazzmaster, Explorer, Gem }
}
