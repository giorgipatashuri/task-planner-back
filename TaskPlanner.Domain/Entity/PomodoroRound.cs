using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class PomodoroRound : IAuditible
{
    public long Id { get; set; }
    
    public int TotalSeconds { get; set; }
    public bool? IsCompleted { get; set; }
    
    public PomodoroSession PomodoroSession { get; set; }
    
    public long PomodoroSessionId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}