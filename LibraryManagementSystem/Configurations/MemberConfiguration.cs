using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Members");
        builder.HasKey(m => m.Id);

        builder.HasIndex(m => m.Email)
        .IsUnique();

        builder.Property(m => m.FullName)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(m => m.PhoneNumber)
        .IsRequired()
        .HasMaxLength(15);

        builder.Property(m => m.RegistrationDate)
        .IsRequired();
    }
}