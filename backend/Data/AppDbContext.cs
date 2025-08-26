using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.Data
{

    /// AppDbContext: The EF Core gateway to your database.
    /// It manages the connection and maps your models to database tables.

    public class AppDbContext : DbContext
    {
        // Constructor: ASP.NET Core will inject DbContextOptions (including the connection string).
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets map your entity classes to database tables.
        // Example: TaskItem -> Tasks table
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
