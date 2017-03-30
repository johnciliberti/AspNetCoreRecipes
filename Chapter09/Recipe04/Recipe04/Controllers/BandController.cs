using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;

namespace Recipe04.Controllers
{
    [Produces("application/json")]
    [Route("api/Band")]
    public class BandController : Controller
    {
        MoBContext _context;
        public BandController(MoBContext context)
        {
            _context = context;
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyBandName(string bandName)
        {
            if(string.IsNullOrWhiteSpace(bandName))
            {
                return BadRequest();
            }
            var bandsMatching = _context.Bands.Count(b => b.BandName.ToLower() == bandName.ToLower().Trim());
            if (bandsMatching > 0)
            {
                return Json(data: $"The Band Name {bandName} is already in use.");
            }
            else
            {
                return Json(data: true);
            }
        }

        
    }
}
