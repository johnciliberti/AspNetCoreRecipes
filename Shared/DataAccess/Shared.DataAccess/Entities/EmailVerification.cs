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
    // EmailVerification
    public partial class EmailVerification
    {
        public int EmailVerificationId { get; set; } // EmailVerificationId (Primary key)

        public int ArtistId { get; set; } // ArtistId

        public string Emailaddress { get; set; } // emailaddress

        public string VerificationCode { get; set; } // VerificationCode

        public DateTime NotificationSendDate { get; set; } // NotificationSendDate

        public DateTime? VerificationDate { get; set; } // VerificationDate
    }
}