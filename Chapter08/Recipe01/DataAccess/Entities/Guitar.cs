namespace Recipe02.DataAccess.Entities
{
    public class Guitar
    {
        public int GuitarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfStrings { get; set; }
        public GuitarBodyStyle BodyStyle { get; set; }
        
    }

    public enum GuitarBodyStyle {Solid, Chambered, Hollow }
}
