using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rv.CatApi.Cats;

public class CatEntityTypeConfiguration : IEntityTypeConfiguration<Cat>
{
    public void Configure(EntityTypeBuilder<Cat> builder)
    {
        builder
            .ToTable("cat", "cats")
            .HasKey(o => o.Id);

        builder
            .Property(o => o.Id)
            .HasColumnName("id");

        builder
            .Property(o => o.Name)
            .HasColumnName("name");

        builder
            .Property(o => o.Summary)
            .HasColumnName("summary");

        builder
            .Property(o => o.Home)
            .HasColumnName("home")
            .HasColumnType("geometry(point, 3857)");
    }
}
