using System.Reflection;
using Bootstrapper;
using MediatR;
using Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration);
var modules = ModuleLoader.LoadModules(assemblies);

//configure services
builder.Services.AddInfrastructure(assemblies, modules);
foreach (var module in modules)
    module.Register(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();