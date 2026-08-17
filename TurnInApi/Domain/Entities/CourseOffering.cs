namespace Domain.Entities;

public class CourseOffering
{
    public string Id { get; set; }
    public string Title  { get; set; }
    public string Semester  { get; set; }
    public int Year  { get; set; }
    public string TeacherId { get; set; }
    
    public User Teacher { get; set; }
    public List<User> Students { get; set; }
    public ICollection<Assignment> Assignments { get; set; } = [];
}