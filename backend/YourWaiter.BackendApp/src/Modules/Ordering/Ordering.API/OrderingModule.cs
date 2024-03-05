using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ordering.Application;
using Shared.Abstractions.Modules;

namespace Ordering.API;

public class OrderingModule : IModule
{
    public const string BasePath = "ordering-module";
    public string Name { get; } = "Agendas";
    public string Path => BasePath;

    public void Register(IServiceCollection services)
    {
        services.AddApplication();
    }

    public void Use(IApplicationBuilder app)
    {
    }
}