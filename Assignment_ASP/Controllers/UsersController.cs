using Assignment_ASP.Data;
using Assignment_ASP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public UsersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
           List<UserModel> users =  dbContext.users.ToList();
            if(users.Count == 0)
            {
                return NotFound();
            }
            return Ok(users);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get( [FromRoute]  int id)
        {
           UserModel users =  dbContext.users.Find(id);
            if(users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }


        [HttpPost]
        public IActionResult Post([FromBody] UserModel userModel)
        {
            if(userModel.UserModelId== 0 || userModel == null)
            {
                return BadRequest();
            }
            dbContext.users.Add(userModel);
            dbContext.SaveChanges();
            return Ok(userModel);
        }


        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Post([FromRoute] int id ,   [FromBody] UserModel userModel)
        {
            if (id == 0 || userModel == null)
                return BadRequest();
            UserModel? users = dbContext.users.Find(id);
            if (users == null)
                return NotFound();
            dbContext.users.Update(userModel);
            dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete( [FromRoute] int id)
        {
            if (id == 0)
                return BadRequest();
           UserModel user = dbContext.users.Find(id);
            if(user==null)
                return NotFound();
            dbContext.users.Remove(user);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
