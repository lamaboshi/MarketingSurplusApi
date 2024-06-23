﻿using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser db;
        public UserController(IUser _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetUser")]
        public IActionResult GetUser()
        {
            List<User> data = db.GetUsers();
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var data = db.GetUser(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());// return NotFound();

        }


        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                bool data = db.IsExisting(user.Email);
                if (data == false)
                {
                    db.Save(user);
                    return Ok();
                }
                else return Ok(new List<object>());//return NotFound();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
                db.Update(user);
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
        //[HttpGet]
        //public IActionResult GetFollowed([FromQuery] string email)
        //{
        //    if (email == null)
        //    {
        //        return Ok(new List<object>());// return BadRequest();
        //    }
        //    else
        //    {
        //        var data = db.GetFollowed(email);
        //        if (data != null)
        //        {
        //            return Ok(data);
        //        }
        //        else return Ok(new List<object>());//return NotFound();
        //    }
        //}
        //[HttpGet]
        //public IActionResult GetFollowedCount([FromQuery] string email)
        //{
        //    if (email == null)
        //    {
        //        return Ok(new List<object>());//return BadRequest();
        //    }
        //    else
        //    {
        //        var data = db.GetFollowedCount(email);
        //        if (data != -1)
        //        {
        //            return Ok(data);
        //        }
        //        else return Ok(new List<object>());//return NotFound();
        //    }
        //}
    }
}
