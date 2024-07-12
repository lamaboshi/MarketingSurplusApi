using MarketingSurplus.Dto;
using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMain db;
        public MainController(IMain _db)
        {
            db = _db;
        }
        [HttpGet("{userId}")]
        [ActionName("GetAllPosts")]
        public IActionResult GetAllPosts(int userId)
        {
            var data = db.GetAllPosts(userId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{userId}")]
        [ActionName("GetOrderDetails")]
        public IActionResult GetOrderDetails(int userId)
        {
            var data = db.GetOrderDetails(userId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }

        [HttpGet("{companyId}")]
        [ActionName("GetOrderDetailsForCompany")]
        public IActionResult GetOrderDetailsForCompany(int companyId)
        {
            var data = db.GetOrderDetailsForCompany(companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{id}")]
        [ActionName("GetSubscriptionPosts")]
        public IActionResult GetSubscriptionPosts(int id)
        {
            var data = db.GetSubscriptionPosts(id);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{companyId}")]
        [ActionName("GetAllCompanyProduct")]
        public IActionResult GetAllCompanyProduct(int companyId)
        {
            var data = db.GetAllCompanyProduct(companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{companyId}")]
        [ActionName("GetAllCompanyUsers")]
        public IActionResult GetAllCompanyUsers(int companyId)
        {
            var data = db.GetAllCompanyUsers(companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpPost]
        [ActionName("SaveOrder")]
        public IActionResult SaveOrder([FromBody] Order order)
        {
            if (order != null)
            {
               var result= db.SaveOrder(order);
                return Ok(result);
            }
            else return Ok(new List<object>());

        }
        [HttpPost]
        [ActionName("SaveOrderProduct")]
        public IActionResult SaveOrderProduct([FromBody] OrderProduct orderProduct)
        {
            if (orderProduct != null)
            {
                 db.SaveOrderProduct(orderProduct);
                return Ok();
            }
            else return Ok(new List<object>());

        }

        [HttpPost]
        [ActionName("AddCompanyProduct")]
        public IActionResult AddCompanyProduct([FromBody] SaveCompanyProduct saveCompany)
        {
            if (saveCompany != null)
            {
                db.AddCompanyProduct(saveCompany);
                return Ok();
            }
            else return Ok(new List<object>());

        }

        [HttpPost("{idOrder}")]
        [ActionName("UpdateStutasOrder")]
        public IActionResult UpdateStutasOrder( int idOrder,[FromBody] int Stutas)
        {
            db.UpdateStutasOrder(idOrder, Stutas);
            return Ok();
        }

    }
}
