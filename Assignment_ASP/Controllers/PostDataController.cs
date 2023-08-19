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

        public PostDataController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<PostDataModel> postdata = dbContext.postData.ToList();
            if (postdata.Count == 0)
            {
                return NotFound();
            }
            return Ok(postdata);
        }

        [HttpGet]
        [Route("{id=string}")]
        public IActionResult GetById([FromRoute] string? st)
        {
             
            PostDataModel postData  =  dbContext.postData.Find(st);
            if(postData==null)
                return NotFound();
            return Ok(postData);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostDataModel postData)
        {
            if(postData  == null)
            {
                return BadRequest();
            }
             dbContext.postData.Add(postData);
            dbContext.SaveChanges();
            return Ok();
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

                throw new Exception("Error Updating Request Contact Administrator");
            }
        }

        [HttpDelete]
        [Route("{name=String}")]
        public IActionResult Delete([FromRoute] string name)
        {
           PostDataModel? postDataModel =  dbContext.postData.Find(name);
            if (postDataModel == null)
                return NotFound();
            dbContext.postData.Remove(postDataModel);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
