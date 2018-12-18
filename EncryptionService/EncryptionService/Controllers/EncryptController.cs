using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EncryptionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncryptController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get(string data, string key)
        {
            return "hello"; 
        }
    }
}