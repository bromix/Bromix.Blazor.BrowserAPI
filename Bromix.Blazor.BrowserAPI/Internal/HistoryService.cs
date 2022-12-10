using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal sealed class HistoryService : IHistoryService
{
    public HistoryService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public ValueTask Forward(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(HistoryForward, cancellationToken);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(HistoryForward, e);
        }
    }

    public ValueTask Back(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(HistoryBack, cancellationToken);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(HistoryBack, e);
        }
    }

    private const string HistoryBack = "history.back";
    private const string HistoryForward = "history.forward";
    private readonly IJSRuntime _jsRuntime;
}