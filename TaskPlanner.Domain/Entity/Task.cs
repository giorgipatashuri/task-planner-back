using TaskPlanner.Domain.Enum;
using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class Task : IAuditible
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public TaskPriority TaskPriority { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public User User { get; set; }
    public long UserId { get; set; }
    
    
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}