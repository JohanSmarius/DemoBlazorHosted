using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorHosted.Shared;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var result = new List<User>()
            {
                new User()
                {
                    Id = new Random().Next(1000),
                    Name = "Daniel Roth",
                    Email = "daniel@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture = "https://avatars2.githubusercontent.com/u/1874516?s=460&v=4"
                },
                new User()
                {
                    Id = new Random().Next(1000),
                    Name = "Luke Latham",
                    Email = "luke@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture =
                        "https://avatars0.githubusercontent.com/u/1622880?s=460&v=4"
                },
                new User()
                {
                    Id = new Random().Next(1000),
                    Name = "Scott Hanselman",
                    Email = "scott@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture = "https://avatars0.githubusercontent.com/u/2892?s=460&v=4"
                },
                new User()
                {
                    Id = new Random().Next(1000),
                    Name = "Scott Guthrie",
                    Email = "scott@microsoft.com",
                    PhoneNumber = "12345468",
                    Picture = "https://sec.ch9.ms/ch9/e6c4/ea6aa4d2-472a-46c1-a31e-b3d86daee6c4/scottguazurewebsitesendpoints_960.jpg?v=744001bc6a23bbf8533bfb48dc1e9372cfe8dbe985ae55b3f5e950865fce9395"
                }
            };

            return Ok(result);
        } 
    }
}
