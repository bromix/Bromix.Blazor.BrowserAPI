namespace Bromix.Blazor.BrowserAPI;

public interface IBrowserApiBuilder
{
    /// <summary>
    /// Adds the <see cref="IClipboardService"/>.
    /// </summary>
    /// <returns></returns>
    IBrowserApiBuilder AddClipboardService();

    /// <summary>
    /// Adds the <see cref="IHistoryService"/>.
    /// </summary>
    /// <returns></returns>
    IBrowserApiBuilder AddHistoryService();

    /// <summary>
    /// Adds the <see cref="ILocalStorageService"/>.
    /// </summary>
    /// <returns></returns>
    IBrowserApiBuilder AddLocalStorageService();

    /// <summary>
    /// Adds the <see cref="ISessionStorageService"/>.
    /// </summary>
    /// <returns></returns>
    IBrowserApiBuilder AddSessionStorageService();
}