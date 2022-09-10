namespace Bromix.Blazor.BrowserAPI;

public interface IHistoryService
{
    /// <summary>
    /// The method causes the browser to move forward one page in the session history.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask Forward(CancellationToken cancellationToken = default);

    /// <summary>
    /// The method causes the browser to move back one page in the session history.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    ValueTask Back(CancellationToken cancellationToken = default);
}