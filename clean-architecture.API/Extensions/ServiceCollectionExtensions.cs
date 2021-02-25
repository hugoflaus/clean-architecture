using clean_architecture.Application.Services;
using clean_architecture.Core.Interfaces.Repositories;
using clean_architecture.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
       
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}