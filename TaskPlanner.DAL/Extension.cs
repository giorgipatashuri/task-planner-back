using FonTech.Domain.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskPlanner.DAL.Repositories;
using TaskPlanner.Domain.Entity;

namespace TaskPlanner.DAL;

public static class Extension
{
    public static void AddDataAccessLayer(this IServiceCollection service, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PostgresSQL");
        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
        service.InitRepositories();
    }

    private static void InitRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
    }
}