﻿using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PayMethodController : ControllerBase
    {
        private readonly IPayMethod db;
        public PayMethodController(IPayMethod _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetPayMethods()
        {
           var data = db.GetPayMethods();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetPayMethod(id);
            if (data != null)
            {
                return Ok(data);
            }
            // return NotFound();
            return Ok(new List<object>());
        }
        [HttpPost]
        public IActionResult AddPayMethod([FromBody] PayMethod payMethod)
        {
            if (payMethod == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(payMethod);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] PayMethod payMethod)
        {
            if (payMethod == null || payMethod.Id == 0)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(payMethod);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
