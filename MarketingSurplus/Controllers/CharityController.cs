using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CharityController : ControllerBase
    {
        private readonly ICharity db;
        public CharityController(ICharity _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetCharities")]
        public IActionResult GetCharities()
        {
            List<Charity> data = db.GetCharities();
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var data = db.GetCharity(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());// return NotFound();

        }


        [HttpPost]
        public IActionResult AddCharity([FromBody] Charity charity)
        {
            if (charity == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                bool data = db.IsExisting(charity.Email);
                if (data == false)
                {
                    db.Save(charity);
                    return Ok();
                }
                else return Ok(new List<object>());//return NotFound();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Charity charity)
        {
            if (charity == null || charity.Id == 0)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                db.Update(charity);
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult Password([FromQuery] int Id, [FromQuery] string password)
        {
            if (password == null || Id == 0)
            {
                return Ok(new List<object>());//return BadRequest();
            }
            else
            {
                db.ChangePassword(Id, password);
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
