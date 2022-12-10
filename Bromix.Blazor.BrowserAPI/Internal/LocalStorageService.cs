using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal sealed class LocalStorageService : AbstractStorage, ILocalStorageService
{
    public LocalStorageService(IJSRuntime jsRuntime) : base(jsRuntime, "localStorage")
    {
    }
}