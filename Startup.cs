using System;
using ApplicationTemplate.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationTemplate;

/// <summary>
///     Used for registration of new interfaces
/// </summary>
internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        // Add new lines of code here to register any interfaces and concrete services you create
        services.AddTransient<IMainService, MainService>();
        services.AddTransient<IFileService, FileService>();

        return services.BuildServiceProvider();
    }
}
