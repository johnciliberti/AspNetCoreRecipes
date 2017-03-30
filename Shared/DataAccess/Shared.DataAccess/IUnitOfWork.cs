using System;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Exposes several repositories and a save method
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Allows queries and data management for data regarding Artists
        /// </summary>
        IArtistRepository ArtistRepository { get;  }

        /// <summary>
        /// Allows queries and data management for data regarding Collaboration Spaces
        /// </summary>
        ICollaborationSpaceRepository CollaborationSpaceRepository { get;  }

        /// <summary>
        /// Allows queries and data management for data regarding Bands
        /// </summary>
        IRepository<Band> BandRepository { get; }

        /// <summary>
        /// Lookup lists for styles of music
        /// </summary>
        IRepository<GenreLookUp> GenreLookUpRepository { get; }

        /// <summary>
        /// Allows queries and data management for data regarding Artist Skills
        /// </summary>
        IRepository<ArtistSkill> ArtistSkillRepository { get; }

        /// <summary>
        /// Saves data when state of objects has been changed
        /// </summary>
        void Save();

    }
}