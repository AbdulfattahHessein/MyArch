using Microsoft.Extensions.DependencyInjection;
using MyArch.BusinessLogic.AppServices;
using MyArch.BusinessLogic.Intefaces;
using System.Reflection;

namespace MyArch.BusinessLogic
{
    public static class BusinessLogicDependencies
    {
        public static IServiceCollection AddBusinessLogicDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductsService, ProductsService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());


            return services;
        }
    }
}
