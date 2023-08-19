namespace Assignment_ASP.Model
{
    public class UserFriends
    {
        public int UserModelId { get; set; }

        public UserModel Users { get; set; }

        public string Name { get; set; }

        public FriendsModel friends { get; set; }
    }
}
