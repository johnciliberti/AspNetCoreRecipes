// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // Task
    public partial class Task
    {
        public int TaskId { get; set; } // TaskID (Primary key)

        public int ArtistId { get; set; } // ArtistId

        public string Title { get; set; } // Title

        public string Details { get; set; } // Details

        public DateTime? DueDate { get; set; } // DueDate

        public int? State { get; set; } // State

        public int? LinkType { get; set; } // LinkType

        public int? LinkTypeId { get; set; } // LinkTypeID

        public DateTime CreateDate { get; set; } // CreateDate

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_Task_Artist

        public Task()
        {
            CreateDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}