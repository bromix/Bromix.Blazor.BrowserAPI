using Microsoft.Extensions.DependencyInjection;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal class BrowserApiBuilder : IBrowserApiBuilder
{
    public BrowserApiBuilder(IServiceCollection services)
    {
        _services = services;
    }

    public IBrowserApiBuilder AddClipboardService()
    {
        _services.AddScoped<IClipboardService, ClipboardService>();
        return this;
    }

    private readonly IServiceCollection _services;
}