using System.ComponentModel.DataAnnotations;

namespace Assignment_ASP.Model
{
    public class PostDataModel
    {
        [Key]
        public string Name { get; set; }

        public string ProfileImage { get; set; }

        public string  PostImage { get; set; }

        public string Time { get; set; }

    }
}
