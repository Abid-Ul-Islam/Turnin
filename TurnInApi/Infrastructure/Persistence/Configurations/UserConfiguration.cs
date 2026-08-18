using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Email)
            .HasMaxLength(256)
            .IsRequired();

        builder.HasIndex(u => u.Email)
            .IsUnique();
        
        builder.Property(u => u.FirstName)
            .HasMaxLength(256)
            .IsRequired();
        
        builder.Property(u => u.LastName)
            .HasMaxLength(256)
            .IsRequired();
        
        builder.HasOne(a => a.Role)
            .WithMany(c => c.Users)
            .HasForeignKey(a => a.RoleId)
            .IsRequired();

        builder.HasMany(u => u.EnrolledCourses)
            .WithMany(c => c.Students);
        
        builder.HasMany(u => u.Teaching)
            .WithOne(c => c.Teacher)
            .HasForeignKey(c => c.TeacherId)
            .IsRequired();
        
        builder.HasMany(u => u.AssignmentSubmissions)
            .WithOne(c => c.Student)
            .HasForeignKey(c => c.StudentId)
            .IsRequired();
    }
}