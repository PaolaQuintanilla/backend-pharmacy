using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Infrastructure.FileExcel;
using Pharmacy.Infrastructure.FileStorage;
using Pharmacy.Infrastructure.Persistences.Contexts;
using Pharmacy.Infrastructure.Persistences.Interfaces;
using Pharmacy.Infrastructure.Persistences.Repositories;

namespace Pharmacy.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(PharmacyContext).Assembly.FullName;

            services.AddDbContext<PharmacyContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("PharmacyConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAzureStorage, AzureStorage>();
            services.AddTransient<IFileStorageLocal, FileStorageLocal>();
            services.AddTransient<IGenerateExcel, GenerateExcel>();

            return services;
        }
    }
}