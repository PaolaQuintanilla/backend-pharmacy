using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollection
    {
        public static IServiceCollection AddLaboratoryApplication(this IServiceCollection services)
        {
            services.AddLaboratoryServices();

            return services;
        }

    }
}
