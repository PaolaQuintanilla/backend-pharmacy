namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection AddPharmacyModules(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddLaboratory(configuration);

            return service;
        }
    }
}
