using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal sealed class SessionStorageService : AbstractStorage, ISessionStorageService
{
    public SessionStorageService(IJSRuntime jsRuntime) : base(jsRuntime, "sessionStorage")
    {
    }
}