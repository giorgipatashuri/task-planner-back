using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class TimeBlock : IAuditible
{
    public long Id { get; set; }

    public string Name { get; set; }
    
    public string Color { get; set; }

    public int Duration { get; set; }
    
    public int Order { get; set; }
    
    public User User { get; set; }
    public long UserId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}