using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlanner.Domain.Entity;

namespace TaskPlanner.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(x => x.Password).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasOne(u => u.UserSettings)
            .WithOne(s => s.User)
            .HasForeignKey<UserSettings>(s => s.UserId)
            .HasPrincipalKey<User>(u => u.Id);
        builder.HasMany(u => u.Tasks)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId)
            .HasPrincipalKey(u => u.Id);
        builder.HasMany(u => u.TimeBlocks)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId)
            .HasPrincipalKey(u => u.Id);
        builder.HasMany(u => u.PomodoroSessions)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .HasPrincipalKey(u => u.Id);
    }
}