using Assignment_ASP.Data;
using Assignment_ASP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Assignment_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<UserModel> logger;

        public UsersController(ApplicationDbContext dbContext , ILogger<UserModel> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            try
            {
                 
                //logger.LogWarning("Get ALl user Action Method Invoked");

                //logger.LogError("This is a error Log ,for testing Purposes");

                List<UserModel> users = dbContext.users.ToList();

                //logger.LogWarning($"Finished GetAll method with data :{JsonSerializer.Serialize(users)}");
                if (users.Count == 0)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get( [FromRoute]  int id)
        {
            try
            {

                UserModel users = dbContext.users.Find(id);
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] UserModel userModel)
        {
            try
            {
                if (userModel.UserModelId == 0 || userModel == null)
                {
                    return BadRequest();
                }
                dbContext.users.Add(userModel);
                dbContext.SaveChanges();
                return Ok(userModel);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }


        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Post([FromRoute] int id ,   [FromBody] UserModel userModel)
        {
            try
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
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete( [FromRoute] int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();
                UserModel user = dbContext.users.Find(id);
                if (user == null)
                    return NotFound();
                dbContext.users.Remove(user);
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
