using Recipe03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Recipe03.Controllers
{
    public class CellPhoneController : Controller // ApiController
    {
        [HttpGet("api/[controller]")]
        public ICollection<CellPhone> GetPhones()
        {
            return CellPhoneManager.GetPhones();
        }

    }
}
