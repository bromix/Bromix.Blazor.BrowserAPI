using Microsoft.JSInterop;

namespace Bromix.Blazor.BrowserAPI;

public class BrowserApiException : Exception
{
    public BrowserApiException()
    {
    }

    public BrowserApiException(string? message) : base(message)
    {
    }

    public BrowserApiException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

public class BrowserApiCallToFunctionException : BrowserApiException
{
    public BrowserApiCallToFunctionException(string function, Exception? innerException) : base(
        $"Call to function '{function}' failed.", innerException)
    {
    }
}