using Microsoft.AspNetCore.Mvc;
using System;

namespace ComplimentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComplimentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCompliment()
        {
            var rng = new Random();
            var compliment = ComplimentData.Compliments[rng.Next(ComplimentData.Compliments.Length)];
            return Ok(compliment);
        }
    }
}
