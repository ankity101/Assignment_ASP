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

        public  DbSet<FriendsModel> friends { get; set; }

        public DbSet<UserModel> users { get; set; }

        private List<FriendsModel> GetFriends()
        {
            return Enumerable.Range(1, 100)
                .Select(index => new FriendsModel
                {
                    Name = $"Name{index}",
                    ProfileImage = $"Photo{index}.jpg"
                })
                .ToList();
        }
        private List<UserModel> GetUsers()
        {
            return Enumerable.Range(1, 100)
                .Select(index => new UserModel
                {
                    UserModelId = index,
                    Name = $"Name{index}",
                    ProfileImage = $"Photo{index}.jpg"
                })
                .ToList();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostDataModel>().HasData(
                 new PostDataModel { Name="Test"  , PostImage="Test-img.jpg" , ProfileImage="Profile-test-img.jpg", Time="18th Aug"}
                );
            
           

             

            modelBuilder.Entity<UserFriends>()
                .HasKey(uf => new { uf.UserModelId, uf.Name });
            modelBuilder.Entity<UserFriends>()
                .HasOne(uf => uf.Users)
                .WithMany(uf => uf.friends)
                .HasForeignKey(uf => uf.UserModelId);

            modelBuilder.Entity<UserFriends>()
                .HasOne(uf => uf.friends)
                .WithMany(uf => uf.users)
                .HasForeignKey(uf => uf.Name);

            modelBuilder.Entity<FriendsModel>().
               HasData(GetFriends());
            modelBuilder.Entity<UserModel>().
               HasData(GetUsers());

        }

    }
}
