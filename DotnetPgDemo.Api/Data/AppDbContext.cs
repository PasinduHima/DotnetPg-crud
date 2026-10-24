using DotnetPgDemo.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetPgDemo.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}