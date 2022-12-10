using Bromix.Blazor.BrowserAPI.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Bromix.Blazor.BrowserAPI.Extensions.Microsoft.DependencyInjection;

public static class BrowserApiExtensions
{
    /// <summary>
    /// Adds services for accessing the browser API.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IBrowserApiBuilder AddBrowserApi(this IServiceCollection services) => new BrowserApiBuilder(services);
}