using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlanner.Domain.Entity;

namespace TaskPlanner.DAL.Configurations;

public class PomodoroRoundConfiguration : IEntityTypeConfiguration<PomodoroRound>
{
    public void Configure(EntityTypeBuilder<PomodoroRound> builder)
    {
        builder.Property(pr => pr.Id).ValueGeneratedOnAdd();
        builder.Property(pr => pr.TotalSeconds).IsRequired();
    }
}