namespace Recipe04.DataAccess.Entities
{
    public class ArtistSkill
    {
        public int ArtistSkillId { get; set; }
        public string TalentName { get; set; }
        public int SkillLevel { get; set; }
        public string Details { get; set; }
        public string Styles { get; set; }

        public virtual Artist Artist { get; set; }
    }

}
