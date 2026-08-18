using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.HasKey(a => a.Id);
        
        builder.Property(a => a.Title)
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(a => a.MaxPoints)
            .IsRequired();
        
        builder.Property(a => a.DueDate)
            .IsRequired();

        builder.Property(a => a.Status)
            .HasConversion<string>()
            .IsRequired();

        builder.HasMany(a => a.Submissions)
            .WithOne(a => a.Assignment)
            .HasForeignKey(a => a.AssignmentId)
            .IsRequired();
    }
}