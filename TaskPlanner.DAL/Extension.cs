using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TaskPlanner.DAL;

public static class Extension
{
    public static void AddDataAccessLayer(this IServiceCollection service, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Postgresql");
        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
        
    }
}