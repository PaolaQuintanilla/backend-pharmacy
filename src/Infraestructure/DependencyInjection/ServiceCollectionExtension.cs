using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddLaboratory(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLaboratoryApplication();
            services.AddMySqlDbContexts(configuration);
            services.AddMySqlDbRepositories();

            return services;
        }
    }
}
