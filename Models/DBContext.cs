using Microsoft.EntityFrameworkCore;

namespace Crudv3.Models;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }


    public DbSet<Student> Students { get; set; }

    public DbSet<Professor> Professors { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Professor>()
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();
    }
}