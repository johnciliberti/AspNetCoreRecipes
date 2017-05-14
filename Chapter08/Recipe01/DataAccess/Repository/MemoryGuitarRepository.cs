using System.Collections.Generic;
using Recipe02.DataAccess.Entities;

namespace Recipe02.DataAccess.Repository
{
    public class MemoryGuitarRepository : IGuitarRepository
    {
        public IList<Guitar> GetAllGuitars()
        {
            return new List<Guitar> {
                new Guitar { BodyStyle = GuitarBodyStyle.Solid, Brand = "Gibson", GuitarId = 1, Model = "Les Paul", NumberOfStrings = 6, Year = 1976},
                new Guitar { BodyStyle = GuitarBodyStyle.Solid, Brand = "Gibson", GuitarId = 2, Model = "SG", NumberOfStrings = 6, Year = 1978},
                new Guitar { BodyStyle = GuitarBodyStyle.Solid, Brand = "Fender", GuitarId = 3, Model = "Stratocaster", NumberOfStrings = 6, Year = 1970},
                new Guitar { BodyStyle = GuitarBodyStyle.Solid, Brand = "Fender", GuitarId = 4, Model = "Telecaster", NumberOfStrings = 6, Year = 1966}
            };
        }
    }
}
