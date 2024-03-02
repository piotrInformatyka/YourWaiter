using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Abstractions.Modules;

    public interface IModule
    {
        string Name { get; }
        string Path { get; }
        IEnumerable<string>? Policies => null;
        void Register(IServiceCollection services);
        void Use(IApplicationBuilder app);
    }