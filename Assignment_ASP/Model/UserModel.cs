namespace Assignment_ASP.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public FriendsModel FriendList { get; set; }

    }
}
