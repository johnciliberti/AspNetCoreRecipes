// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // ArtistSkill
    public partial class ArtistSkill
    {
        public int ArtistTalentId { get; set; } // ArtistTalentID (Primary key)

        public int ArtistId { get; set; } // ArtistId

        public string TalentName { get; set; } // TalentName

        public int SkillLevel { get; set; } // SkillLevel

        public string Details { get; set; } // Details

        public string Styles { get; set; } // Styles

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistSkill_Artist

        public ArtistSkill()
        {
            SkillLevel = 3;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}