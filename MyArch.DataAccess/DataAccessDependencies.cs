using Microsoft.Extensions.DependencyInjection;
using MyArch.Core.Interfaces.Bases;
using MyArch.DataAccess.Bases;

namespace MyArch.DataAccess
{
    public static class DataAccessDependencies
    {

        public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services)
        {

            // Configration of automapper
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
