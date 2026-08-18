using Domain.Enums;

namespace Domain.Entities;

public class Submission
{
    public string Id { get; set; }
    public DateTime SubmissionTime { get; set; }
    public string Feedback {get; set;}
    public decimal AcquiredMarks {get; set;}
    public SubmissionStatus Status {get; set;}
    public string FileUrl {get; set;}
    
    public string AssignmentId {get; set;}
    public Assignment Assignment {get; set;}
    
    public string StudentId {get; set;}
    public User Student {get; set;}
}