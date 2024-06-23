﻿using MarketingSurplus.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth db;
        public AuthController(IAuth _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetAuth")]
        public IActionResult GetAuth([FromQuery] string email, [FromQuery] string password)
        {
            var data = db.GetAuth(email, password);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }

        [HttpGet]
        [ActionName("GetEmail")]
        public IActionResult GetEmail(string email)
        {
            var data = db.GetEmail(email);
            if (data != null)
                return Ok(data);
            else
                return Ok(new List<object>());
        }
    }
}
