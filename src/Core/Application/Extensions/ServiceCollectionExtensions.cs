
using Application.Services;
using Domain.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLaboratoryServices(this IServiceCollection services)
        {
            services.AddScoped<ILaboratoryService, LaboratoryService>();

            return services;
        }
    }
}
