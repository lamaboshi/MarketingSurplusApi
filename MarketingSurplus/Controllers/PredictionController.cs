using MarketingSurplus.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;

namespace MarketingSurplus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelTrainingController : ControllerBase
    {
        private readonly RestaurantRatingService _ratingService;

        public ModelTrainingController(RestaurantRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost("train")]
        public ActionResult TrainModel()
        {
            var model = _ratingService.BuildAndTrainModel();
            // You can add code here to handle the trained model, such as evaluating its performance or using it for predictions.

            return Ok("Model trained successfully and saved to path.");
        }
    }

}
