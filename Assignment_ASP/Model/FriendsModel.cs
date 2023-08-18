using System.ComponentModel.DataAnnotations;

namespace Assignment_ASP.Model
{
    public class FriendsModel
    {

        [Key]
        public string Name { get; set; }

        public string ProfileImage { get; set; }

    }
}
