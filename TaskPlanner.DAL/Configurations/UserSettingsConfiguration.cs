using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlanner.Domain.Entity;

namespace TaskPlanner.DAL.Configurations;

public class UserSettingsConfiguration : IEntityTypeConfiguration<UserSettings>
{
    public void Configure(EntityTypeBuilder<UserSettings> builder)
    {
        builder.Property(x => x.WorkInterval).IsRequired().HasDefaultValue(50);
        builder.Property(x => x.BreakInterval).IsRequired().HasDefaultValue(10);
        builder.Property(x => x.IntervalsCount).IsRequired().HasDefaultValue(7);
    }
}