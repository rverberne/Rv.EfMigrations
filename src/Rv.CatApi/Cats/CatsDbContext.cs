using Microsoft.EntityFrameworkCore;

namespace Rv.CatApi.Cats;

public class CatsDbContext : DbContext
{
    public CatsDbContext(DbContextOptions<CatsDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new CatEntityTypeConfiguration().Configure(modelBuilder.Entity<Cat>());
    }
}
