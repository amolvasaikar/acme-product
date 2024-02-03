using AcmeProducts.Application.Interfaces;
using AcmeProducts.Infrastructure.Resources.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcmeProducts.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static void AddResourcesInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.AddSingleton<ITranslator, Translator>();
        }
    }
}
