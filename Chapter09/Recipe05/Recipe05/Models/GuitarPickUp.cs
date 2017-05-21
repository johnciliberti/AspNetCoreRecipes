namespace Recipe05.Models
{
    public class GuitarPickup
    {
        public string Name { get; set; }
        public PickUpType PickUpType { get; set; }
        public PickUpPosition RecommendedPosition { get; set; }
        public int NumberOfStringsSupported { get; set; }
        public int NumberOfConductorsRequired { get; set; }
    }
}
