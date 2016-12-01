using Microsoft.AspNetCore.Mvc;

namespace Fundamentals.Controllers
{
    public class PocoController
    {
        public IActionResult Index()
        {
            return new JsonResult("{Poco:True}");
        }
    }
}
