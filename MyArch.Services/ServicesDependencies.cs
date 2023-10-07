using Microsoft.Extensions.DependencyInjection;
using MyArch.Services.AppServices;
using MyArch.Services.Intefaces;
using System.Reflection;

namespace MyArch.Services
{
    public static class ServicesDependencies
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>();

            // Configration of automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
