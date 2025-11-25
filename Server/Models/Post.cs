using System.Collections.Generic;

namespace Models;

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
    public int UserId { get; set; }

    // Navigation properties
    public User? User { get; set; }
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public Post()
    {
    }

    public Post(int id, string? title, string? body, int userId)
    {
        Id = id;
        Title = title;
        Body = body;
        UserId = userId;
    }
}
