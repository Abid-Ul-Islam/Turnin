using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class CourseOfferingConfigurations : IEntityTypeConfiguration<CourseOffering>
{
    public void Configure(EntityTypeBuilder<CourseOffering> builder)
    {
        builder.HasKey(r => r.Id);
        
        builder.Property(r => r.Title)
            .HasMaxLength(256)
            .IsRequired();
        
        builder.Property(x => x.Semester)
            .HasConversion<string>()
            .IsRequired();
        
        builder.Property(x => x.Year)
            .IsRequired();

        builder.HasMany(c => c.Assignments)
            .WithOne(a => a.CourseOffering)
            .HasForeignKey(a => a.CourseOfferingId)
            .IsRequired();
    }
}