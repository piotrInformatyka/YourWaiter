using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Shared.Abstractions.Modules;
using Shared.Infrastructure.API;

namespace Shared.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IList<Assembly> assemblies, IList<IModule> modules)
    {
        services.AddSwaggerGen(swagger =>
        {
            swagger.CustomSchemaIds(x => x.FullName);
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "YourWaiter API",
                Version = "v1"
            });
        });
        services.AddControllers();
        services.AddEndpointsApiExplorer();

        services.AddControllers()
            .ConfigureApplicationPartManager(manager =>
            {
                manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
            });

        return services;
    }
}