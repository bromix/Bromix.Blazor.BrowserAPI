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

    public ValueTask<int> GetLength(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeAsync<int>("eval", cancellationToken, StorageGetLength);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageGetLength, e);
        }
    }

    public ValueTask<IEnumerable<string>> GetKeys(CancellationToken cancellationToken = default)
    {
        try
        {
            return _jsRuntime.InvokeAsync<IEnumerable<string>>("eval", cancellationToken, StorageGetKeys);
        }
        catch (JSException e)
        {
            throw new BrowserApiCallToFunctionException(StorageGetKeys, e);
        }
    }

    private string StorageSetItem => $"{_storageName}.setItem";
    private string StorageGetItem => $"{_storageName}.getItem";
    private string StorageRemoveItem => $"{_storageName}.removeItem";
    private string StorageClear => $"{_storageName}.clear";
    private string StorageGetLength => $"{_storageName}.length";
    private string StorageGetKeys => $"Object.keys({_storageName})";
    private readonly IJSRuntime _jsRuntime;
    private readonly string _storageName;
}