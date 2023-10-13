using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyArch.Core.Interfaces.Bases;
using MyArch.DataAccess.Bases;

namespace MyArch.DataAccess
{
    public static class DataAccessDependencies
    {

        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
