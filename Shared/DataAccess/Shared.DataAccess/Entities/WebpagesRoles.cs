// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // webpages_Roles
    public partial class WebpagesRoles
    {
        public int RoleId { get; set; } // RoleId (Primary key)

        public string RoleName { get; set; } // RoleName

        public Guid? OldRoleId { get; set; } // OldRoleID

        // Reverse navigation
        public virtual ICollection<Artist> Artists { get; set; } // Many to many mapping

        public WebpagesRoles()
        {
            Artists = new List<Artist>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}