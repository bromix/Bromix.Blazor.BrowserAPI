namespace Bromix.Blazor.BrowserAPI;

public interface IClipboardService
{
    /// <summary>
    /// Writes the specified text string to the system clipboard.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask WriteText(string text, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the text int the system clipboard. An empty string if the clipboard is empty.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>The text int the system clipboard. An empty string if the clipboard is empty.</returns>
    ValueTask<string> ReadText(CancellationToken cancellationToken = default);
}