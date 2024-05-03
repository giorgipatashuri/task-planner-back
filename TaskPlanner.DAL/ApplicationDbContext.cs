using Microsoft.EntityFrameworkCore;

namespace TaskPlanner.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
}