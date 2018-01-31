using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MailWebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EmailController : Controller
    {
        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(new
            {
                message = "heh"
            });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]EmailDataModel data)
        {
        }
    }
}
