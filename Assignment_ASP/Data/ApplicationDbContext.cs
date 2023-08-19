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

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostDataModel>().HasData(
                 new PostDataModel { Name="Test"  , PostImage="Test-img.jpg" , ProfileImage="Profile-test-img.jpg", Time="18th Aug"}
                );

            modelBuilder.Entity<FriendsModel>().HasData(
                new FriendsModel { Name="Saurabh",ProfileImage="Profile-img.jpg"  },
                new FriendsModel { Name = "Abhishek", ProfileImage = "Abhishek-img.jpg" },
                new FriendsModel { Name = "Shivansh", ProfileImage = "SHivansh-img.jpg" },
                new FriendsModel { Name = "Ankush", ProfileImage = "Ankush-img.jpg" },
                new FriendsModel { Name = "Ayush", ProfileImage = "Ayush-img.jpg" },
                new FriendsModel { Name = "Deepak", ProfileImage = "Deepak-img.jpg" }
                );

            //modelBuilder.Entity<UserModel>().HasData(
            //    new UserModel 
            //    {
            //        FriendList= new FriendsModel { Name="Saurabh" ,ProfileImage="SaurabhImg.jpg"} ,
            //        Name="Ankit" ,
            //        Id = 27, ProfileImage="ankit-img.jpg" 
            //    }
            //    );

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

             

        }

    }
}
