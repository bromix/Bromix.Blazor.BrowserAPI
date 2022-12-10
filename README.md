# Bromix.Blazor.BrowserAPI

## Dependency Injection

Register the service via Dependency Injection.

```csharp
builder.Services
    .AddBrowserApi()
        .AddClipboardService()
        .AddHistoryService()
        .AddLocalStorageService();
```

## Usage

### Clipboard

Inject the **IClipboardService** in your Blazor Page or Component.

```csharp
@inject IClipboardService ClipboardService
...
@code {
    private string text = "";
    
    private async Task WriteToClipboard()
    {
        await ClipboardService.WriteText("Hello World");
        text = await ClipboardService.ReadText();
    }
}
```

### Storage

Inject the **ILocalStorageService** or **ISessionStorageService** in your Blazor Page or Component.

```csharp
@inject ILocalStorageService LocalStorageService
...
@code {
    private string? _text;
    private int _count = 0;
    private string _keys = string.Empty;

    private async Task SetItem()
    {
        await LocalStorageService.SetItem("Say", "Hello World");
        _text = await LocalStorageService.GetItem("Say");
        _count = await LocalStorageService.GetLength();

        var keys = await LocalStorageService.GetKeys();
        _keys = string.Join(',', keys);
    }
}
```
