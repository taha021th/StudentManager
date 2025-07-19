using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManager.Application.Interfaces;
using StudentManager.Infrastructure.Persistence;
using StudentManager.Infrastructure.Repositories;

namespace StudentManager.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")

                ));
            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}
