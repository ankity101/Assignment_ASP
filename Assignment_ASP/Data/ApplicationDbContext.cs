using Assignment_ASP.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_ASP.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public PostDataModel postDataModel { get; set; }

    }
}
