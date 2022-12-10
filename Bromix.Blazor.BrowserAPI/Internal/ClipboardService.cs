using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal sealed class ClipboardService : IClipboardService
{
    public ClipboardService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public ValueTask WriteText(string text, CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(ClipboardWriteText, cancellationToken, text);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(ClipboardWriteText, e);
        }
    }

    public ValueTask<string> ReadText(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeAsync<string>(ClipboardReadText, cancellationToken);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(ClipboardReadText, e);
        }
    }

    private const string ClipboardWriteText = "navigator.clipboard.writeText";
    private const string ClipboardReadText = "navigator.clipboard.readText";
    private readonly IJSRuntime _jsRuntime;
}