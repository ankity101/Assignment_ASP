using Assignment_ASP.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_ASP.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

         public DbSet<PostDataModel> postData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostDataModel>().HasData(
                 new PostDataModel { Name="Test"  , PostImage="Test-img.jpg" , ProfileImage="Profile-test-img.jpg", Time="18th Aug"}
                );
        }

    }
}
