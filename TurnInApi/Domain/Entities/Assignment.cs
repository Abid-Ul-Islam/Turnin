using Domain.Enums;

namespace Domain.Entities;

public class Assignment
{
    public string Id { get; set; }
    public string Title { get; set; }
    public int MaxPoints { get; set; }
    public DateTime DueDate { get; set; }
    public AssignmentStatus Status { get; set; }
    
    public string CourseOfferingId { get; set; }
    public CourseOffering CourseOffering { get; set; }
}