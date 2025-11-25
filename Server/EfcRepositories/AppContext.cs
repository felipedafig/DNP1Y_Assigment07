using Microsoft.EntityFrameworkCore;
using Models;
using System.IO;

namespace EfcRepositories;

public class AppContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Comment> Comments => Set<Comment>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Path relative to WebAPI1 directory (where the app runs)
        var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "EfcRepositories", "app.db");
        var fullPath = Path.GetFullPath(dbPath);
        optionsBuilder.UseSqlite($"Data Source={fullPath}");
    }
}