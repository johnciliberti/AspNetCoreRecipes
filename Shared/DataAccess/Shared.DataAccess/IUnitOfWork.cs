using System;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        ArtistRepository ArtistRepository { get;  }
        CollaborationSpaceRepository CollaborationSpaceRepository { get;  }
        Repository<Band> BandRepository { get; }

        Repository<GenreLookUp> GenreLookUpRepository { get; }

        Repository<ArtistSkill> ArtistSkillRepository { get; }
        void Save();

    }
}