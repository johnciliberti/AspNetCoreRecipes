using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Contains meta data for the Band class
    /// </summary>
    [ModelMetadataType(typeof(Band))]
    public partial class BandMetaData
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

        [Display(Name = "Band Name")]
        public object BandName { get; set; }

        [Display(Name = "Band Biography", Description ="Tell the story of your band.", Order =2)]
        public object BandBio { get; set; }

        [Display(Name = "Modified Date")]
        [ScaffoldColumn(false)]
        public object ModifiedDate { get; set; }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
