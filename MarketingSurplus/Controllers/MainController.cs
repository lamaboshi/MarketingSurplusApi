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
        [HttpGet("{idOrder}")]
        [ActionName("GetOrderDetails")]
        public IActionResult GetOrderDetails(int idOrder)
        {
            var data = db.GetOrderDetails(idOrder);
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
        [HttpPost]
        [ActionName("SaveOrder")]
        public IActionResult SaveOrder([FromBody] SaveOrderRequestDto request)
        {
            if (request != null)
            {
               var result= db.SaveOrder(request);
                return Ok(result);
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
    }
}
