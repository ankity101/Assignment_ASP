using Assignment_ASP.Data;
using Assignment_ASP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<FriendsModel> logger;

        public FriendsController(ApplicationDbContext dbContext , ILogger<FriendsModel> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult GET()
        {
            try
            {
                List<FriendsModel> friendList = dbContext.friends.ToList();
                if (friendList.Count == 0)
                {
                    return NotFound();
                }
                return Ok(friendList);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpPost]
        public IActionResult POST( [FromBody] FriendsModel friendsModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.friends.Add(friendsModel);
                    dbContext.SaveChanges();
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpPut]

        public IActionResult Update([FromBody] FriendsModel friendsModel)
        {
            try
            {

                dbContext.friends.Update(friendsModel);
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
            
        }


        [HttpDelete]
        [Route("{name=String}")]
        public IActionResult Delete([FromRoute] string name)
        {
            try
            {
                FriendsModel? friendsModel = dbContext.friends.Find(name);
                if (friendsModel == null)
                    return NotFound();
                dbContext.friends.Remove(friendsModel);
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }


    }
}
