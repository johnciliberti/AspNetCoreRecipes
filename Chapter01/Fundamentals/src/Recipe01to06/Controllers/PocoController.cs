// code is used in Chapter 01 - Recipe 04 Listing 1-1
using Microsoft.AspNetCore.Mvc;

namespace Chapter01.Fundamentals.Controllers
{
    public class PocoController
    {
        public IActionResult Index()
        {
            return new JsonResult("{Poco:True}");
        }
    }
}
