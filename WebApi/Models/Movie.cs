// Blog.Domain/Comment.cs
namespace WebApi.Models
{
    public class Movie
    {
        public int Id {get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int Release_Year { get; set; }
    }
}