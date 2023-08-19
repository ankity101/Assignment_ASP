using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_ASP.Model
{
    public class FriendsModel
    {
        [Key]
        public string Name { get; set; }

        public string ProfileImage { get; set; }

        //Navigation Property
        public ICollection<UserFriends> users { get; set; }
    }
}
