using Expensly.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Expensly.Data;

public class ExpenslyContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public ExpenslyContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection"));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasIndex(e => new { e.Email, e.UserName })
            .IsUnique();
    }

    public DbSet<User> Users { get; init; }
    public DbSet<Category> Categories { get; init; }
}