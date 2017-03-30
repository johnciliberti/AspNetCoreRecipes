using AspNetCoreMvcRecipes.Shared.DataAccess;
using System.Collections.Generic;

namespace Chapter07.Web.ViewModels
{
    public class ArtistListViewModel
    {
        public IList<Artist> Artists { get; set; }
        public int RecordsFound { get; set; }
        public Artist SelectedArtist { get; set; }
        public bool DeletedSuccessfully { get; set; }
        public string Message { get; set; }
    }
}
