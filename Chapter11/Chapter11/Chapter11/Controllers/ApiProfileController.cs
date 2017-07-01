using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Chapter11.Models;

namespace Chapter11.Controllers
{
    [Produces("application/json")]
    [Route("api/profile")]
    public class ApiProfileController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public Profile Get(int id)
        {
            return new Profile
            {
                BannerImageUrl = "/images/SampleBackground1.jpg",
                ProfileImageUrl = "/images/profileSample.jpg",
                FirstName = "firstName",
                LastName = "lastName",
                Bio = "This is the Bio",
                Projects = new List<CollaborationProject> {
                    new CollaborationProject {
                        ProjectName = "Project 1",
                        Status = "Recruiting / Idea Exchange",
                        Created = DateTime.Parse("12/28/2016"),
                        Modified = DateTime.Parse("1/2/2017")
                    },
                    new CollaborationProject {
                        ProjectName = "Project 2",
                        Status = "Mixing",
                        Created = DateTime.Parse("12/28/2016"),
                        Modified = DateTime.Parse("1/2/2017")
                    }
                }
                

            };
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}