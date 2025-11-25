using System.Collections.Generic;

namespace Models;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

    // Navigation properties
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public User()
    {
    }

    public User(int id, string? username, string? password)
    {
        Id = id;
        Username = username;
        Password = password;
    }
}