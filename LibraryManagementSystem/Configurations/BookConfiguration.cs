using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");
        builder.HasKey(b => b.Id);

        builder.HasOne(b => b.Author)
        .WithMany(a => a.Books)
        .HasForeignKey(b => b.AuthorId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.Category)
        .WithMany(c => c.Books)
        .HasForeignKey(b => b.CategoryId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        builder.Property(b => b.Title)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasIndex(b => b.ISBN)
        .IsUnique();

        builder.Property(b => b.Price)
        .IsRequired()
        .HasPrecision(5,2);
    }
}