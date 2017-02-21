using Recipe03.Models;
using Microsoft.AspNetCore.Mvc;


namespace Recipe03.Controllers
{
    public class CellPhoneController : Controller // ApiController
    {
        [HttpGet("api/[controller]")]
        public IActionResult GetPhones()
        {
            return Ok(CellPhoneManager.GetPhones());
        }


    }
}
