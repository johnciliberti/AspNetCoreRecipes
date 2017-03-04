using System;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Provides Unit of work pattern for data access and exposes set of repository classes
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private MoBContext _context = new MoBContext();
        private IArtistRepository _ArtistRepository;
        private IRepository<Band> _BandRepository;
        private ICollaborationSpaceRepository _CollaborationSpaceRepository;
        private IRepository<GenreLookUp> _GenreLookUpRepository;
        private IRepository<ArtistSkill> _ArtistSkillRepository;

        ///// <summary>
        ///// Allows Class to be created using supplied connection string
        ///// </summary>
        ///// <param name="connectionString"></param>
        public UnitOfWork(string connectionString)
        {
            _context = new MoBContext(connectionString);
        }

        /// <summary>
        /// Allows class to be created using DB Context injected by application
        /// </summary>
        /// <param name="context"></param>
        public UnitOfWork(MoBContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Allows queries and data management for data regarding Artist Skills
        /// </summary>
        public IRepository<ArtistSkill> ArtistSkillRepository
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
        /// <summary>
        /// Allows queries and data management for data regarding Genres
        /// </summary>
        public IRepository<GenreLookUp> GenreLookUpRepository
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
        /// <summary>
        /// Allows queries and data management for data regarding Artists
        /// </summary>
        public IArtistRepository ArtistRepository
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

        /// <summary>
        /// Allows queries and data management for data regarding Collaboration Spaces
        /// </summary>
        public ICollaborationSpaceRepository CollaborationSpaceRepository
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

        /// <summary>
        /// Allows queries and data management for data regarding Bands
        /// </summary>
        public IRepository<Band> BandRepository
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

        /// <summary>
        /// Saves changes made to any of the data to the data store
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        /// <summary>
        /// Allows the object to be disposed by the garbage collector
        /// </summary>
        /// <param name="disposing"></param>
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

        /// <summary>
        /// Allows the object to be disposed by the garbage collector
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}