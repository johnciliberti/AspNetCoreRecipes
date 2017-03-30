namespace Recipe05.Models
{
    public class GuitarString
    {
        public string Name
        {
            get
            {
                return string.Format("{0} : {1}", NoteAtStandardTuning, Gage);
            }
        }
        public string NoteAtStandardTuning { get; set; }
        public int Gage { get; set; }
        public string Material { get; set; }
    }
}
