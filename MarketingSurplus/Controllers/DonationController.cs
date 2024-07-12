using MarketingSurplus.Infrastructure;
using MarketingSurplus.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IDonation db;
        public DonationController(IDonation _db)
        {
            db = _db;
        }
        [HttpGet("{charityId}")]
        [ActionName("GetAllCompanyForThis")]
        public IActionResult GetAllCompanyForThis(int charityId)
        {
            var data = db.GetAllCompanyForThis(charityId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{id}")]
        [ActionName("GetDonation")]
        public IActionResult GetDonation(int id)
        {
            var data = db.GetDonation(id);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{companyId}")]
        [ActionName("GetAllDonationForCompany")]
        public IActionResult GetAllDonationForCompany(int companyId)
        {
            var data = db.GetAllDonationForCompany(companyId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }
        [HttpGet("{charityId}")]
        [ActionName("GetAllOrder")]
        public IActionResult GetAllOrder(int charityId)
        {
            var data = db.GetAllOrder(charityId);
            if (data != null) return Ok(data);
            else return Ok(new List<object>());

        }

        [HttpPost]
        [ActionName("SaveDonation")]
        public IActionResult SaveDonation([FromBody] Donation donation)
        {
            if (donation != null)
            {
                var result = db.SaveDonation(donation);
                return Ok(result);
            }
            else return Ok(new List<object>());

        }
        [HttpPost]
        [ActionName("SaveProductDonation")]
        public IActionResult SaveProductDonation([FromBody] ProductDonation productDonation)
        {
            if (productDonation != null)
            {
                db.SaveProductDonation(productDonation);
                return Ok();
            }
            else return Ok(new List<object>());

        }
    }
}
