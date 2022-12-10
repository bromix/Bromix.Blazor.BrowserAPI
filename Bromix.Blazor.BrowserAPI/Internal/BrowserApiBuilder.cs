using Microsoft.Extensions.DependencyInjection;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal sealed class BrowserApiBuilder : IBrowserApiBuilder
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

    public IBrowserApiBuilder AddHistoryService()
    {
        _services.AddScoped<IHistoryService, HistoryService>();
        return this;
    }

    public IBrowserApiBuilder AddLocalStorageService()
    {
        _services.AddScoped<ILocalStorageService, LocalStorageService>();
        return this;
    }

    public IBrowserApiBuilder AddSessionStorageService()
    {
        _services.AddScoped<ISessionStorageService, SessionStorageService>();
        return this;
    }

    private readonly IServiceCollection _services;
}