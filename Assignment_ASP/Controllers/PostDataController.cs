using Assignment_ASP.Data;
using Assignment_ASP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostDataController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger<PostDataModel> logger;

        public PostDataController(ApplicationDbContext dbContext , ILogger<PostDataModel> logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<PostDataModel> postdata = dbContext.postData.ToList();
                if (postdata.Count == 0)
                {
                    return NotFound();
                }
                return Ok(postdata);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpGet]
        [Route("{id=string}")]
        public IActionResult GetById([FromRoute] string? st)
        {

            try
            {
                PostDataModel postData = dbContext.postData.Find(st);
                if (postData == null)
                    return NotFound();
                return Ok(postData);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostDataModel postData)
        {
            try
            {
                if (postData == null)
                {
                    return BadRequest();
                }
                dbContext.postData.Add(postData);
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw;
            }
        }

        [HttpPut]
        
        public IActionResult Update([FromBody] PostDataModel postData)
        {
            try
            { 
                dbContext.postData.Update(postData);
                dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                throw ;
            }
        }

        [HttpDelete]
        [Route("{name=String}")]
        public IActionResult Delete([FromRoute] string name)
        {
            try
            {
                PostDataModel? postDataModel = dbContext.postData.Find(name);
                if (postDataModel == null)
                    return NotFound();
                dbContext.postData.Remove(postDataModel);
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
