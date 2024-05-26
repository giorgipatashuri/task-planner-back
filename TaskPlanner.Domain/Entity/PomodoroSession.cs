using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class PomodoroSession : IAuditible
{
    public long Id { get; set; }
    
    public bool? IsCompleted { get; set; }
    
    public List<PomodoroRound> PomodoroRounds { get; set; }
    
    public User User { get; set; }
    
    public long UserId { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}