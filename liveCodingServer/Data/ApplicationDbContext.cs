using liveCodingServer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace liveCodingServer.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; } = null!;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Post>().HasData(
            new Post
            {
                id = Guid.NewGuid(),
                body = "121212",
                title = "12312312",
                userId = 5
            });
            
    }

}

