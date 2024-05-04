namespace TaskPlanner.Domain.Interface;

public interface IAuditible
{
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
}