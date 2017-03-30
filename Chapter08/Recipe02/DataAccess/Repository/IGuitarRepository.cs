using Recipe02.DataAccess.Entities;
using System.Collections.Generic;

namespace Recipe02.DataAccess.Repository
{
    public interface IGuitarRepository
    {
        IList<Guitar> GetAllGuitars();
    }
}
