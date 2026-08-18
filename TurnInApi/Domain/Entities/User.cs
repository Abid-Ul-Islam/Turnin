namespace Domain.Entities;

public class User
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string RoleId { get; set; }
    public string PasswordHash { get; set; }
    
    public Role Role { get; set; }
    public ICollection<CourseOffering> Teaching { get; set; } = [];
    public ICollection<CourseOffering> EnrolledCourses { get; set; } = [];
    public ICollection<Submission> AssignmentSubmissions { get; set; } = [];
}