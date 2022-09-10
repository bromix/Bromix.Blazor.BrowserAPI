using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI.Internal;

internal abstract class AbstractStorage : IStorage
{
    protected AbstractStorage(IJSRuntime jsRuntime, string storageName)
    {
        _jsRuntime = jsRuntime;
        _storageName = storageName;
    }

    public ValueTask SetItem(string key, string value, CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(StorageSetItem, cancellationToken, key, value);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageSetItem, e);
        }
    }

    public ValueTask<string?> GetItem(string key, CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeAsync<string?>(StorageGetItem, cancellationToken, key);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageGetItem, e);
        }
    }

    public ValueTask Clear(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(StorageClear, cancellationToken);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageClear, e);
        }
    }

    public ValueTask RemoveItem(string key, CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeVoidAsync(StorageRemoveItem, cancellationToken);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageRemoveItem, e);
        }
    }

    private string StorageSetItem => $"window.{_storageName}.setItem";
    private string StorageGetItem => $"window.{_storageName}.getItem";
    private string StorageRemoveItem => $"window.{_storageName}.removeItem";
    private string StorageClear => $"window.{_storageName}.clear";
    private readonly IJSRuntime _jsRuntime;
    private readonly string _storageName;
}