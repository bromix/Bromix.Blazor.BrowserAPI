namespace Bromix.Blazor.BrowserAPI;

public interface IStorage
{
    /// <summary>
    /// Adds the value value with the specified key to the Storage, or update that key's value if it already exists.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask SetItem(string key, string value, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the value of the specified key.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask<string?> GetItem(string key, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears the storage.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask Clear(CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes the value of the specified key.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask RemoveItem(string key, CancellationToken cancellationToken = default);
}