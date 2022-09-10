using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal class LocalStorageService : AbstractStorage, ILocalStorageService
{
    public LocalStorageService(IJSRuntime jsRuntime) : base(jsRuntime, "localStorage")
    {
    }
}