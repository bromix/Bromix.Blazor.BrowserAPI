using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal class SessionStorageService : AbstractStorage, ISessionStorageService
{
    public SessionStorageService(IJSRuntime jsRuntime) : base(jsRuntime, "sessionStorage")
    {
    }
}