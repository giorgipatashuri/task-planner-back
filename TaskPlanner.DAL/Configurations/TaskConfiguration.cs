using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskPlanner.DAL.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<Domain.Entity.Task>
{
    public void Configure(EntityTypeBuilder<Domain.Entity.Task> builder)
    {
        builder.Property(x => x.UserId).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(2000);
        builder.Property(x => x.IsCompleted).HasDefaultValue(false);
        builder.Property(x => x.TaskPriority).IsRequired().HasConversion<string>();
    }
}