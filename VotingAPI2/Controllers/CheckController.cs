using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingAPI2.Controllers
{
    [Route("/api/hello")]
    public class CheckController: ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> Hello()
        {
            return Ok("Hello");
        }
    }
}
