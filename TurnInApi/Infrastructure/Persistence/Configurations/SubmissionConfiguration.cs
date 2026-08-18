using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class SubmissionConfiguration : IEntityTypeConfiguration<Submission>
{
    public void Configure(EntityTypeBuilder<Submission> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.SubmissionTime)
            .IsRequired();

        builder.Property(s => s.Feedback)
            .HasMaxLength(1000);

        builder.Property(s => s.AcquiredMarks)
            .HasPrecision(10, 2)
            .IsRequired();

        builder.Property(s => s.Status)
            .HasConversion<string>()
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(s => s.FileUrl)
            .HasMaxLength(2048)
            .IsRequired();
        
        builder.HasIndex(s => new
            {
                s.AssignmentId,
                s.StudentId
            })
            .IsUnique();
    }
}