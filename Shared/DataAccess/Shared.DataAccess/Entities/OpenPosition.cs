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
    // OpenPosition
    public partial class OpenPosition
    {
        public int OpenPositionId { get; set; } // OpenPositionId (Primary key)

        public int? CollaborationSpaceId { get; set; } // CollaborationSpaceId

        public string Talent { get; set; } // Talent

        public int SkillLevel { get; set; } // SkillLevel

        public string Details { get; set; } // Details

        public DateTime DatePosted { get; set; } // DatePosted

        public DateTime DateModified { get; set; } // DateModified

        public int Status { get; set; } // Status

        public int? BandId { get; set; } // BandId

        public bool LocalOnly { get; set; } // LocalOnly

        public string LocalCity { get; set; } // LocalCity

        public string LocalCountry { get; set; } // LocalCountry

        public string LocalProvence { get; set; } // LocalProvence

        public int AuditionsSubmitted { get; set; } // AuditionsSubmitted

        public int ApprovalMode { get; set; } // ApprovalMode

        public OpenPosition()
        {
            SkillLevel = 0;
            DatePosted = System.DateTime.Now;
            DateModified = System.DateTime.Now;
            Status = 0;
            LocalOnly = false;
            AuditionsSubmitted = 0;
            ApprovalMode = 0;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}