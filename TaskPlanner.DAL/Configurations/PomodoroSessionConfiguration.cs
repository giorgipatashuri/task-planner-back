using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlanner.Domain.Entity;

namespace TaskPlanner.DAL.Configurations;

public class PomodoroSessionConfiguration : IEntityTypeConfiguration<PomodoroSession>
{
    public void Configure(EntityTypeBuilder<PomodoroSession> builder)
    {
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.HasMany(p => p.PomodoroRounds)
            .WithOne(pr => pr.PomodoroSession)
            .HasForeignKey(pr => pr.PomodoroSessionId)
            .HasPrincipalKey(p => p.Id);
        
    }
}