using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_ASP.Model
{
    public class UserModel
    {
        
        public int UserModelId { get; set; }
        public string Name { get; set; }

        public string ProfileImage { get; set; }

       


        //Navigation Property

        public ICollection<UserFriends> friends { get; set; }  

    }
}
