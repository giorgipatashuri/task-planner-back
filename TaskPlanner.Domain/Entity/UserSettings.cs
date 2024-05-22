using TaskPlanner.Domain.Interface;

namespace TaskPlanner.Domain.Entity;

public class UserSettings
{
    public long UserId { get; set; }
    public int WorkInterval { get; set; }
    public int BreakInterval { get; set; }
    public int IntervalsCount { get; set; }
    
    public User User { get; set; }
}