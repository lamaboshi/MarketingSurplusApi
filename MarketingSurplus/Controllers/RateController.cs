using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RateController : ControllerBase

    { 
        private readonly IRate db;
    public RateController(IRate _db)
    {
        db = _db;
    }
        [HttpGet("{companyId}")]
        [ActionName("GetRates")]
        public IActionResult GetRates(int companyId)
    {
        var data = db.GetRates(companyId);
        return Ok(data);
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var data = db.GetRate(id);
        if (data != null)
        {
            return Ok(data);
        }
        // return NotFound();
        return Ok(new List<object>());
    }
    [HttpPost]
    public IActionResult AddRate([FromBody] Rate rate, [FromQuery] int subId)
    {
        if (rate == null)
        {
            // return BadRequest();
            return Ok(new List<object>());
        }
        else
        {
            db.Save(rate,subId);
            return Ok();
        }
    }
    [HttpPut("{id}")]
    public IActionResult Put([FromBody] Rate rate)
    {
        if (rate == null || rate.Id == 0)
        {
            // return BadRequest();
            return Ok(new List<object>());
        }
        else
        {
            db.Update(rate);
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
