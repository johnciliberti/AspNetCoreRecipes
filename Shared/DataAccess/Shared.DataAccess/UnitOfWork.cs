using System;

namespace Mvc6Recipes.Shared.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private MoBContext _context = new MoBContext();
        private ArtistRepository _ArtistRepository;
        private Repository<Band> _BandRepository;
        private CollaborationSpaceRepository _CollaborationSpaceRepository;
        private Repository<GenreLookUp> _GenreLookUpRepository;
        private Repository<ArtistSkill> _ArtistSkillRepository;

        public Repository<ArtistSkill> ArtistSkillRepository
        {
            get
            {
                if (_ArtistSkillRepository == null)
                {
                    _ArtistSkillRepository = new Repository<ArtistSkill>(_context);
                }
                return _ArtistSkillRepository;
            }
        }

        public Repository<GenreLookUp> GenreLookUpRepository
        {
            get
            {
                if (_GenreLookUpRepository == null)
                {
                    _GenreLookUpRepository = new Repository<GenreLookUp>(_context);
                }
                return _GenreLookUpRepository;
            }
        }

        public ArtistRepository ArtistRepository
        {
            get
            {
                if (_ArtistRepository == null)
                {
                    _ArtistRepository = new ArtistRepository(_context);
                }
                return _ArtistRepository;
            }
        }

        public CollaborationSpaceRepository CollaborationSpaceRepository
        {
            get
            {
                if (_CollaborationSpaceRepository == null)
                {
                    _CollaborationSpaceRepository = new CollaborationSpaceRepository(_context);
                }
                return _CollaborationSpaceRepository;
            }
        }

        public Repository<Band> BandRepository
        {
            get
            {
                if (_BandRepository == null)
                {
                    _BandRepository = new Repository<Band>(_context);
                }
                return _BandRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}