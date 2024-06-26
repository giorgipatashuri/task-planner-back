using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class User : IAuditible
{
    public long Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Email { get; set; }
    
    public string? Password { get; set; }
    
    public UserSettings UserSettings { get; set; }
    
    public List<Task> Tasks { get; set; }
    
    public List<TimeBlock> TimeBlocks { get; set; }
    
    public List<PomodoroSession> PomodoroSessions { get; set; }
     
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}