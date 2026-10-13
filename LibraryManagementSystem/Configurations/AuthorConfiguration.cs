using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FullName)
        .IsRequired()
        .HasMaxLength(150);

        builder.Property(a => a.Country)
        .IsRequired()
        .HasMaxLength(150);

        builder.Property(a => a.BirthDate)
        .IsRequired();
    }
}