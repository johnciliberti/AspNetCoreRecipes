using System.Collections.Generic;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// List of Genres
    /// </summary>
    public partial class GenreLookUp
    {
        /// <summary>
        /// Unique ID for Genre
        /// </summary>
        public int GenreLookUpId { get; set; } // GenreLookUpId (Primary key)

        /// <summary>
        /// Genre Name
        /// </summary>
        public string GenreName { get; set; } // GenreName

        /// <summary>
        /// The culture this Genre will be used with
        /// </summary>
        public string Culture { get; set; } // Culture

        /// <summary>
        /// Link between Bands and Genres
        /// </summary>
        public virtual ICollection<BandGenre> BandGenres { get; set; } // BandGenre.FK_BandGenre_GenreLookUp

        /// <summary>
        /// Link between Collaboration Spaces and Genres
        /// </summary>
        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre.FK_CollaborationSpaceGenre_GenreLookUp

        /// <summary>
        /// Constructor initialize Culture to en
        /// </summary>
        public GenreLookUp()
        {
            Culture = "en";
            BandGenres = new List<BandGenre>();
            CollaborationSpaceGenres = new List<CollaborationSpaceGenre>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}