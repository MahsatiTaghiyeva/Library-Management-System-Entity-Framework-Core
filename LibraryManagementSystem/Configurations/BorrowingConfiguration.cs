using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class BorrowingConfiguration : IEntityTypeConfiguration<Borrowing>
{
    public void Configure(EntityTypeBuilder<Borrowing> builder)
    {
        builder.ToTable("Borrowings");
        builder.HasKey(b => b.Id);

        builder.HasOne(b => b.Member)
        .WithMany(m => m.Borrowings)
        .HasForeignKey(b => b.MemberId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(b => b.Book)
        .WithMany(book => book.Borrowings)
        .HasForeignKey(b => b.BookId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

        builder.Property(b => b.BorrowDate)
        .IsRequired();
        builder.Property(b => b.DueDate)
        .IsRequired();
        builder.Property(b => b.ReturnDate)
        .IsRequired();
        
    }
}