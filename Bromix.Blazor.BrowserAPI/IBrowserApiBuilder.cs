namespace Bromix.Blazor.BrowserAPI;

public interface IBrowserApiBuilder
{
    /// <summary>
    /// Adds the <see cref="IClipboardService"/>.
    /// </summary>
    /// <returns></returns>
    IBrowserApiBuilder AddClipboardService();
}