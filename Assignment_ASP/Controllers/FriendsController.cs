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

        public FriendsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GET()
        {
            List<FriendsModel> friendList = dbContext.friends.ToList();
            if(friendList.Count == 0) {
                return NotFound();
            }
            return Ok(friendList);
        }

        [HttpPost]
        public IActionResult POST( [FromBody] FriendsModel friendsModel)
        {
             if(ModelState.IsValid)
             { 
                  dbContext.friends.Add(friendsModel);
                dbContext.SaveChanges();
                return Ok();
             }
            return BadRequest();
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

                throw new Exception("Error Updating Request Contact Administrator");
            }
        }


        [HttpDelete]
        [Route("{name=String}")]
        public IActionResult Delete([FromRoute] string name)
        {
            FriendsModel? friendsModel = dbContext.friends.Find(name);
            if (friendsModel == null)
                return NotFound();
            dbContext.friends.Remove(friendsModel);
            dbContext.SaveChanges();
            return Ok();
        }


    }
}
