using Microsoft.EntityFrameworkCore;
using WebApplication.Application.Interfaces;
using WebApplication.Application.Services;
using WebApplication.Infastructure.Persistence;

namespace WebApplication.Infastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(option => option.UseNpgsql(connectionString));
            //services.AddScoped<ITesteService, TesteService>();
            //services.AddScoped<ITesteRepository, ITesteRepository>();

            return services;
        }
    }
}
