using System.Reflection;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Context;
using Persistence.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMySqlDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddDbContext<PharmacydbContext>(options
                => options.UseMySql(configuration.GetConnectionString("myDbPharmacy"), ServerVersion.AutoDetect(configuration.GetConnectionString("myDbPharmacy"))));

            return services;
        }

        public static IServiceCollection AddMySqlDbRepositories(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ILaboratoryRepository, LaboratoryRepository>();

            return services;
        }
    }
}
