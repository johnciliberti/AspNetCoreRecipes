using System.Net;
using System.Net.Http;
using System.Web.Http;
using Recipe03.Models;

namespace Recipe03.Controllers
{
    public class CellPhoneController : ApiController
    {
        public HttpResponseMessage GetPhones()
        {
            return Request.CreateResponse(HttpStatusCode.OK, CellPhoneManager.GetPhones());
        }

    }
}
