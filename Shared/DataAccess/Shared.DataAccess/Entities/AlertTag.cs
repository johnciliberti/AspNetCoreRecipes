// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // AlertTag
    public partial class AlertTag
    {
        public int AlertTagId { get; set; } // AlertTagId (Primary key)

        public int AlertId { get; set; } // AlertId

        public string Tag { get; set; } // Tag

        // Foreign keys
        public virtual Alert Alert { get; set; } // FK_AlertTag_Alert
    }
}