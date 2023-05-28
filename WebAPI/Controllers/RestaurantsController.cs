using FoodDeliveryAppAPI.Context;
using FoodDeliveryAppAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAppAPI.Controllers
{
    public class RestaurantsController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public RestaurantsController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        [EnableCors("MyPolicy")]
        [HttpPost("AddRestaurant")]

        public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restObj)
        {
            if(restObj == null)
            {
                return BadRequest();
            }
            var restaurant = await _dbContext.Restaurants.FirstOrDefaultAsync(y => y.Id == restObj.Id && y.Name == restObj.Name);
            if (restaurant == null)
            {
                return NotFound(new { Message = "No restaurant" });
            }
            return Ok(new
            {
                Message = "Restaurant added succesfully"
            });
        }
    }
}
